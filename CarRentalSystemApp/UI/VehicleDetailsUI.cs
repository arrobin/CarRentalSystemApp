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
    public partial class VehicleDetailsUI : Form
    {
        
        private VehicleBLL aVehicleBll;
        private RentalInformationBLL aRentalInformationBll;


        public VehicleDetailsUI()
        {
            InitializeComponent();
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            aVehicleBll = new VehicleBLL();
            vehicleRegNoComboBox.DisplayMember = "RegNO";
            List<Vehicle> vehicles = aVehicleBll.GetAllVehicle();
            vehicleRegNoComboBox.DataSource = vehicles;

        }

        private void vehicleRegNoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            vehicleDetailsListView.Items.Clear();
            aRentalInformationBll = new RentalInformationBLL();
            aVehicleBll = new VehicleBLL();
            Vehicle selectedVehicleRegNo = (Vehicle)vehicleRegNoComboBox.SelectedItem;
            string regNo = selectedVehicleRegNo.RegNO;
            List<RentalInformation> rentalInformations = aRentalInformationBll.GetAllRentalDetails(regNo);
            foreach (RentalInformation aRentalInformation in rentalInformations)
            {


                ListViewItem item = new ListViewItem(aRentalInformation.RentDate.ToString());
                item.SubItems.Add(aRentalInformation.Destination);
                item.SubItems.Add(aRentalInformation.Payment.ToString());
                item.SubItems.Add(aRentalInformation.Profit.ToString());
                item.SubItems.Add(aRentalInformation.Commission.ToString());
                item.SubItems.Add(aRentalInformation.PaymentStatus);

                vehicleDetailsListView.Items.Add(item);
            }
        }
    }
}
