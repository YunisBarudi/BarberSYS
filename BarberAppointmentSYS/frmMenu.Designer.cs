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
            this.imgMainPicture = new System.Windows.Forms.PictureBox();
            this.lblMain1 = new System.Windows.Forms.Label();
            this.lblMain2 = new System.Windows.Forms.Label();
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
            this.mnuYearlyRevenueAnalyse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearlyBarberStatisctics = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imgMainPicture)).BeginInit();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgMainPicture
            // 
            this.imgMainPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgMainPicture.BackColor = System.Drawing.Color.White;
            this.imgMainPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgMainPicture.BackgroundImage")));
            this.imgMainPicture.Image = ((System.Drawing.Image)(resources.GetObject("imgMainPicture.Image")));
            this.imgMainPicture.ImageLocation = "";
            this.imgMainPicture.Location = new System.Drawing.Point(-1, 33);
            this.imgMainPicture.Margin = new System.Windows.Forms.Padding(4);
            this.imgMainPicture.Name = "imgMainPicture";
            this.imgMainPicture.Size = new System.Drawing.Size(1072, 577);
            this.imgMainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgMainPicture.TabIndex = 0;
            this.imgMainPicture.TabStop = false;
            this.imgMainPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblMain1
            // 
            this.lblMain1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lblMain1.AutoSize = true;
            this.lblMain1.BackColor = System.Drawing.Color.White;
            this.lblMain1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMain1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain1.Location = new System.Drawing.Point(231, 33);
            this.lblMain1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMain1.Name = "lblMain1";
            this.lblMain1.Size = new System.Drawing.Size(219, 39);
            this.lblMain1.TabIndex = 1;
            this.lblMain1.Text = "Appointment";
            this.lblMain1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMain2
            // 
            this.lblMain2.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lblMain2.AutoSize = true;
            this.lblMain2.BackColor = System.Drawing.Color.White;
            this.lblMain2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMain2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain2.Location = new System.Drawing.Point(668, 33);
            this.lblMain2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMain2.Name = "lblMain2";
            this.lblMain2.Size = new System.Drawing.Size(136, 39);
            this.lblMain2.TabIndex = 2;
            this.lblMain2.Text = "System";
            this.lblMain2.Click += new System.EventHandler(this.lblMain2_Click);
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
            this.mnuStrip.Size = new System.Drawing.Size(1067, 33);
            this.mnuStrip.TabIndex = 3;
            this.mnuStrip.Text = "menuStrip1";
            this.mnuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mnuServices
            // 
            this.mnuServices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetServiceType,
            this.mnuAddService,
            this.mnuChangeService,
            this.mnuDiscontinueService});
            this.mnuServices.Name = "mnuServices";
            this.mnuServices.Size = new System.Drawing.Size(102, 29);
            this.mnuServices.Text = "Services";
            // 
            // mnuSetServiceType
            // 
            this.mnuSetServiceType.Name = "mnuSetServiceType";
            this.mnuSetServiceType.Size = new System.Drawing.Size(282, 30);
            this.mnuSetServiceType.Text = "Set Service Type";
            this.mnuSetServiceType.Click += new System.EventHandler(this.mnuSetServiceType_Click);
            // 
            // mnuAddService
            // 
            this.mnuAddService.Name = "mnuAddService";
            this.mnuAddService.Size = new System.Drawing.Size(282, 30);
            this.mnuAddService.Text = "Add Service";
            this.mnuAddService.Click += new System.EventHandler(this.mnuAddService_Click);
            // 
            // mnuChangeService
            // 
            this.mnuChangeService.Name = "mnuChangeService";
            this.mnuChangeService.Size = new System.Drawing.Size(282, 30);
            this.mnuChangeService.Text = "Change Service";
            // 
            // mnuDiscontinueService
            // 
            this.mnuDiscontinueService.Name = "mnuDiscontinueService";
            this.mnuDiscontinueService.Size = new System.Drawing.Size(282, 30);
            this.mnuDiscontinueService.Text = "Discontinue Service";
            // 
            // mnuBarber
            // 
            this.mnuBarber.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddBarber,
            this.mnuChangeBarber,
            this.mnuRemoveBarber,
            this.mnuListBarbers});
            this.mnuBarber.Name = "mnuBarber";
            this.mnuBarber.Size = new System.Drawing.Size(97, 29);
            this.mnuBarber.Text = "Barbers";
            this.mnuBarber.Click += new System.EventHandler(this.barberToolStripMenuItem_Click);
            // 
            // mnuAddBarber
            // 
            this.mnuAddBarber.Name = "mnuAddBarber";
            this.mnuAddBarber.Size = new System.Drawing.Size(239, 30);
            this.mnuAddBarber.Text = "Add Barber";
            // 
            // mnuChangeBarber
            // 
            this.mnuChangeBarber.Name = "mnuChangeBarber";
            this.mnuChangeBarber.Size = new System.Drawing.Size(239, 30);
            this.mnuChangeBarber.Text = "Change Barber";
            // 
            // mnuRemoveBarber
            // 
            this.mnuRemoveBarber.Name = "mnuRemoveBarber";
            this.mnuRemoveBarber.Size = new System.Drawing.Size(239, 30);
            this.mnuRemoveBarber.Text = "Remove Barber";
            this.mnuRemoveBarber.Click += new System.EventHandler(this.mnuDiscontinueBarber_Click);
            // 
            // mnuListBarbers
            // 
            this.mnuListBarbers.Name = "mnuListBarbers";
            this.mnuListBarbers.Size = new System.Drawing.Size(239, 30);
            this.mnuListBarbers.Text = "List Barbers";
            // 
            // mnuAppointment
            // 
            this.mnuAppointment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMakeAppointment,
            this.mnuCancelAppointment});
            this.mnuAppointment.Name = "mnuAppointment";
            this.mnuAppointment.Size = new System.Drawing.Size(147, 29);
            this.mnuAppointment.Text = "Appointment";
            // 
            // mnuMakeAppointment
            // 
            this.mnuMakeAppointment.Name = "mnuMakeAppointment";
            this.mnuMakeAppointment.Size = new System.Drawing.Size(288, 30);
            this.mnuMakeAppointment.Text = "Make Appointment";
            // 
            // mnuCancelAppointment
            // 
            this.mnuCancelAppointment.Name = "mnuCancelAppointment";
            this.mnuCancelAppointment.Size = new System.Drawing.Size(288, 30);
            this.mnuCancelAppointment.Text = "Cancel Appointment";
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYearlyRevenueAnalyse,
            this.mnuYearlyBarberStatisctics});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(86, 29);
            this.mnuAdmin.Text = "Admin";
            // 
            // mnuYearlyRevenueAnalyse
            // 
            this.mnuYearlyRevenueAnalyse.Name = "mnuYearlyRevenueAnalyse";
            this.mnuYearlyRevenueAnalyse.Size = new System.Drawing.Size(323, 30);
            this.mnuYearlyRevenueAnalyse.Text = "Yearly Revenue Analyse";
            this.mnuYearlyRevenueAnalyse.Click += new System.EventHandler(this.yearlyRevenueToolStripMenuItem_Click);
            // 
            // mnuYearlyBarberStatisctics
            // 
            this.mnuYearlyBarberStatisctics.Name = "mnuYearlyBarberStatisctics";
            this.mnuYearlyBarberStatisctics.Size = new System.Drawing.Size(323, 30);
            this.mnuYearlyBarberStatisctics.Text = "Yearly Barber Statisctics";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblMain2);
            this.Controls.Add(this.lblMain1);
            this.Controls.Add(this.imgMainPicture);
            this.Controls.Add(this.mnuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ToolStripMenuItem mnuYearlyRevenueAnalyse;
        private System.Windows.Forms.ToolStripMenuItem mnuYearlyBarberStatisctics;
    }
}

