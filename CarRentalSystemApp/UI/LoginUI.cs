using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalSystemApp.BLL;
using CarRentalSystemApp.DLL.DAO;

namespace CarRentalSystemApp.UI
{
    public partial class LoginUI : Form
    {
        
        public LoginUI()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login aLogin = new Login();
            LoginBll aLoginBll =new LoginBll();
            aLogin.UserName = userNameTextBox.Text;
            aLogin.Password = passwordTextBox.Text;
            userNameTextBox.Text = "";
            passwordTextBox.Text = "";

            string msg = aLoginBll.Check(aLogin.UserName,aLogin.Password);
            MessageBox.Show(msg);
        }
    }
}
