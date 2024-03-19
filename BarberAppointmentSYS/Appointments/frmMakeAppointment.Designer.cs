namespace BarberAppointmentSYS
{
    partial class frmMakeAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMakeAppointment));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblBarber = new System.Windows.Forms.Label();
            this.cmbBoxBarber = new System.Windows.Forms.ComboBox();
            this.lblSelectTime = new System.Windows.Forms.Label();
            this.cmbBoxTime = new System.Windows.Forms.ComboBox();
            this.grpBoxCustomerDetails = new System.Windows.Forms.GroupBox();
            this.btnMakeAppointment = new System.Windows.Forms.Button();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.txtBoxForename = new System.Windows.Forms.TextBox();
            this.lblService = new System.Windows.Forms.Label();
            this.cmbBoxService = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.appDatePicker = new System.Windows.Forms.DateTimePicker();
            this.grpBoxCustomerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(37, 368);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 43);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblBarber
            // 
            this.lblBarber.AutoSize = true;
            this.lblBarber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblBarber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarber.Location = new System.Drawing.Point(47, 69);
            this.lblBarber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarber.Name = "lblBarber";
            this.lblBarber.Size = new System.Drawing.Size(72, 24);
            this.lblBarber.TabIndex = 40;
            this.lblBarber.Text = "Barber";
            // 
            // cmbBoxBarber
            // 
            this.cmbBoxBarber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxBarber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxBarber.Location = new System.Drawing.Point(142, 66);
            this.cmbBoxBarber.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxBarber.Name = "cmbBoxBarber";
            this.cmbBoxBarber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbBoxBarber.Size = new System.Drawing.Size(162, 28);
            this.cmbBoxBarber.TabIndex = 41;
            // 
            // lblSelectTime
            // 
            this.lblSelectTime.AutoSize = true;
            this.lblSelectTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSelectTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTime.Location = new System.Drawing.Point(47, 262);
            this.lblSelectTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectTime.Name = "lblSelectTime";
            this.lblSelectTime.Size = new System.Drawing.Size(121, 24);
            this.lblSelectTime.TabIndex = 42;
            this.lblSelectTime.Text = "Select Time";
            this.lblSelectTime.Visible = false;
            // 
            // cmbBoxTime
            // 
            this.cmbBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxTime.Items.AddRange(new object[] {
            "10:00",
            "16:30",
            "17:30",
            "18:00"});
            this.cmbBoxTime.Location = new System.Drawing.Point(182, 259);
            this.cmbBoxTime.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxTime.Name = "cmbBoxTime";
            this.cmbBoxTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbBoxTime.Size = new System.Drawing.Size(162, 28);
            this.cmbBoxTime.TabIndex = 43;
            this.cmbBoxTime.Visible = false;
            this.cmbBoxTime.SelectedIndexChanged += new System.EventHandler(this.cmbBoxTime_SelectedIndexChanged);
            // 
            // grpBoxCustomerDetails
            // 
            this.grpBoxCustomerDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxCustomerDetails.Controls.Add(this.btnMakeAppointment);
            this.grpBoxCustomerDetails.Controls.Add(this.txtBoxEmail);
            this.grpBoxCustomerDetails.Controls.Add(this.txtBoxPhone);
            this.grpBoxCustomerDetails.Controls.Add(this.txtBoxSurname);
            this.grpBoxCustomerDetails.Controls.Add(this.txtBoxForename);
            this.grpBoxCustomerDetails.Controls.Add(this.lblService);
            this.grpBoxCustomerDetails.Controls.Add(this.cmbBoxService);
            this.grpBoxCustomerDetails.Controls.Add(this.lblEmail);
            this.grpBoxCustomerDetails.Controls.Add(this.lblForename);
            this.grpBoxCustomerDetails.Controls.Add(this.lblSurname);
            this.grpBoxCustomerDetails.Controls.Add(this.lblPhone);
            this.grpBoxCustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxCustomerDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpBoxCustomerDetails.Location = new System.Drawing.Point(383, 10);
            this.grpBoxCustomerDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxCustomerDetails.Name = "grpBoxCustomerDetails";
            this.grpBoxCustomerDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxCustomerDetails.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpBoxCustomerDetails.Size = new System.Drawing.Size(384, 420);
            this.grpBoxCustomerDetails.TabIndex = 44;
            this.grpBoxCustomerDetails.TabStop = false;
            this.grpBoxCustomerDetails.Text = "Enter Customer Details";
            this.grpBoxCustomerDetails.Visible = false;
            // 
            // btnMakeAppointment
            // 
            this.btnMakeAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeAppointment.Location = new System.Drawing.Point(109, 358);
            this.btnMakeAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.btnMakeAppointment.Name = "btnMakeAppointment";
            this.btnMakeAppointment.Size = new System.Drawing.Size(197, 43);
            this.btnMakeAppointment.TabIndex = 51;
            this.btnMakeAppointment.Text = "Make Appointment";
            this.btnMakeAppointment.UseVisualStyleBackColor = true;
            this.btnMakeAppointment.Click += new System.EventHandler(this.btnMakeAppointment_Click);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(163, 307);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxEmail.MaxLength = 25;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(170, 28);
            this.txtBoxEmail.TabIndex = 50;
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPhone.Location = new System.Drawing.Point(163, 240);
            this.txtBoxPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPhone.MaxLength = 10;
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(170, 28);
            this.txtBoxPhone.TabIndex = 49;
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSurname.Location = new System.Drawing.Point(163, 116);
            this.txtBoxSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxSurname.MaxLength = 25;
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(170, 28);
            this.txtBoxSurname.TabIndex = 48;
            // 
            // txtBoxForename
            // 
            this.txtBoxForename.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBoxForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxForename.Location = new System.Drawing.Point(163, 52);
            this.txtBoxForename.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxForename.MaxLength = 25;
            this.txtBoxForename.Name = "txtBoxForename";
            this.txtBoxForename.Size = new System.Drawing.Size(170, 28);
            this.txtBoxForename.TabIndex = 47;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(31, 184);
            this.lblService.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(80, 24);
            this.lblService.TabIndex = 46;
            this.lblService.Text = "Service";
            // 
            // cmbBoxService
            // 
            this.cmbBoxService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxService.Location = new System.Drawing.Point(163, 184);
            this.cmbBoxService.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxService.Name = "cmbBoxService";
            this.cmbBoxService.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbBoxService.Size = new System.Drawing.Size(170, 28);
            this.cmbBoxService.TabIndex = 45;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(31, 307);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 24);
            this.lblEmail.TabIndex = 44;
            this.lblEmail.Text = "E-mail";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(31, 56);
            this.lblForename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(106, 24);
            this.lblForename.TabIndex = 43;
            this.lblForename.Text = "Forename";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(31, 119);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(94, 24);
            this.lblSurname.TabIndex = 42;
            this.lblSurname.Text = "Surname";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(31, 242);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(71, 24);
            this.lblPhone.TabIndex = 41;
            this.lblPhone.Text = "Phone";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(142, 187);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 34);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // appDatePicker
            // 
            this.appDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appDatePicker.Location = new System.Drawing.Point(47, 127);
            this.appDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.appDatePicker.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.appDatePicker.MinDate = new System.DateTime(2024, 3, 12, 0, 0, 0, 0);
            this.appDatePicker.Name = "appDatePicker";
            this.appDatePicker.Size = new System.Drawing.Size(256, 26);
            this.appDatePicker.TabIndex = 0;
            this.appDatePicker.Value = new System.DateTime(2024, 3, 12, 0, 0, 0, 0);
            // 
            // frmMakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpBoxCustomerDetails);
            this.Controls.Add(this.cmbBoxTime);
            this.Controls.Add(this.lblSelectTime);
            this.Controls.Add(this.cmbBoxBarber);
            this.Controls.Add(this.lblBarber);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.appDatePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMakeAppointment";
            this.Text = "Make Appointment";
            this.Load += new System.EventHandler(this.frmMakeAppointment_Load);
            this.grpBoxCustomerDetails.ResumeLayout(false);
            this.grpBoxCustomerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblBarber;
        private System.Windows.Forms.ComboBox cmbBoxBarber;
        private System.Windows.Forms.Label lblSelectTime;
        private System.Windows.Forms.ComboBox cmbBoxTime;
        private System.Windows.Forms.GroupBox grpBoxCustomerDetails;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ComboBox cmbBoxService;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.TextBox txtBoxForename;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMakeAppointment;
        private System.Windows.Forms.DateTimePicker appDatePicker;
    }
}