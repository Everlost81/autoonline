﻿namespace AutoOnline
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.poeStatusTimer = new System.Windows.Forms.Timer(this.components);
            this.PoeStatusLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.XyzUrlTextBox = new System.Windows.Forms.TextBox();
            this.ShopIndexerStatusLabel = new System.Windows.Forms.Label();
            this.XyzUrlLabel = new System.Windows.Forms.Label();
            this.ActivateButton = new System.Windows.Forms.Button();
            this.PoemarketsUrlLabel = new System.Windows.Forms.Label();
            this.PoemarketsUrlTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AccountNames = new System.Windows.Forms.ComboBox();
            this.Account = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // poeStatusTimer
            // 
            this.poeStatusTimer.Interval = 1000;
            // 
            // PoeStatusLabel
            // 
            this.PoeStatusLabel.AutoSize = true;
            this.PoeStatusLabel.Location = new System.Drawing.Point(138, 16);
            this.PoeStatusLabel.Name = "PoeStatusLabel";
            this.PoeStatusLabel.Size = new System.Drawing.Size(56, 13);
            this.PoeStatusLabel.TabIndex = 4;
            this.PoeStatusLabel.Text = "Undefined";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PoE status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last updated:";
            // 
            // XyzUrlTextBox
            // 
            this.XyzUrlTextBox.Location = new System.Drawing.Point(20, 165);
            this.XyzUrlTextBox.Name = "XyzUrlTextBox";
            this.XyzUrlTextBox.Size = new System.Drawing.Size(261, 20);
            this.XyzUrlTextBox.TabIndex = 2;
            // 
            // ShopIndexerStatusLabel
            // 
            this.ShopIndexerStatusLabel.AutoSize = true;
            this.ShopIndexerStatusLabel.Location = new System.Drawing.Point(138, 39);
            this.ShopIndexerStatusLabel.Name = "ShopIndexerStatusLabel";
            this.ShopIndexerStatusLabel.Size = new System.Drawing.Size(27, 13);
            this.ShopIndexerStatusLabel.TabIndex = 6;
            this.ShopIndexerStatusLabel.Text = "N/A";
            // 
            // XyzUrlLabel
            // 
            this.XyzUrlLabel.AutoSize = true;
            this.XyzUrlLabel.Location = new System.Drawing.Point(20, 149);
            this.XyzUrlLabel.Name = "XyzUrlLabel";
            this.XyzUrlLabel.Size = new System.Drawing.Size(81, 13);
            this.XyzUrlLabel.TabIndex = 0;
            this.XyzUrlLabel.Text = "poe.xyz.is URL:";
            // 
            // ActivateButton
            // 
            this.ActivateButton.Location = new System.Drawing.Point(20, 194);
            this.ActivateButton.Name = "ActivateButton";
            this.ActivateButton.Size = new System.Drawing.Size(261, 43);
            this.ActivateButton.TabIndex = 3;
            this.ActivateButton.Text = "Activate";
            this.ActivateButton.UseVisualStyleBackColor = true;
            this.ActivateButton.Click += new System.EventHandler(this.ActivateButton_Click);
            // 
            // PoemarketsUrlLabel
            // 
            this.PoemarketsUrlLabel.AutoSize = true;
            this.PoemarketsUrlLabel.Location = new System.Drawing.Point(20, 110);
            this.PoemarketsUrlLabel.Name = "PoemarketsUrlLabel";
            this.PoemarketsUrlLabel.Size = new System.Drawing.Size(114, 13);
            this.PoemarketsUrlLabel.TabIndex = 8;
            this.PoemarketsUrlLabel.Text = "Poemarkets.com URL:";
            // 
            // PoemarketsUrlTextBox
            // 
            this.PoemarketsUrlTextBox.Location = new System.Drawing.Point(20, 126);
            this.PoemarketsUrlTextBox.Name = "PoemarketsUrlTextBox";
            this.PoemarketsUrlTextBox.Size = new System.Drawing.Size(261, 20);
            this.PoemarketsUrlTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "by jhovgaard (ingame: DexOfDux)\r\nj@jhovgaard.dk";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(182, 86);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(40, 21);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AccountNames
            // 
            this.AccountNames.FormattingEnabled = true;
            this.AccountNames.Location = new System.Drawing.Point(20, 86);
            this.AccountNames.Name = "AccountNames";
            this.AccountNames.Size = new System.Drawing.Size(156, 21);
            this.AccountNames.TabIndex = 0;
            this.AccountNames.SelectedIndexChanged += new System.EventHandler(this.AccountNames_Select);
            this.AccountNames.Enter += new System.EventHandler(this.AccountNames_Focus);
            // 
            // Account
            // 
            this.Account.AutoSize = true;
            this.Account.Location = new System.Drawing.Point(20, 70);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(50, 13);
            this.Account.TabIndex = 12;
            this.Account.Text = "Account:";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(228, 86);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(53, 21);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 272);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.AccountNames);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PoemarketsUrlLabel);
            this.Controls.Add(this.PoemarketsUrlTextBox);
            this.Controls.Add(this.ActivateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.XyzUrlLabel);
            this.Controls.Add(this.PoeStatusLabel);
            this.Controls.Add(this.ShopIndexerStatusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.XyzUrlTextBox);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Auto Online for Shop Indexers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer poeStatusTimer;
        private System.Windows.Forms.Label PoeStatusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox XyzUrlTextBox;
        private System.Windows.Forms.Label ShopIndexerStatusLabel;
        private System.Windows.Forms.Label XyzUrlLabel;
        private System.Windows.Forms.Button ActivateButton;
        private System.Windows.Forms.Label PoemarketsUrlLabel;
        private System.Windows.Forms.TextBox PoemarketsUrlTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox AccountNames;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Button DeleteButton;
    }
}

