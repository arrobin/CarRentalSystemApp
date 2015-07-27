using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSystemApp.DLL.DAO;

namespace CarRentalSystemApp.DLL.Gateway
{
    class CustomerDetailsGateway
    {
        private static SqlConnection aConnection = new SqlConnection();
        public CustomerDetailsGateway()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CarRentalSystemDBConnectionString"].ConnectionString;
            aConnection.ConnectionString = connectionString;
        }

        public CustomerInformation GetCustomerInformation(double customerPhoneNo)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_customer_information WHERE phone_no = '{0}'", customerPhoneNo);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            CustomerInformation customer = new CustomerInformation();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    customer.Id = (int)aReader[0];
                    customer.Name = aReader[1].ToString();
                    customer.Address = aReader[2].ToString();
                    customer.PhoneNo = aReader[3].ToString();


                }
            }
            aConnection.Close();
            return customer;
        }

        public Billing GetBillingDetails(int customerId)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_billing_information WHERE customer_id = {0}", customerId);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            Billing billing = new Billing();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    billing.Id = (int)aReader[0];
                    billing.TotalCost = Convert.ToDouble(aReader[1].ToString());
                    billing.Advance = Convert.ToDouble(aReader[2].ToString());
                    billing.Due = Convert.ToDouble(aReader[3].ToString());
                    billing.BillingDate = aReader[4].ToString();
                    billing.BookId = Convert.ToInt32(aReader[5].ToString());
                    billing.CustomerId = Convert.ToInt32(aReader[6].ToString());


                }
            }
            aConnection.Close();
            return billing;
        }

        public BookingDetails GetBookingDetails(int bookId)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_booking_details WHERE id = {0}", bookId);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            BookingDetails bookingDetails = new BookingDetails();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    bookingDetails.Id = (int)aReader[0];
                    bookingDetails.Destination = aReader[1].ToString();
                    bookingDetails.Distance = Convert.ToDouble(aReader[2].ToString());
                    bookingDetails.Date = aReader[3].ToString();
                    bookingDetails.Time = aReader[4].ToString();
                    bookingDetails.VehicleId= Convert.ToInt32(aReader[5].ToString());
                    
                }
            }
            aConnection.Close();
            return bookingDetails;
        }

        public Vehicle GetVehicleDetails(int vehicleId)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_vehicle_information WHERE id = {0}", vehicleId);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            Vehicle vehicles = new Vehicle();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    vehicles.Id = (int)aReader[0];
                    vehicles.RegNO = aReader[1].ToString();
                    vehicles.OwnerName = aReader[2].ToString();
                    vehicles.Deal = Convert.ToInt32(aReader[3].ToString());
                    vehicles.DriverName = aReader[4].ToString();
                    vehicles.Model = aReader[5].ToString();
                    vehicles.Status = aReader[6].ToString();


                }
            }
            aConnection.Close();
            return vehicles;
        }
    }
}
