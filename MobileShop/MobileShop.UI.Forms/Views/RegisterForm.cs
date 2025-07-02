using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop.UI.Forms.Views
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void loginLbl_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();

            loginForm.FormClosed += (s, args) =>
            {
                this.Show();
            };

            loginForm.Show();
            this.Hide();
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
