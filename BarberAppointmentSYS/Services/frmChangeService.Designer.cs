namespace BarberAppointmentSYS
{
    partial class frmChangeService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeService));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnChangeService = new System.Windows.Forms.Button();
            this.txtDescriptionService = new System.Windows.Forms.RichTextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.cmbBoxSetServiceType = new System.Windows.Forms.ComboBox();
            this.cmbBoxService = new System.Windows.Forms.ComboBox();
            this.lblService = new System.Windows.Forms.Label();
            this.imgChangeService = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgChangeService)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnChangeService);
            this.groupBox1.Controls.Add(this.txtDescriptionService);
            this.groupBox1.Controls.Add(this.txtRate);
            this.groupBox1.Controls.Add(this.lblRate);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.txtServiceName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblServiceType);
            this.groupBox1.Controls.Add(this.cmbBoxSetServiceType);
            this.groupBox1.Location = new System.Drawing.Point(130, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 438);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(50, 366);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 53);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnChangeService
            // 
            this.btnChangeService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeService.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeService.Location = new System.Drawing.Point(310, 366);
            this.btnChangeService.Name = "btnChangeService";
            this.btnChangeService.Size = new System.Drawing.Size(269, 67);
            this.btnChangeService.TabIndex = 18;
            this.btnChangeService.Text = "Change Service";
            this.btnChangeService.UseVisualStyleBackColor = true;
            this.btnChangeService.Click += new System.EventHandler(this.btnChangeService_Click);
            // 
            // txtDescriptionService
            // 
            this.txtDescriptionService.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionService.Location = new System.Drawing.Point(349, 236);
            this.txtDescriptionService.MaxLength = 50;
            this.txtDescriptionService.Name = "txtDescriptionService";
            this.txtDescriptionService.Size = new System.Drawing.Size(357, 93);
            this.txtDescriptionService.TabIndex = 17;
            this.txtDescriptionService.Text = "";
            // 
            // txtRate
            // 
            this.txtRate.AccessibleName = "";
            this.txtRate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(349, 165);
            this.txtRate.MaxLength = 5;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(117, 38);
            this.txtRate.TabIndex = 16;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.BackColor = System.Drawing.Color.Transparent;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(23, 165);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(81, 36);
            this.lblRate.TabIndex = 15;
            this.lblRate.Text = "Rate";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(22, 234);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(192, 38);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description";
            // 
            // txtServiceName
            // 
            this.txtServiceName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceName.Location = new System.Drawing.Point(349, 94);
            this.txtServiceName.MaxLength = 15;
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(261, 38);
            this.txtServiceName.TabIndex = 13;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(23, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 36);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.Location = new System.Drawing.Point(22, 34);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(256, 36);
            this.lblServiceType.TabIndex = 11;
            this.lblServiceType.Text = "Set Service Type";
            // 
            // cmbBoxSetServiceType
            // 
            this.cmbBoxSetServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSetServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxSetServiceType.Items.AddRange(new object[] {
            "BT - Beard",
            "HC - Haircut",
            "WH - Wash and Go",
            "HB - Haircut and Beard "});
            this.cmbBoxSetServiceType.Location = new System.Drawing.Point(349, 34);
            this.cmbBoxSetServiceType.Name = "cmbBoxSetServiceType";
            this.cmbBoxSetServiceType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbBoxSetServiceType.Size = new System.Drawing.Size(288, 39);
            this.cmbBoxSetServiceType.TabIndex = 10;
            // 
            // cmbBoxService
            // 
            this.cmbBoxService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxService.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxService.Items.AddRange(new object[] {
            "Fade haircut",
            "Clipper haircut",
            "Beard Fade",
            "Beard Shape-Up"});
            this.cmbBoxService.Location = new System.Drawing.Point(479, 43);
            this.cmbBoxService.Name = "cmbBoxService";
            this.cmbBoxService.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbBoxService.Size = new System.Drawing.Size(288, 39);
            this.cmbBoxService.TabIndex = 11;
            this.cmbBoxService.SelectedIndexChanged += new System.EventHandler(this.cmbBoxService_SelectedIndexChanged);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.BackColor = System.Drawing.Color.Transparent;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(152, 53);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(134, 38);
            this.lblService.TabIndex = 13;
            this.lblService.Text = "Service";
            // 
            // imgChangeService
            // 
            this.imgChangeService.BackColor = System.Drawing.Color.Transparent;
            this.imgChangeService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgChangeService.BackgroundImage")));
            this.imgChangeService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgChangeService.Enabled = false;
            this.imgChangeService.Image = global::BarberAppointmentSYS.Properties.Resources.backlogo;
            this.imgChangeService.Location = new System.Drawing.Point(0, 0);
            this.imgChangeService.Name = "imgChangeService";
            this.imgChangeService.Size = new System.Drawing.Size(1067, 554);
            this.imgChangeService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgChangeService.TabIndex = 2;
            this.imgChangeService.TabStop = false;
            // 
            // frmChangeService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.cmbBoxService);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imgChangeService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChangeService";
            this.Text = "Change Service";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgChangeService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox imgChangeService;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtDescriptionService;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.ComboBox cmbBoxSetServiceType;
        private System.Windows.Forms.ComboBox cmbBoxService;
        private System.Windows.Forms.Button btnChangeService;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Button btnBack;
    }
}