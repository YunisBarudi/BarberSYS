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
            this.groupBox1.Location = new System.Drawing.Point(98, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(640, 356);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(38, 297);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 43);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnChangeService
            // 
            this.btnChangeService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeService.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeService.Location = new System.Drawing.Point(232, 297);
            this.btnChangeService.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeService.Name = "btnChangeService";
            this.btnChangeService.Size = new System.Drawing.Size(202, 54);
            this.btnChangeService.TabIndex = 18;
            this.btnChangeService.Text = "Change Service";
            this.btnChangeService.UseVisualStyleBackColor = true;
            this.btnChangeService.Click += new System.EventHandler(this.btnChangeService_Click);
            // 
            // txtDescriptionService
            // 
            this.txtDescriptionService.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionService.Location = new System.Drawing.Point(262, 192);
            this.txtDescriptionService.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescriptionService.MaxLength = 20;
            this.txtDescriptionService.Name = "txtDescriptionService";
            this.txtDescriptionService.Size = new System.Drawing.Size(269, 76);
            this.txtDescriptionService.TabIndex = 17;
            this.txtDescriptionService.Text = "";
            // 
            // txtRate
            // 
            this.txtRate.AccessibleName = "";
            this.txtRate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(262, 134);
            this.txtRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtRate.MaxLength = 5;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(89, 32);
            this.txtRate.TabIndex = 16;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.BackColor = System.Drawing.Color.Transparent;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(17, 134);
            this.lblRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(67, 29);
            this.lblRate.TabIndex = 15;
            this.lblRate.Text = "Rate";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(16, 190);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(162, 31);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description";
            // 
            // txtServiceName
            // 
            this.txtServiceName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceName.Location = new System.Drawing.Point(262, 76);
            this.txtServiceName.Margin = new System.Windows.Forms.Padding(2);
            this.txtServiceName.MaxLength = 15;
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(197, 32);
            this.txtServiceName.TabIndex = 13;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(17, 78);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 29);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.Location = new System.Drawing.Point(16, 28);
            this.lblServiceType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(213, 29);
            this.lblServiceType.TabIndex = 11;
            this.lblServiceType.Text = "Set Service Type";
            // 
            // cmbBoxSetServiceType
            // 
            this.cmbBoxSetServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSetServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxSetServiceType.Location = new System.Drawing.Point(262, 28);
            this.cmbBoxSetServiceType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxSetServiceType.Name = "cmbBoxSetServiceType";
            this.cmbBoxSetServiceType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbBoxSetServiceType.Size = new System.Drawing.Size(217, 34);
            this.cmbBoxSetServiceType.TabIndex = 10;
            // 
            // cmbBoxService
            // 
            this.cmbBoxService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxService.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxService.Location = new System.Drawing.Point(359, 35);
            this.cmbBoxService.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxService.Name = "cmbBoxService";
            this.cmbBoxService.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbBoxService.Size = new System.Drawing.Size(217, 34);
            this.cmbBoxService.TabIndex = 11;
            this.cmbBoxService.SelectedIndexChanged += new System.EventHandler(this.cmbBoxService_SelectedIndexChanged);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.BackColor = System.Drawing.Color.Transparent;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(114, 43);
            this.lblService.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(112, 31);
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
            this.imgChangeService.Margin = new System.Windows.Forms.Padding(2);
            this.imgChangeService.Name = "imgChangeService";
            this.imgChangeService.Size = new System.Drawing.Size(800, 450);
            this.imgChangeService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgChangeService.TabIndex = 2;
            this.imgChangeService.TabStop = false;
            // 
            // frmChangeService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.cmbBoxService);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imgChangeService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmChangeService";
            this.Text = "Change Service";
            this.Load += new System.EventHandler(this.frmChangeService_Load);
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