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
    class RentalInformationGateway
    {
        private static SqlConnection aConnection = new SqlConnection();
        private BookingDetails aBookingDetails;
        private CustomerInformation aCustomerInformation;
        private Billing aBilling;
        private RentalInformation aRentalInformation;

        public RentalInformationGateway()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CarRentalSystemDBConnectionString"].ConnectionString;
            aConnection.ConnectionString = connectionString;
        }

        public List<Billing> GetAllBillingDetails()
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_billing_information");
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<Billing> billings = new List<Billing>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    aBilling = new Billing();
                    aBilling.Id = (int) aReader[0];
                    aBilling.TotalCost = Convert.ToDouble(aReader[1].ToString());
                    aBilling.Advance = Convert.ToDouble(aReader[2].ToString());
                    aBilling.Due = Convert.ToDouble(aReader[3].ToString());
                    aBilling.BillingDate = aReader[4].ToString();
                    aBilling.BookId = (int)aReader[5];
                    
                    billings.Add(aBilling);
                }
            }
            aConnection.Close();
            return billings;
        }

        public CustomerInformation GetCustomerId(string phoneNo)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_customer_information WHERE phone_no = {0}",phoneNo);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            CustomerInformation customer = new CustomerInformation();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    customer.Id = (int) aReader[0];
                    customer.Name = aReader[1].ToString();
                    customer.Address = aReader[2].ToString();
                    customer.PhoneNo = aReader[3].ToString();
                    

                }
            }
            aConnection.Close();
            return customer;
        }

        
        public static bool SaveRentalInformation(string regNo, string rentDate, string destination, double payment, double cost, double profit, double commission, string paymentStatus)
        {
            aConnection.Open();
            string query = string.Format("INSERT INTO t_rental_information VALUES('{0}','{1}','{2}',{3},{4},{5},{6},'{7}')", regNo, rentDate, destination, payment, cost,profit,commission,paymentStatus);

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            int total = aCommand.ExecuteNonQuery();
            aConnection.Close();
            if (total > 0)
                return true;
            return false;
        }

        public List<RentalInformation> GetAllRentalDetails(string regNo)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_rental_information WHERE reg_no = '{0}'",regNo);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<RentalInformation> rentalInformations = new List<RentalInformation>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    aRentalInformation = new RentalInformation();

                    aRentalInformation.RegNo = aReader[1].ToString();
                    aRentalInformation.RentDate = aReader[2].ToString();
                    aRentalInformation.Destination = aReader[3].ToString();
                    aRentalInformation.Payment = Convert.ToDouble(aReader[4].ToString());
                    aRentalInformation.Cost = Convert.ToDouble(aReader[5].ToString());
                    aRentalInformation.Profit = Convert.ToDouble(aReader[6].ToString());
                    aRentalInformation.Commission = Convert.ToDouble(aReader[7].ToString());
                    aRentalInformation.PaymentStatus = aReader[8].ToString();

                    rentalInformations.Add(aRentalInformation);
                }
            }
            aConnection.Close();
            return rentalInformations;
        }

        public bool SaveBookingDetails(string destination, double distance, string date, string time, int vehicleId)
        {
            aConnection.Open();
            string query = string.Format("INSERT INTO t_booking_details VALUES('{0}',{1},'{2}','{3}',{4})", destination, distance, date, time, vehicleId);

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            int total = aCommand.ExecuteNonQuery();
            aConnection.Close();
            if (total > 0)
                return true;
            return false;
        }

        public bool IsDateAlreadyBooked(string date)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_booking_details WHERE date='{0}'", date);

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            bool msg = aReader.HasRows;
            aConnection.Close();
            return msg;
        }

        public bool IsVehicleAlreadyBooked(int vehicleId)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_booking_details WHERE vehicle_id='{0}'", vehicleId);

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            bool msg = aReader.HasRows;
            aConnection.Close();
            return msg;
        }

        public RentalInformation GetRentalInformation(string regNo, string rentDate)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_rental_information WHERE reg_no = '{0}'AND rent_date = '{1}'", regNo,rentDate);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            aRentalInformation = new RentalInformation();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    aRentalInformation.RegNo = aReader[1].ToString();
                    aRentalInformation.RentDate = aReader[2].ToString();
                    aRentalInformation.Destination = aReader[3].ToString();
                    aRentalInformation.Payment = Convert.ToDouble(aReader[4].ToString());
                    aRentalInformation.Cost = Convert.ToDouble(aReader[5].ToString());
                    aRentalInformation.Profit = Convert.ToDouble(aReader[6].ToString());
                    aRentalInformation.Commission = Convert.ToDouble(aReader[7].ToString());
                    aRentalInformation.PaymentStatus = aReader[8].ToString();
                }
            }
            aConnection.Close();
            return aRentalInformation;

        }

        public static bool UpdateRentalInformation(string regNo, string rentDate, string destination, double payment, double cost, double profit, double commission, string paymentStatus)
        {
            aConnection.Open();
            string query = string.Format("UPDATE t_rental_information SET destination = '{0}',total_cost = {1},cost = {2},profit = {3},commission = {4},payment_status = '{5}' WHERE reg_no = '{6}' AND rent_date = '{7}'", destination, payment, cost, profit, commission, paymentStatus, regNo, rentDate);

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            int total = aCommand.ExecuteNonQuery();
            aConnection.Close();
            if (total > 0)
                return true;
            return false;
        }

        public BookingDetails GetBookingInformation(int regId, string date)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_booking_details WHERE vehicle_id = {0} AND date = '{1}'", regId, date);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            aBookingDetails = new BookingDetails();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    aBookingDetails.Destination = aReader[1].ToString();
                    aBookingDetails.Distance = Convert.ToDouble(aReader[2].ToString());
                    aBookingDetails.Date = aReader[3].ToString();
                    aBookingDetails.Time = aReader[4].ToString();
                    aBookingDetails.VehicleId = Convert.ToInt32(aReader[5].ToString());
                    
                }
            }
            aConnection.Close();
            return aBookingDetails;
        }

        public bool UpdateBookingDetails(int regId, string date, string destination, double distance, string time, string updateDate)
        {
            aConnection.Open();
            string query = string.Format("UPDATE t_booking_details SET destination = '{0}',distance = {1},date = '{2}',time = '{3}' WHERE vehicle_id = {4} AND date = '{5}'", destination, distance, updateDate, time, regId, date);

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            int total = aCommand.ExecuteNonQuery();
            aConnection.Close();
            if (total > 0)
                return true;
            return false;
        }

        public bool SaveCustomerInformation(string name, string address, string phoneNo)
        {
            aConnection.Open();
            string query = string.Format("INSERT INTO t_customer_information VALUES('{0}','{1}','{2}')", name,address,phoneNo);

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            int total = aCommand.ExecuteNonQuery();
            aConnection.Close();
            if (total > 0)
                return true;
            return false;
        }

        public BookingDetails GetBookingId(int vehicleId)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_booking_details WHERE vehicle_id = {0}", vehicleId);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            BookingDetails bookingDetails = new BookingDetails();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    bookingDetails.Id = (int) aReader[0];
                    bookingDetails.Destination = aReader[1].ToString();
                    bookingDetails.Distance = Convert.ToDouble(aReader[2].ToString());
                    bookingDetails.Date =aReader[3].ToString();
                    bookingDetails.Time = aReader[4].ToString();
                    bookingDetails.VehicleId = (int)aReader[5];


                }
            }
            aConnection.Close();
            return bookingDetails;
        }

        public bool SaveBillingInformation(double totalCost, double advance, double due, string billingDate, int bookId, int customerId)
        {
            aConnection.Open();
            string query = string.Format("INSERT INTO t_billing_information VALUES({0},{1},{2},'{3}',{4},{5})", totalCost, advance, due,billingDate,bookId,customerId);

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            int total = aCommand.ExecuteNonQuery();
            aConnection.Close();
            if (total > 0)
                return true;
            return false;
        }

        public bool IsVehicleAlreadySaved(string regNo)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_rental_information WHERE reg_no='{0}'", regNo);

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            bool msg = aReader.HasRows;
            aConnection.Close();
            return msg;
        }

        public bool IsVehicleAlreadySaveInThisDate(string rentDate)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_rental_information WHERE rent_date='{0}'", rentDate);

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            bool msg = aReader.HasRows;
            aConnection.Close();
            return msg;
        }
    }
}
