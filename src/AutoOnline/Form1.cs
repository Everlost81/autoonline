using System;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace AutoOnline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool activated = false;

        private void UpdateStatus(object source = null, EventArgs eventArgs = null)
        {
            var isRunning = IsPoeRunning();
            PoeStatusLabel.Text = isRunning  ? "Running" : "Not running";
            PoeStatusLabel.ForeColor = isRunning ? Color.Green : Color.Red;

            if (isRunning)
            {
                if (activated)
                {
                    SendUpdateToXyz();
                }
            }
            else
            {
                // Reset timer status if PoE was running earlier
                poeStatusTimer.Interval = 1000;
            }
        }

        bool SendUpdateToXyz()
        {
            var url = new Uri(XyzUrlTextBox.Text);
            var req = (HttpWebRequest) WebRequest.Create(url);
            req.Method = "POST";
            req.AllowAutoRedirect = false;
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)req.GetResponse();
            }
            catch (WebException ex)
            {
                MessageBox.Show("Connection failed. poe.xyz.is returned: " + ex.Message);
                return false;    
            }

            if (response.Headers["Location"].ToLower() != url.ToString().ToLower())
            {
                MessageBox.Show("Connection failed. Wrong poe.xyz.is online link.");
                return false;    
            }
            req.Abort(); // Abort to be sure requests don't hang
            ShopIndexerStatusLabel.Text = DateTime.Now.ToShortTimeString() + " (Next: " + DateTime.Now.AddHours(1).ToShortTimeString() + ")";
            
            return true;
        }

        bool SendUpdateToPoeMarkets()
        {
            var url = PoemarketsUrlTextBox.Text;
            if (!url.EndsWith("/"))
                url += "/";
            url += "status";

            var uri = new Uri(url);

            var postData = "utf8=%E2%9C%93&_method=put&duration=1";
            var byteArray = Encoding.UTF8.GetBytes(postData);
            
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            request.Method = "POST";
            request.AllowAutoRedirect = false;

            HttpWebResponse response = null;
            try
            {
                var dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                response = (HttpWebResponse) request.GetResponse();

            }
            catch (WebException ex)
            {
                MessageBox.Show("Connection failed. Poemarkets returned: " + ex.Message);
                return false;
            }

            if (response.Headers["Location"].ToLower() != PoemarketsUrlTextBox.Text.ToLower())
            {
                MessageBox.Show("Connection failed. Wrong Poemarkets Seller Page URL.");
                return false;
            }
            request.Abort(); // Abort to be sure requests don't hang

            ShopIndexerStatusLabel.Text = DateTime.Now.ToShortTimeString() + " (Next: " + DateTime.Now.AddHours(1).ToShortTimeString() + ")";
            return true;
        }

        bool IsPoeRunning()
        {
            return Process.GetProcesses().Any(
                process => process.ProcessName.ToLower().Contains("pathofexile"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XyzUrlTextBox.Text = Properties.Settings.Default.OnlineLink;
            PoemarketsUrlTextBox.Text = Properties.Settings.Default.PoemarketsUrl;
            UpdateStatus();
            poeStatusTimer.Tick += UpdateStatus;
            poeStatusTimer.Start();
            
        }

        private void ActivateButton_Click(object sender, EventArgs e)
        {
            if (!activated)
            {
                if (!IsPoeRunning())
                {
                    MessageBox.Show("Path of Exile is not running.");
                    return;
                }
                try
                {
                    if (!string.IsNullOrWhiteSpace(XyzUrlTextBox.Text))
                    {
                        new Uri(XyzUrlTextBox.Text);
                    }
                        
                }
                catch (Exception)
                {
                    XyzUrlTextBox.BackColor = Color.LightPink;
                    return;
                }

                try
                {
                    if (!string.IsNullOrWhiteSpace(PoemarketsUrlTextBox.Text))
                    {
                        new Uri(PoemarketsUrlTextBox.Text);
                    }
                }
                catch (Exception)
                {
                    PoemarketsUrlTextBox.BackColor = Color.LightPink;
                    return;
                }

                ShopIndexerStatusLabel.Text = "Connecting...";

                XyzUrlTextBox.Enabled = false;
                PoemarketsUrlTextBox.Enabled = false;

                bool couldSendUpdateToXyz = false;
                if (!string.IsNullOrWhiteSpace(XyzUrlTextBox.Text))
                {
                    couldSendUpdateToXyz = SendUpdateToXyz();
                }

                bool couldSendUpdateToPoeMarkets = false;
                if (!string.IsNullOrWhiteSpace(PoemarketsUrlTextBox.Text))
                {
                    couldSendUpdateToPoeMarkets = SendUpdateToPoeMarkets();
                }

                poeStatusTimer.Interval = 60 * 60 * 1000; // Set timer to only check PoE status every 1 hour

                if (!couldSendUpdateToXyz && !couldSendUpdateToPoeMarkets)
                {
                    activated = false;
                    ShopIndexerStatusLabel.Text = "N/A";
                    ActivateButton.Text = "Activate";
                    XyzUrlTextBox.Enabled = true;
                    PoemarketsUrlTextBox.Enabled = true;
                    return;
                }
                
                Properties.Settings.Default.OnlineLink = XyzUrlTextBox.Text;
                Properties.Settings.Default.PoemarketsUrl = PoemarketsUrlTextBox.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                XyzUrlTextBox.Enabled = true;
                PoemarketsUrlTextBox.Enabled = true;
                ShopIndexerStatusLabel.Text = "N/A";
            }

            activated = !activated;           
            XyzUrlTextBox.ResetBackColor();
            
            ActivateButton.Text = !activated ? "Activate" : "Deactive";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string marketsPath = GetMarketsFilePath();
            File.Create(marketsPath).Dispose();

            MarketPaths marketPaths = new MarketPaths();
            marketPaths.PoeMarket = PoemarketsUrlTextBox.Text;
            marketPaths.PoeXyz = XyzUrlTextBox.Text;
            
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            File.WriteAllText(marketsPath, serializer.Serialize(marketPaths));
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            MarketPaths marketPaths = serializer.Deserialize<MarketPaths>(File.ReadAllText(GetMarketsFilePath()));
            PoemarketsUrlTextBox.Text = marketPaths.PoeMarket;
            XyzUrlTextBox.Text = marketPaths.PoeXyz;
        }

        private string GetMarketsFilePath()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\markets.txt";
        }

        private class MarketPaths 
        {
            public string PoeMarket;
            public string PoeXyz;
        }
    }
}
