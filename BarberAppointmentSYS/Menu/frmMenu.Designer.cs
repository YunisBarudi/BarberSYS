namespace BarberAppointmentSYS
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblMain1 = new System.Windows.Forms.Label();
            this.lblMain2 = new System.Windows.Forms.Label();
            this.imgMainPicture = new System.Windows.Forms.PictureBox();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuServices = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetServiceType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDiscontinueService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBarber = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddBarber = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeBarber = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveBarber = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListBarbers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMakeAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearlyRevenueAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearlyBarberStatisctics = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgMainPicture)).BeginInit();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMain1
            // 
            this.lblMain1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lblMain1.AutoSize = true;
            this.lblMain1.BackColor = System.Drawing.Color.White;
            this.lblMain1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMain1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain1.Location = new System.Drawing.Point(173, 27);
            this.lblMain1.Name = "lblMain1";
            this.lblMain1.Size = new System.Drawing.Size(177, 31);
            this.lblMain1.TabIndex = 1;
            this.lblMain1.Text = "Appointment";
            // 
            // lblMain2
            // 
            this.lblMain2.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lblMain2.AutoSize = true;
            this.lblMain2.BackColor = System.Drawing.Color.White;
            this.lblMain2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMain2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain2.Location = new System.Drawing.Point(501, 27);
            this.lblMain2.Name = "lblMain2";
            this.lblMain2.Size = new System.Drawing.Size(111, 31);
            this.lblMain2.TabIndex = 2;
            this.lblMain2.Text = "System";
            // 
            // imgMainPicture
            // 
            this.imgMainPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgMainPicture.BackColor = System.Drawing.Color.White;
            this.imgMainPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgMainPicture.BackgroundImage")));
            this.imgMainPicture.Image = ((System.Drawing.Image)(resources.GetObject("imgMainPicture.Image")));
            this.imgMainPicture.ImageLocation = "";
            this.imgMainPicture.Location = new System.Drawing.Point(-1, 27);
            this.imgMainPicture.Name = "imgMainPicture";
            this.imgMainPicture.Size = new System.Drawing.Size(804, 469);
            this.imgMainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgMainPicture.TabIndex = 0;
            this.imgMainPicture.TabStop = false;
            // 
            // mnuStrip
            // 
            this.mnuStrip.BackColor = System.Drawing.Color.Transparent;
            this.mnuStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mnuStrip.BackgroundImage")));
            this.mnuStrip.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuServices,
            this.mnuBarber,
            this.mnuAppointment,
            this.mnuAdmin});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuStrip.Size = new System.Drawing.Size(800, 28);
            this.mnuStrip.TabIndex = 3;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // mnuServices
            // 
            this.mnuServices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetServiceType,
            this.mnuAddService,
            this.mnuChangeService,
            this.mnuDiscontinueService});
            this.mnuServices.Name = "mnuServices";
            this.mnuServices.Size = new System.Drawing.Size(82, 24);
            this.mnuServices.Text = "Services";
            this.mnuServices.Click += new System.EventHandler(this.mnuServices_Click);
            // 
            // mnuSetServiceType
            // 
            this.mnuSetServiceType.Name = "mnuSetServiceType";
            this.mnuSetServiceType.Size = new System.Drawing.Size(226, 24);
            this.mnuSetServiceType.Text = "Set Service Type";
            this.mnuSetServiceType.Click += new System.EventHandler(this.mnuSetServiceType_Click);
            // 
            // mnuAddService
            // 
            this.mnuAddService.Name = "mnuAddService";
            this.mnuAddService.Size = new System.Drawing.Size(226, 24);
            this.mnuAddService.Text = "Add Service";
            this.mnuAddService.Click += new System.EventHandler(this.mnuAddService_Click);
            // 
            // mnuChangeService
            // 
            this.mnuChangeService.Name = "mnuChangeService";
            this.mnuChangeService.Size = new System.Drawing.Size(226, 24);
            this.mnuChangeService.Text = "Change Service";
            this.mnuChangeService.Click += new System.EventHandler(this.mnuChangeService_Click);
            // 
            // mnuDiscontinueService
            // 
            this.mnuDiscontinueService.Name = "mnuDiscontinueService";
            this.mnuDiscontinueService.Size = new System.Drawing.Size(226, 24);
            this.mnuDiscontinueService.Text = "Discontinue Service";
            this.mnuDiscontinueService.Click += new System.EventHandler(this.mnuDiscontinueService_Click);
            // 
            // mnuBarber
            // 
            this.mnuBarber.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddBarber,
            this.mnuChangeBarber,
            this.mnuRemoveBarber,
            this.mnuListBarbers});
            this.mnuBarber.Name = "mnuBarber";
            this.mnuBarber.Size = new System.Drawing.Size(78, 24);
            this.mnuBarber.Text = "Barbers";
            // 
            // mnuAddBarber
            // 
            this.mnuAddBarber.Name = "mnuAddBarber";
            this.mnuAddBarber.Size = new System.Drawing.Size(193, 24);
            this.mnuAddBarber.Text = "Add Barber";
            this.mnuAddBarber.Click += new System.EventHandler(this.mnuAddBarber_Click);
            // 
            // mnuChangeBarber
            // 
            this.mnuChangeBarber.Name = "mnuChangeBarber";
            this.mnuChangeBarber.Size = new System.Drawing.Size(193, 24);
            this.mnuChangeBarber.Text = "Change Barber";
            this.mnuChangeBarber.Click += new System.EventHandler(this.mnuChangeBarber_Click);
            // 
            // mnuRemoveBarber
            // 
            this.mnuRemoveBarber.Name = "mnuRemoveBarber";
            this.mnuRemoveBarber.Size = new System.Drawing.Size(193, 24);
            this.mnuRemoveBarber.Text = "Remove Barber";
            this.mnuRemoveBarber.Click += new System.EventHandler(this.mnuDiscontinueBarber_Click);
            // 
            // mnuListBarbers
            // 
            this.mnuListBarbers.Name = "mnuListBarbers";
            this.mnuListBarbers.Size = new System.Drawing.Size(193, 24);
            this.mnuListBarbers.Text = "List Barbers";
            this.mnuListBarbers.Click += new System.EventHandler(this.mnuListBarbers_Click);
            // 
            // mnuAppointment
            // 
            this.mnuAppointment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMakeAppointment,
            this.mnuCancelAppointment});
            this.mnuAppointment.Name = "mnuAppointment";
            this.mnuAppointment.Size = new System.Drawing.Size(120, 24);
            this.mnuAppointment.Text = "Appointment";
            // 
            // mnuMakeAppointment
            // 
            this.mnuMakeAppointment.Name = "mnuMakeAppointment";
            this.mnuMakeAppointment.Size = new System.Drawing.Size(232, 24);
            this.mnuMakeAppointment.Text = "Make Appointment";
            this.mnuMakeAppointment.Click += new System.EventHandler(this.mnuMakeAppointment_Click);
            // 
            // mnuCancelAppointment
            // 
            this.mnuCancelAppointment.Name = "mnuCancelAppointment";
            this.mnuCancelAppointment.Size = new System.Drawing.Size(232, 24);
            this.mnuCancelAppointment.Text = "Cancel Appointment";
            this.mnuCancelAppointment.Click += new System.EventHandler(this.mnuCancelAppointment_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYearlyRevenueAnalysis,
            this.mnuYearlyBarberStatisctics});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(70, 24);
            this.mnuAdmin.Text = "Admin";
            // 
            // mnuYearlyRevenueAnalysis
            // 
            this.mnuYearlyRevenueAnalysis.Name = "mnuYearlyRevenueAnalysis";
            this.mnuYearlyRevenueAnalysis.Size = new System.Drawing.Size(260, 24);
            this.mnuYearlyRevenueAnalysis.Text = "Yearly Revenue Analysis";
            this.mnuYearlyRevenueAnalysis.Click += new System.EventHandler(this.mnuYearlyRevenueAnalyse_Click);
            // 
            // mnuYearlyBarberStatisctics
            // 
            this.mnuYearlyBarberStatisctics.Name = "mnuYearlyBarberStatisctics";
            this.mnuYearlyBarberStatisctics.Size = new System.Drawing.Size(260, 24);
            this.mnuYearlyBarberStatisctics.Text = "Yearly Barber Statisctics";
            this.mnuYearlyBarberStatisctics.Click += new System.EventHandler(this.mnuYearlyBarberStatisctics_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(317, 292);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(179, 61);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect / Disconect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(370, 378);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(69, 24);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Closed";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblMain2);
            this.Controls.Add(this.lblMain1);
            this.Controls.Add(this.imgMainPicture);
            this.Controls.Add(this.mnuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgMainPicture)).EndInit();
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox imgMainPicture;
        private System.Windows.Forms.Label lblMain1;
        private System.Windows.Forms.Label lblMain2;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuServices;
        private System.Windows.Forms.ToolStripMenuItem mnuBarber;
        private System.Windows.Forms.ToolStripMenuItem mnuSetServiceType;
        private System.Windows.Forms.ToolStripMenuItem mnuAddService;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeService;
        private System.Windows.Forms.ToolStripMenuItem mnuDiscontinueService;
        private System.Windows.Forms.ToolStripMenuItem mnuAddBarber;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeBarber;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveBarber;
        private System.Windows.Forms.ToolStripMenuItem mnuListBarbers;
        private System.Windows.Forms.ToolStripMenuItem mnuAppointment;
        private System.Windows.Forms.ToolStripMenuItem mnuMakeAppointment;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelAppointment;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuYearlyRevenueAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuYearlyBarberStatisctics;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblStatus;
    }
}

