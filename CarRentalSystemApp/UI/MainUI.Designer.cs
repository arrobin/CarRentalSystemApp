namespace CarRentalSystemApp.UI
{
    partial class MainUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.addVehicleButton = new System.Windows.Forms.Button();
            this.rentalInformationButton = new System.Windows.Forms.Button();
            this.rentalStatusButton = new System.Windows.Forms.Button();
            this.vehicleDetailsButton = new System.Windows.Forms.Button();
            this.customerDetailsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // addVehicleButton
            // 
            this.addVehicleButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addVehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehicleButton.Location = new System.Drawing.Point(12, 155);
            this.addVehicleButton.Name = "addVehicleButton";
            this.addVehicleButton.Size = new System.Drawing.Size(137, 49);
            this.addVehicleButton.TabIndex = 0;
            this.addVehicleButton.Text = "Add Vehicle";
            this.addVehicleButton.UseVisualStyleBackColor = false;
            this.addVehicleButton.Click += new System.EventHandler(this.addVehicleButton_Click);
            // 
            // rentalInformationButton
            // 
            this.rentalInformationButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rentalInformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalInformationButton.Location = new System.Drawing.Point(155, 155);
            this.rentalInformationButton.Name = "rentalInformationButton";
            this.rentalInformationButton.Size = new System.Drawing.Size(137, 49);
            this.rentalInformationButton.TabIndex = 1;
            this.rentalInformationButton.Text = "Rental Information";
            this.rentalInformationButton.UseVisualStyleBackColor = false;
            this.rentalInformationButton.Click += new System.EventHandler(this.rentalInformationButton_Click);
            // 
            // rentalStatusButton
            // 
            this.rentalStatusButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rentalStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalStatusButton.Location = new System.Drawing.Point(441, 155);
            this.rentalStatusButton.Name = "rentalStatusButton";
            this.rentalStatusButton.Size = new System.Drawing.Size(128, 49);
            this.rentalStatusButton.TabIndex = 2;
            this.rentalStatusButton.Text = "Rental Status";
            this.rentalStatusButton.UseVisualStyleBackColor = false;
            this.rentalStatusButton.Click += new System.EventHandler(this.rentalStatusButton_Click);
            // 
            // vehicleDetailsButton
            // 
            this.vehicleDetailsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.vehicleDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleDetailsButton.Location = new System.Drawing.Point(575, 155);
            this.vehicleDetailsButton.Name = "vehicleDetailsButton";
            this.vehicleDetailsButton.Size = new System.Drawing.Size(137, 49);
            this.vehicleDetailsButton.TabIndex = 2;
            this.vehicleDetailsButton.Text = "Vehicle Details";
            this.vehicleDetailsButton.UseVisualStyleBackColor = false;
            this.vehicleDetailsButton.Click += new System.EventHandler(this.vehicleDetailsButton_Click);
            // 
            // customerDetailsButton
            // 
            this.customerDetailsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.customerDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDetailsButton.Location = new System.Drawing.Point(298, 155);
            this.customerDetailsButton.Name = "customerDetailsButton";
            this.customerDetailsButton.Size = new System.Drawing.Size(137, 49);
            this.customerDetailsButton.TabIndex = 2;
            this.customerDetailsButton.Text = "Customer Details";
            this.customerDetailsButton.UseVisualStyleBackColor = false;
            this.customerDetailsButton.Click += new System.EventHandler(this.customerDetailsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Master Rent-A-Car";
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Image = global::CarRentalSystemApp.Properties.Resources.logout;
            this.logOutButton.Location = new System.Drawing.Point(575, 12);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(124, 45);
            this.logOutButton.TabIndex = 5;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::CarRentalSystemApp.Properties.Resources.Main_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(723, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(721, 249);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerDetailsButton);
            this.Controls.Add(this.vehicleDetailsButton);
            this.Controls.Add(this.rentalStatusButton);
            this.Controls.Add(this.rentalInformationButton);
            this.Controls.Add(this.addVehicleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.Text = "MainUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addVehicleButton;
        private System.Windows.Forms.Button rentalInformationButton;
        private System.Windows.Forms.Button rentalStatusButton;
        private System.Windows.Forms.Button vehicleDetailsButton;
        private System.Windows.Forms.Button customerDetailsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}