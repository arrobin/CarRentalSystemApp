using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSystemApp.DLL.DAO;
using CarRentalSystemApp.DLL.Gateway;
using CarRentalSystemApp.UI;

namespace CarRentalSystemApp.BLL
{
    class LoginBll
    {
        private Login aLogin;
        private LoginGateway aLoginGateway;

        public LoginBll()
        {
            aLogin = new Login();
            aLoginGateway = new LoginGateway();
        }

        public string Check(string userName, string password)
        {
            if (aLoginGateway.Check(userName,password))
            {
                MainUI aMainUi = new MainUI();
                aMainUi.ShowDialog();
                return "Thanks for Using This Software";
            }
            else
            {
                return "Login Faild";
            }
        }
    }
}
