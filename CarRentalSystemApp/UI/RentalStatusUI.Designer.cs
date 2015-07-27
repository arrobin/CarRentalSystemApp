namespace CarRentalSystemApp.UI
{
    partial class RentalStatusUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalStatusUI));
            this.saveGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vehicleRegNocomboBox = new System.Windows.Forms.ComboBox();
            this.StatusSaveComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.costSaveTextBox = new System.Windows.Forms.TextBox();
            this.rentCostSaveTextBox = new System.Windows.Forms.TextBox();
            this.destinationSaveTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updateGroupBox = new System.Windows.Forms.GroupBox();
            this.showButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.vehicleRegNoUpdatecomboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.StatusUpdateComboBox = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.commitionUpdateTextBox = new System.Windows.Forms.TextBox();
            this.profitUpdateTextBox = new System.Windows.Forms.TextBox();
            this.costUpdateTextBox = new System.Windows.Forms.TextBox();
            this.rentalCostUpdateTextBox = new System.Windows.Forms.TextBox();
            this.destinationUpdateTextBox = new System.Windows.Forms.TextBox();
            this.saveDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveGroupBox.SuspendLayout();
            this.updateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveGroupBox
            // 
            this.saveGroupBox.Controls.Add(this.saveDateTimePicker);
            this.saveGroupBox.Controls.Add(this.label1);
            this.saveGroupBox.Controls.Add(this.vehicleRegNocomboBox);
            this.saveGroupBox.Controls.Add(this.StatusSaveComboBox);
            this.saveGroupBox.Controls.Add(this.saveButton);
            this.saveGroupBox.Controls.Add(this.costSaveTextBox);
            this.saveGroupBox.Controls.Add(this.rentCostSaveTextBox);
            this.saveGroupBox.Controls.Add(this.destinationSaveTextBox);
            this.saveGroupBox.Controls.Add(this.label9);
            this.saveGroupBox.Controls.Add(this.label6);
            this.saveGroupBox.Controls.Add(this.label5);
            this.saveGroupBox.Controls.Add(this.label4);
            this.saveGroupBox.Controls.Add(this.label3);
            this.saveGroupBox.Controls.Add(this.label2);
            this.saveGroupBox.Location = new System.Drawing.Point(15, 34);
            this.saveGroupBox.Name = "saveGroupBox";
            this.saveGroupBox.Size = new System.Drawing.Size(331, 365);
            this.saveGroupBox.TabIndex = 0;
            this.saveGroupBox.TabStop = false;
            this.saveGroupBox.Text = "Save";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(19, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "(dd/mm/yyyy)";
            // 
            // vehicleRegNocomboBox
            // 
            this.vehicleRegNocomboBox.FormattingEnabled = true;
            this.vehicleRegNocomboBox.Location = new System.Drawing.Point(114, 39);
            this.vehicleRegNocomboBox.Name = "vehicleRegNocomboBox";
            this.vehicleRegNocomboBox.Size = new System.Drawing.Size(121, 21);
            this.vehicleRegNocomboBox.TabIndex = 0;
            // 
            // StatusSaveComboBox
            // 
            this.StatusSaveComboBox.FormattingEnabled = true;
            this.StatusSaveComboBox.Items.AddRange(new object[] {
            "Paid",
            "Due"});
            this.StatusSaveComboBox.Location = new System.Drawing.Point(114, 268);
            this.StatusSaveComboBox.Name = "StatusSaveComboBox";
            this.StatusSaveComboBox.Size = new System.Drawing.Size(187, 21);
            this.StatusSaveComboBox.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Image = global::CarRentalSystemApp.Properties.Resources.images1;
            this.saveButton.Location = new System.Drawing.Point(148, 298);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(108, 55);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // costSaveTextBox
            // 
            this.costSaveTextBox.Location = new System.Drawing.Point(114, 219);
            this.costSaveTextBox.Name = "costSaveTextBox";
            this.costSaveTextBox.Size = new System.Drawing.Size(187, 20);
            this.costSaveTextBox.TabIndex = 4;
            // 
            // rentCostSaveTextBox
            // 
            this.rentCostSaveTextBox.Location = new System.Drawing.Point(114, 171);
            this.rentCostSaveTextBox.Name = "rentCostSaveTextBox";
            this.rentCostSaveTextBox.Size = new System.Drawing.Size(187, 20);
            this.rentCostSaveTextBox.TabIndex = 3;
            // 
            // destinationSaveTextBox
            // 
            this.destinationSaveTextBox.Location = new System.Drawing.Point(114, 124);
            this.destinationSaveTextBox.Name = "destinationSaveTextBox";
            this.destinationSaveTextBox.Size = new System.Drawing.Size(187, 20);
            this.destinationSaveTextBox.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(19, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(19, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(19, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rental Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(19, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(19, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rent Date ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(19, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reg NO";
            // 
            // updateGroupBox
            // 
            this.updateGroupBox.Controls.Add(this.updateDateTimePicker);
            this.updateGroupBox.Controls.Add(this.showButton);
            this.updateGroupBox.Controls.Add(this.label7);
            this.updateGroupBox.Controls.Add(this.vehicleRegNoUpdatecomboBox);
            this.updateGroupBox.Controls.Add(this.label10);
            this.updateGroupBox.Controls.Add(this.label11);
            this.updateGroupBox.Controls.Add(this.label12);
            this.updateGroupBox.Controls.Add(this.label13);
            this.updateGroupBox.Controls.Add(this.label14);
            this.updateGroupBox.Controls.Add(this.label15);
            this.updateGroupBox.Controls.Add(this.label16);
            this.updateGroupBox.Controls.Add(this.label17);
            this.updateGroupBox.Controls.Add(this.StatusUpdateComboBox);
            this.updateGroupBox.Controls.Add(this.updateButton);
            this.updateGroupBox.Controls.Add(this.commitionUpdateTextBox);
            this.updateGroupBox.Controls.Add(this.profitUpdateTextBox);
            this.updateGroupBox.Controls.Add(this.costUpdateTextBox);
            this.updateGroupBox.Controls.Add(this.rentalCostUpdateTextBox);
            this.updateGroupBox.Controls.Add(this.destinationUpdateTextBox);
            this.updateGroupBox.Location = new System.Drawing.Point(622, 34);
            this.updateGroupBox.Name = "updateGroupBox";
            this.updateGroupBox.Size = new System.Drawing.Size(339, 365);
            this.updateGroupBox.TabIndex = 0;
            this.updateGroupBox.TabStop = false;
            this.updateGroupBox.Text = "Show/Update";
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.showButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.showButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Image = global::CarRentalSystemApp.Properties.Resources._3940585a2d442b4a263055de85b1318f1;
            this.showButton.Location = new System.Drawing.Point(182, 78);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(129, 36);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(31, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "(dd/mm/yyyy)";
            // 
            // vehicleRegNoUpdatecomboBox
            // 
            this.vehicleRegNoUpdatecomboBox.FormattingEnabled = true;
            this.vehicleRegNoUpdatecomboBox.Location = new System.Drawing.Point(124, 28);
            this.vehicleRegNoUpdatecomboBox.Name = "vehicleRegNoUpdatecomboBox";
            this.vehicleRegNoUpdatecomboBox.Size = new System.Drawing.Size(121, 21);
            this.vehicleRegNoUpdatecomboBox.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(31, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(31, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Commition";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(31, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Profit";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(31, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 15);
            this.label13.TabIndex = 25;
            this.label13.Text = "Cost";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(31, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 15);
            this.label14.TabIndex = 26;
            this.label14.Text = "Rental Cost";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(31, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 15);
            this.label15.TabIndex = 27;
            this.label15.Text = "Destination";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(31, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 15);
            this.label16.TabIndex = 28;
            this.label16.Text = "Rent Date";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(31, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 15);
            this.label17.TabIndex = 29;
            this.label17.Text = "Reg NO";
            // 
            // StatusUpdateComboBox
            // 
            this.StatusUpdateComboBox.FormattingEnabled = true;
            this.StatusUpdateComboBox.Items.AddRange(new object[] {
            "Paid",
            "Due"});
            this.StatusUpdateComboBox.Location = new System.Drawing.Point(124, 292);
            this.StatusUpdateComboBox.Name = "StatusUpdateComboBox";
            this.StatusUpdateComboBox.Size = new System.Drawing.Size(187, 21);
            this.StatusUpdateComboBox.TabIndex = 8;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Image = global::CarRentalSystemApp.Properties.Resources.Refresh;
            this.updateButton.Location = new System.Drawing.Point(156, 313);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(120, 51);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Update";
            this.updateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // commitionUpdateTextBox
            // 
            this.commitionUpdateTextBox.Location = new System.Drawing.Point(124, 263);
            this.commitionUpdateTextBox.Name = "commitionUpdateTextBox";
            this.commitionUpdateTextBox.ReadOnly = true;
            this.commitionUpdateTextBox.Size = new System.Drawing.Size(187, 20);
            this.commitionUpdateTextBox.TabIndex = 7;
            // 
            // profitUpdateTextBox
            // 
            this.profitUpdateTextBox.Location = new System.Drawing.Point(124, 230);
            this.profitUpdateTextBox.Name = "profitUpdateTextBox";
            this.profitUpdateTextBox.ReadOnly = true;
            this.profitUpdateTextBox.Size = new System.Drawing.Size(187, 20);
            this.profitUpdateTextBox.TabIndex = 6;
            // 
            // costUpdateTextBox
            // 
            this.costUpdateTextBox.Location = new System.Drawing.Point(124, 195);
            this.costUpdateTextBox.Name = "costUpdateTextBox";
            this.costUpdateTextBox.Size = new System.Drawing.Size(187, 20);
            this.costUpdateTextBox.TabIndex = 5;
            // 
            // rentalCostUpdateTextBox
            // 
            this.rentalCostUpdateTextBox.Location = new System.Drawing.Point(124, 155);
            this.rentalCostUpdateTextBox.Name = "rentalCostUpdateTextBox";
            this.rentalCostUpdateTextBox.Size = new System.Drawing.Size(187, 20);
            this.rentalCostUpdateTextBox.TabIndex = 4;
            // 
            // destinationUpdateTextBox
            // 
            this.destinationUpdateTextBox.Location = new System.Drawing.Point(124, 120);
            this.destinationUpdateTextBox.Name = "destinationUpdateTextBox";
            this.destinationUpdateTextBox.Size = new System.Drawing.Size(187, 20);
            this.destinationUpdateTextBox.TabIndex = 3;
            // 
            // saveDateTimePicker
            // 
            this.saveDateTimePicker.Location = new System.Drawing.Point(115, 81);
            this.saveDateTimePicker.Name = "saveDateTimePicker";
            this.saveDateTimePicker.Size = new System.Drawing.Size(186, 20);
            this.saveDateTimePicker.TabIndex = 7;
            // 
            // updateDateTimePicker
            // 
            this.updateDateTimePicker.Location = new System.Drawing.Point(125, 54);
            this.updateDateTimePicker.Name = "updateDateTimePicker";
            this.updateDateTimePicker.Size = new System.Drawing.Size(186, 20);
            this.updateDateTimePicker.TabIndex = 33;
            // 
            // RentalStatusUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::CarRentalSystemApp.Properties.Resources.Master_Rent_A_Car_Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1013, 425);
            this.Controls.Add(this.updateGroupBox);
            this.Controls.Add(this.saveGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RentalStatusUI";
            this.Text = "RentalStatusUI";
            this.saveGroupBox.ResumeLayout(false);
            this.saveGroupBox.PerformLayout();
            this.updateGroupBox.ResumeLayout(false);
            this.updateGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox saveGroupBox;
        private System.Windows.Forms.ComboBox StatusSaveComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox costSaveTextBox;
        private System.Windows.Forms.TextBox rentCostSaveTextBox;
        private System.Windows.Forms.TextBox destinationSaveTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox updateGroupBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox StatusUpdateComboBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox commitionUpdateTextBox;
        private System.Windows.Forms.TextBox profitUpdateTextBox;
        private System.Windows.Forms.TextBox costUpdateTextBox;
        private System.Windows.Forms.TextBox rentalCostUpdateTextBox;
        private System.Windows.Forms.TextBox destinationUpdateTextBox;
        private System.Windows.Forms.ComboBox vehicleRegNocomboBox;
        private System.Windows.Forms.ComboBox vehicleRegNoUpdatecomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DateTimePicker saveDateTimePicker;
        private System.Windows.Forms.DateTimePicker updateDateTimePicker;
    }
}