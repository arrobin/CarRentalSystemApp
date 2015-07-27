using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystemApp.UI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void addVehicleButton_Click(object sender, EventArgs e)
        {
            VehicleAddUi aVehicleAddUi = new VehicleAddUi();
            aVehicleAddUi.ShowDialog();
        }

        private void rentalInformationButton_Click(object sender, EventArgs e)
        {
            RentalInformationUI aRentalInformationUi = new RentalInformationUI();
            aRentalInformationUi.ShowDialog();
        }

        private void rentalStatusButton_Click(object sender, EventArgs e)
        {
            RentalStatusUI aRentalStatusUi = new RentalStatusUI();
            aRentalStatusUi.ShowDialog();
        }

        private void vehicleDetailsButton_Click(object sender, EventArgs e)
        {
            VehicleDetailsUI aVehicleDetailsUi = new VehicleDetailsUI();
            aVehicleDetailsUi.ShowDialog();
        }

        private void customerDetailsButton_Click(object sender, EventArgs e)
        {
            CustomersDetailsUI aCustomersDetailsUi = new CustomersDetailsUI();
            aCustomersDetailsUi.ShowDialog();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Logout From the Account");
            
            Application.Restart();
            
        }
    }
}
