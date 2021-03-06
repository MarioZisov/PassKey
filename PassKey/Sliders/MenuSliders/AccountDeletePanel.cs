﻿namespace PassKey.Sliders.MenuSliders
{
    using System;
    using System.Windows.Forms;
    using UserInfo;
    using SecurityUtilities;
    using Data;
    using MetroFramework;

    public partial class AccountDeletePanel : BaseMenuSliderPanel
    {
        private UserPanel userPanel;

        public AccountDeletePanel(Form form, LoggedUser user, UserPanel userPanel)
            : base(form, user)
        {
            this.InitializeComponent();
            this.userPanel = userPanel;
            this.deleteButton.UseSelectable = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.passwordLabel.Visible = false;
            if (!string.IsNullOrWhiteSpace(this.passwordTextBox.Text))
            {
                string hashedPass = HashUtilities.HashPassword(this.passwordTextBox.Text);
                if (hashedPass == RegistryData.GetUserPassword(this.User.Username))
                {
                    RegistryData.DeleteAccout(this.User.Username);
                    MetroMessageBox.Show(this.MainForm, string.Empty, GlobalMessages.AccountDeleted
                        , MessageBoxButtons.OK, MessageBoxIcon.Information, 80);
                    this.Swipe(false);
                    this.userPanel.Logout();
                }
                else
                {
                    this.passwordLabel.Visible = true;
                }
            }
        }

        private void closeLink_Click(object sender, EventArgs e)
        {
            this.Swipe(false);
        }
    }
}