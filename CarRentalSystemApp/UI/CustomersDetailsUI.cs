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
    public partial class CustomersDetailsUI : Form
    {
        CustomerDetailsBLL aCustomerDetailsBll = new CustomerDetailsBLL();
        RentalInformationBLL aRentalInformationBll = new RentalInformationBLL();
        public CustomersDetailsUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                string customerPhoneNo = customerPhoneNumberTextBox.Text;
                CustomerInformation customerInformations = aRentalInformationBll.GetCustomerId(customerPhoneNo);
                customerNameTextBox.Text = customerInformations.Name;
                addressTextBox.Text = customerInformations.Address;
                phoneNumberTextBox.Text = customerInformations.PhoneNo;
                Billing billing = aCustomerDetailsBll.GetBillingDetails(customerInformations.Id);
                totalCostTextBox.Text = billing.TotalCost.ToString();
                billingDateTextBox.Text = billing.BillingDate;
                advanceTextBox.Text = billing.Advance.ToString();
                dueTextBox.Text = billing.Due.ToString();
                BookingDetails bookingDetails = aCustomerDetailsBll.GetBookingDetails(billing.BookId);
                destinationTextBox.Text = bookingDetails.Destination;
                dateTextBox.Text = bookingDetails.Date;
                timeTextBox.Text = bookingDetails.Time;
                Vehicle vehicles = aCustomerDetailsBll.GetVehicleDetails(bookingDetails.VehicleId);
                vehicleRegNoTextBox.Text = vehicles.RegNO;
                driverNameTextBox.Text = vehicles.DriverName;
                statusTextBox.Text = vehicles.Status;
            }
            catch (Exception)
            {

                MessageBox.Show("Please Filled\nPhone Number Text Box With \n11 Digits Valid Phone Number");
            }
           

        }

        private void printPreviewbutton_Click(object sender, EventArgs e)
        {
            MasterRentACarprintPreviewDialog.Document = MasterRentACarprintDocument;

            MasterRentACarprintPreviewDialog.ShowDialog();
        }

        private void MasterRentACarprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.Main_Logo;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage,75,25,newImage.Width,newImage.Height);
            e.Graphics.DrawString("Customer Name :" + customerNameTextBox.Text,new Font("Arial", 12,FontStyle.Bold),Brushes.Black,new PointF(50,250) );
            e.Graphics.DrawString("Address :" + addressTextBox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(50, 270));
            e.Graphics.DrawString("Phone Number :" + phoneNumberTextBox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(50, 290));
            e.Graphics.DrawString("Date-Time :" + DateTime.Now, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(50, 310));
            e.Graphics.DrawString(dashLabel.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(40, 340));

            e.Graphics.DrawString("Destination :" + destinationTextBox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(50, 370));
            e.Graphics.DrawString("Date :" + dateTextBox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(50, 420));
            e.Graphics.DrawString("Time :" + timeTextBox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(50, 470));
            e.Graphics.DrawString("Vehicle Registration No :" + vehicleRegNoTextBox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(50, 520));
            e.Graphics.DrawString("Driver Name :" + driverNameTextBox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(50, 570));
            e.Graphics.DrawString("Total Cost :" + totalCostTextBox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(50, 620));
            e.Graphics.DrawString("Advance :" + advanceTextBox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(50, 670));
            e.Graphics.DrawString("Due :" + dueTextBox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(50, 720));
            e.Graphics.DrawString("Billing Date :" + billingDateTextBox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(50, 770));

            e.Graphics.DrawString(dashLabel.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(40, 800));

            e.Graphics.DrawString("____________________", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(80, 900));
            e.Graphics.DrawString("Customer's Signature", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(85, 950));
            e.Graphics.DrawString("____________________", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(500, 900));
            e.Graphics.DrawString("Propaitor's Signature", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(505, 950));


        }

       

        private void printButton_Click(object sender, EventArgs e)
        {
            MasterRentACarprintDocument.Print();
        }

        
    }
}
