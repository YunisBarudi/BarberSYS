namespace BarberAppointmentSYS
{
    partial class frmCancelAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelAppointment));
            this.cmbBoxBarber = new System.Windows.Forms.ComboBox();
            this.lblBarber = new System.Windows.Forms.Label();
            this.appDatePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbBoxAppointments = new System.Windows.Forms.ComboBox();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpBoxAppointments = new System.Windows.Forms.GroupBox();
            this.btnCancelAppointment = new System.Windows.Forms.Button();
            this.pctrCancel = new System.Windows.Forms.PictureBox();
            this.grpBoxAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxBarber
            // 
            this.cmbBoxBarber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxBarber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxBarber.Items.AddRange(new object[] {
            "001 Joe Bloggs",
            "002 Yunis Barudi",
            "003 Roman Hnat",
            "004 Lionel Messi"});
            this.cmbBoxBarber.Location = new System.Drawing.Point(509, 43);
            this.cmbBoxBarber.Name = "cmbBoxBarber";
            this.cmbBoxBarber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbBoxBarber.Size = new System.Drawing.Size(290, 39);
            this.cmbBoxBarber.TabIndex = 44;
            // 
            // lblBarber
            // 
            this.lblBarber.AutoSize = true;
            this.lblBarber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblBarber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarber.Location = new System.Drawing.Point(363, 46);
            this.lblBarber.Name = "lblBarber";
            this.lblBarber.Size = new System.Drawing.Size(110, 36);
            this.lblBarber.TabIndex = 43;
            this.lblBarber.Text = "Barber";
            // 
            // appDatePicker
            // 
            this.appDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appDatePicker.Location = new System.Drawing.Point(360, 118);
            this.appDatePicker.MinDate = new System.DateTime(2023, 12, 7, 0, 0, 0, 0);
            this.appDatePicker.Name = "appDatePicker";
            this.appDatePicker.Size = new System.Drawing.Size(439, 38);
            this.appDatePicker.TabIndex = 42;
            this.appDatePicker.Value = new System.DateTime(2023, 12, 7, 14, 12, 0, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(509, 193);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 51);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbBoxAppointments
            // 
            this.cmbBoxAppointments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxAppointments.Items.AddRange(new object[] {
            "00001    10:00         Fade haircut",
            "00002    14:30         Clipper haircut",
            "00003    16:00         Beard Fade",
            "00004    18:30         Beard Shape-Up"});
            this.cmbBoxAppointments.Location = new System.Drawing.Point(9, 107);
            this.cmbBoxAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxAppointments.Name = "cmbBoxAppointments";
            this.cmbBoxAppointments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbBoxAppointments.Size = new System.Drawing.Size(426, 39);
            this.cmbBoxAppointments.TabIndex = 47;
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointments.Location = new System.Drawing.Point(118, 35);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(210, 36);
            this.lblAppointments.TabIndex = 48;
            this.lblAppointments.Text = "Appointments";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(50, 462);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 52);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpBoxAppointments
            // 
            this.grpBoxAppointments.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxAppointments.Controls.Add(this.btnCancelAppointment);
            this.grpBoxAppointments.Controls.Add(this.lblAppointments);
            this.grpBoxAppointments.Controls.Add(this.cmbBoxAppointments);
            this.grpBoxAppointments.Location = new System.Drawing.Point(360, 270);
            this.grpBoxAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxAppointments.Name = "grpBoxAppointments";
            this.grpBoxAppointments.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxAppointments.Size = new System.Drawing.Size(439, 248);
            this.grpBoxAppointments.TabIndex = 51;
            this.grpBoxAppointments.TabStop = false;
            this.grpBoxAppointments.Visible = false;
            // 
            // btnCancelAppointment
            // 
            this.btnCancelAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAppointment.Location = new System.Drawing.Point(72, 176);
            this.btnCancelAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelAppointment.Name = "btnCancelAppointment";
            this.btnCancelAppointment.Size = new System.Drawing.Size(286, 59);
            this.btnCancelAppointment.TabIndex = 49;
            this.btnCancelAppointment.Text = "Cancel Appointment";
            this.btnCancelAppointment.UseVisualStyleBackColor = true;
            this.btnCancelAppointment.Click += new System.EventHandler(this.btnCancelAppointment_Click);
            // 
            // pctrCancel
            // 
            this.pctrCancel.Image = ((System.Drawing.Image)(resources.GetObject("pctrCancel.Image")));
            this.pctrCancel.Location = new System.Drawing.Point(848, 133);
            this.pctrCancel.Name = "pctrCancel";
            this.pctrCancel.Size = new System.Drawing.Size(184, 228);
            this.pctrCancel.TabIndex = 52;
            this.pctrCancel.TabStop = false;
            this.pctrCancel.Visible = false;
            // 
            // frmCancelAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pctrCancel);
            this.Controls.Add(this.grpBoxAppointments);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbBoxBarber);
            this.Controls.Add(this.lblBarber);
            this.Controls.Add(this.appDatePicker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCancelAppointment";
            this.Text = "Cancel Appointment";
            this.grpBoxAppointments.ResumeLayout(false);
            this.grpBoxAppointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxBarber;
        private System.Windows.Forms.Label lblBarber;
        private System.Windows.Forms.DateTimePicker appDatePicker;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbBoxAppointments;
        private System.Windows.Forms.Label lblAppointments;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpBoxAppointments;
        private System.Windows.Forms.Button btnCancelAppointment;
        private System.Windows.Forms.PictureBox pctrCancel;
    }
}