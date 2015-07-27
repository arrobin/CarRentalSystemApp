using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSystemApp.BLL;
using CarRentalSystemApp.DLL.DAO;

namespace CarRentalSystemApp.DLL.Gateway
{
    class VehicleGateway
    {
        
        private VehicleBLL aVehicleBll;
        private SqlConnection aConnection = new SqlConnection();
        private Vehicle aVehicle;

        public VehicleGateway()
        {
            
            string connectionString = ConfigurationManager.ConnectionStrings["CarRentalSystemDBConnectionString"].ConnectionString;
            aConnection.ConnectionString = connectionString;
            //aVehicleBll = new VehicleBLL();
        }
        

        public bool Save(string regNo, string model, string ownerName, string driverName, int deal,string status)
        {
            aConnection.Open();
            string query = string.Format("INSERT INTO t_vehicle_information VALUES('{0}','{1}',{2},'{3}','{4}','{5}')", regNo, ownerName, deal, driverName, model,status);

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            int total = aCommand.ExecuteNonQuery();
            aConnection.Close();
            if (total > 0)
                return true;
            return false;


            
        }

        public List<Vehicle> GetAllVehicle()
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_vehicle_information");
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<Vehicle> vehicles = new List<Vehicle>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    aVehicle = new Vehicle();
                    aVehicle.Id = (int) aReader[0];
                    aVehicle.RegNO = aReader[1].ToString();
                    aVehicle.OwnerName = aReader[2].ToString();
                    aVehicle.Deal = Convert.ToInt32(aReader[3]);
                    aVehicle.DriverName = aReader[4].ToString();
                    aVehicle.Model = aReader[5].ToString();
                    aVehicle.Status = aReader[6].ToString();
                    
                    vehicles.Add(aVehicle);
                }
            }
            aConnection.Close();
            return vehicles;
        }

        public string GetDriverName(string regNo)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_vehicle_information WHERE reg_no='{0}'",regNo);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    aVehicle = new Vehicle();
                    aVehicle.DriverName = aReader[4].ToString();
                }
            }
            aConnection.Close();
            return aVehicle.DriverName;
        }

        public bool HasthisVehicleAlrady(string regNo)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_vehicle_information WHERE reg_no='{0}'",regNo);

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            bool msg = aReader.HasRows;
            aConnection.Close();
            return msg;
        }

        public bool UpdateVehicleInformation(string regNo, string ownerName, int deal, string driverName, string model,string status)
        {
            aConnection.Open();
            string query = string.Format("UPDATE t_vehicle_information SET owner_name ='{0}', deal_percent = {1}, driver_name = '{2}',status = '{3}' WHERE reg_no = '{4}'", ownerName, deal, driverName,status, regNo);

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            int total = aCommand.ExecuteNonQuery();
            aConnection.Close();
            if (total > 0)
                return true;
            return false;
        }
    }
}
