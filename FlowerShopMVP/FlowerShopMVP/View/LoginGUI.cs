using FlowerShopMVP.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShopMVP.View
{
    public partial class LoginGUI : Form, ILoginGUI
    {
        private LoginPresenter loginPresenter;

        public LoginGUI()
        {
            InitializeComponent();
            this.loginPresenter = new LoginPresenter(this);
        }
        // ILoginGUI=========================================================================
        public void SetMessage(string title, string message)
        {
            MessageBox.Show(message, title);
        }

        public void HideForm()
        {
            this.Hide();
        }

        public string GetUsername()
        {
            return this.textBoxUsername.Text;
        }

        public string GetPassword()
        {
            return this.textBoxPassword.Text;
        }

        // Button event======================================================================

        // GUI Specific======================================================================
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFontChanged(e);
            Environment.Exit(0);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.loginPresenter.Login();
        }
    }
}
