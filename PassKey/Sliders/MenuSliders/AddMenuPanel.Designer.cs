﻿using System.Windows.Forms;

namespace PassKey.Sliders.MenuSliders
{
    partial class AddMenuPanel
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
            this.hostTextBox = new MetroFramework.Controls.MetroTextBox();
            this.emailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.usernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.closeButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // hostTextBox
            // 
            // 
            // 
            // 
            this.hostTextBox.CustomButton.Image = null;
            this.hostTextBox.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.hostTextBox.CustomButton.Name = "";
            this.hostTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.hostTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hostTextBox.CustomButton.TabIndex = 1;
            this.hostTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hostTextBox.CustomButton.UseSelectable = true;
            this.hostTextBox.CustomButton.Visible = false;
            this.hostTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.hostTextBox.Lines = new string[0];
            this.hostTextBox.Location = new System.Drawing.Point(38, 109);
            this.hostTextBox.MaxLength = 32767;
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.PasswordChar = '\0';
            this.hostTextBox.PromptText = "Host name";
            this.hostTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hostTextBox.SelectedText = "";
            this.hostTextBox.SelectionLength = 0;
            this.hostTextBox.SelectionStart = 0;
            this.hostTextBox.ShortcutsEnabled = true;
            this.hostTextBox.Size = new System.Drawing.Size(167, 23);
            this.hostTextBox.TabIndex = 0;
            this.hostTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.hostTextBox.UseSelectable = true;
            this.hostTextBox.WaterMark = "Host name";
            this.hostTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hostTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // emailTextBox
            // 
            // 
            // 
            // 
            this.emailTextBox.CustomButton.Image = null;
            this.emailTextBox.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.emailTextBox.CustomButton.Name = "";
            this.emailTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailTextBox.CustomButton.TabIndex = 1;
            this.emailTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailTextBox.CustomButton.UseSelectable = true;
            this.emailTextBox.CustomButton.Visible = false;
            this.emailTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.emailTextBox.Lines = new string[0];
            this.emailTextBox.Location = new System.Drawing.Point(38, 198);
            this.emailTextBox.MaxLength = 32767;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PromptText = "Email";
            this.emailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.SelectionLength = 0;
            this.emailTextBox.SelectionStart = 0;
            this.emailTextBox.ShortcutsEnabled = true;
            this.emailTextBox.Size = new System.Drawing.Size(167, 23);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.emailTextBox.UseSelectable = true;
            this.emailTextBox.WaterMark = "Email";
            this.emailTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // usernameTextBox
            // 
            // 
            // 
            // 
            this.usernameTextBox.CustomButton.Image = null;
            this.usernameTextBox.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.usernameTextBox.CustomButton.Name = "";
            this.usernameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.usernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernameTextBox.CustomButton.TabIndex = 1;
            this.usernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernameTextBox.CustomButton.UseSelectable = true;
            this.usernameTextBox.CustomButton.Visible = false;
            this.usernameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.usernameTextBox.Lines = new string[0];
            this.usernameTextBox.Location = new System.Drawing.Point(38, 288);
            this.usernameTextBox.MaxLength = 32767;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.PromptText = "Username";
            this.usernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.SelectionLength = 0;
            this.usernameTextBox.SelectionStart = 0;
            this.usernameTextBox.ShortcutsEnabled = true;
            this.usernameTextBox.Size = new System.Drawing.Size(167, 23);
            this.usernameTextBox.TabIndex = 2;
            this.usernameTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.usernameTextBox.UseSelectable = true;
            this.usernameTextBox.WaterMark = "Username";
            this.usernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passwordTextBox
            // 
            // 
            // 
            // 
            this.passwordTextBox.CustomButton.Image = null;
            this.passwordTextBox.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.passwordTextBox.CustomButton.Name = "";
            this.passwordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextBox.CustomButton.TabIndex = 1;
            this.passwordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextBox.CustomButton.UseSelectable = true;
            this.passwordTextBox.CustomButton.Visible = false;
            this.passwordTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.passwordTextBox.Lines = new string[0];
            this.passwordTextBox.Location = new System.Drawing.Point(38, 372);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.PromptText = "Password";
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(167, 23);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.passwordTextBox.UseSelectable = true;
            this.passwordTextBox.WaterMark = "Password";
            this.passwordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(38, 463);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.addButton.UseSelectable = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(130, 463);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.closeButton.UseSelectable = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AddMenuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.hostTextBox);
            this.Name = "AddMenuPanel";
            this.Size = new System.Drawing.Size(240, 500);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox hostTextBox;
        private MetroFramework.Controls.MetroTextBox emailTextBox;
        private MetroFramework.Controls.MetroTextBox usernameTextBox;
        private MetroFramework.Controls.MetroTextBox passwordTextBox;
        private MetroFramework.Controls.MetroButton addButton;
        private MetroFramework.Controls.MetroButton closeButton;
    }
}
