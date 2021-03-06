﻿namespace PassKey.Sliders.MenuSliders
{
    partial class AccountDeletePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeLink = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            // 
            // 
            // 
            this.passwordTextBox.CustomButton.Image = null;
            this.passwordTextBox.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.passwordTextBox.CustomButton.Name = "";
            this.passwordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextBox.CustomButton.TabIndex = 1;
            this.passwordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextBox.CustomButton.UseSelectable = true;
            this.passwordTextBox.CustomButton.Visible = false;
            this.passwordTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.passwordTextBox.Lines = new string[0];
            this.passwordTextBox.Location = new System.Drawing.Point(36, 80);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.PromptText = "Enter password";
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(169, 23);
            this.passwordTextBox.TabIndex = 0;
            this.passwordTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.passwordTextBox.UseSelectable = true;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.WaterMark = "Enter password";
            this.passwordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passwordLabel
            // 
            this.passwordLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.passwordLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.passwordLabel.Location = new System.Drawing.Point(0, 61);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(237, 16);
            this.passwordLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "invalid password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.passwordLabel.UseStyleColors = true;
            this.passwordLabel.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(83, 140);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.deleteButton.UseSelectable = true;
            this.deleteButton.UseStyleColors = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PassKey.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(32, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // closeLink
            // 
            this.closeLink.BackColor = System.Drawing.Color.Transparent;
            this.closeLink.Image = global::PassKey.Properties.Resources.back_Enabled;
            this.closeLink.ImageSize = 36;
            this.closeLink.Location = new System.Drawing.Point(193, 14);
            this.closeLink.Name = "closeLink";
            this.closeLink.NoFocusImage = global::PassKey.Properties.Resources.back_Disabled;
            this.closeLink.Size = new System.Drawing.Size(44, 36);
            this.closeLink.TabIndex = 8;
            this.closeLink.UseCustomBackColor = true;
            this.closeLink.UseSelectable = true;
            this.closeLink.Click += new System.EventHandler(this.closeLink_Click);
            // 
            // AccountDeletePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeLink);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Name = "AccountDeletePanel";
            this.Size = new System.Drawing.Size(240, 400);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox passwordTextBox;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroButton deleteButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLink closeLink;
    }
}
