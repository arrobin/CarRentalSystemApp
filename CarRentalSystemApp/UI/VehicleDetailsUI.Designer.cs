namespace CarRentalSystemApp.UI
{
    partial class VehicleDetailsUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleDetailsUI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vehicleDetailsListView = new System.Windows.Forms.ListView();
            this.RentDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Destination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RentalCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Profit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Commition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaymentStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vehicleRegNoComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.showButton);
            this.groupBox1.Controls.Add(this.vehicleDetailsListView);
            this.groupBox1.Controls.Add(this.vehicleRegNoComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 380);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Details";
            // 
            // vehicleDetailsListView
            // 
            this.vehicleDetailsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RentDate,
            this.Destination,
            this.RentalCost,
            this.Profit,
            this.Commition,
            this.PaymentStatus});
            this.vehicleDetailsListView.Location = new System.Drawing.Point(66, 94);
            this.vehicleDetailsListView.Name = "vehicleDetailsListView";
            this.vehicleDetailsListView.Size = new System.Drawing.Size(666, 246);
            this.vehicleDetailsListView.TabIndex = 3;
            this.vehicleDetailsListView.UseCompatibleStateImageBehavior = false;
            this.vehicleDetailsListView.UseWaitCursor = true;
            this.vehicleDetailsListView.View = System.Windows.Forms.View.Details;
            // 
            // RentDate
            // 
            this.RentDate.Text = "Rent Date";
            this.RentDate.Width = 91;
            // 
            // Destination
            // 
            this.Destination.Text = "Destination";
            this.Destination.Width = 102;
            // 
            // RentalCost
            // 
            this.RentalCost.Text = "Rental Cost";
            this.RentalCost.Width = 112;
            // 
            // Profit
            // 
            this.Profit.Text = "Profit";
            this.Profit.Width = 120;
            // 
            // Commition
            // 
            this.Commition.Text = "Commition";
            this.Commition.Width = 150;
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.Text = "Payment Status";
            this.PaymentStatus.Width = 258;
            // 
            // vehicleRegNoComboBox
            // 
            this.vehicleRegNoComboBox.FormattingEnabled = true;
            this.vehicleRegNoComboBox.Location = new System.Drawing.Point(264, 46);
            this.vehicleRegNoComboBox.Name = "vehicleRegNoComboBox";
            this.vehicleRegNoComboBox.Size = new System.Drawing.Size(223, 21);
            this.vehicleRegNoComboBox.TabIndex = 1;
            this.vehicleRegNoComboBox.SelectedIndexChanged += new System.EventHandler(this.vehicleRegNoComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(63, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Registration Number";
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Image = global::CarRentalSystemApp.Properties.Resources.icon_view_details;
            this.showButton.Location = new System.Drawing.Point(533, 30);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(116, 49);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Show";
            this.showButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // VehicleDetailsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(778, 404);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VehicleDetailsUI";
            this.Text = "VehicleDetailsUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView vehicleDetailsListView;
        private System.Windows.Forms.ColumnHeader RentDate;
        private System.Windows.Forms.ColumnHeader Destination;
        private System.Windows.Forms.ColumnHeader RentalCost;
        private System.Windows.Forms.ColumnHeader Profit;
        private System.Windows.Forms.ColumnHeader Commition;
        private System.Windows.Forms.ColumnHeader PaymentStatus;
        private System.Windows.Forms.ComboBox vehicleRegNoComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showButton;
    }
}