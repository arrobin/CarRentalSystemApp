using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystemApp.DLL.Gateway
{
    class LoginGateway
    {
        private SqlConnection aConnection = new SqlConnection();
        public LoginGateway()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CarRentalSystemDBConnectionString"].ConnectionString;
            aConnection.ConnectionString = connectionString;
        }

        public bool Check(string userName, string password)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_admin WHERE id ='{0}'AND password ='{1}'", userName,password);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            bool msg = aReader.HasRows;
            aConnection.Close();
            return msg;
        }
    }
}
