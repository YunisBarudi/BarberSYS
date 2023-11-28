namespace BarberAppointmentSYS
{
    partial class frmAddService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddService));
            this.imgAddService = new System.Windows.Forms.PictureBox();
            this.cmbBoxSetServiceType = new System.Windows.Forms.ComboBox();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtDescriptionService = new System.Windows.Forms.RichTextBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddService)).BeginInit();
            this.SuspendLayout();
            // 
            // imgAddService
            // 
            this.imgAddService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgAddService.BackgroundImage")));
            this.imgAddService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgAddService.Enabled = false;
            this.imgAddService.Image = global::BarberAppointmentSYS.Properties.Resources.backlogo;
            this.imgAddService.Location = new System.Drawing.Point(0, 0);
            this.imgAddService.Name = "imgAddService";
            this.imgAddService.Size = new System.Drawing.Size(1067, 554);
            this.imgAddService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAddService.TabIndex = 1;
            this.imgAddService.TabStop = false;
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
            this.cmbBoxSetServiceType.Location = new System.Drawing.Point(407, 44);
            this.cmbBoxSetServiceType.Name = "cmbBoxSetServiceType";
            this.cmbBoxSetServiceType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbBoxSetServiceType.Size = new System.Drawing.Size(288, 39);
            this.cmbBoxSetServiceType.TabIndex = 2;
            this.cmbBoxSetServiceType.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSetServiceType_SelectedIndexChanged);
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.Location = new System.Drawing.Point(52, 44);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(283, 38);
            this.lblServiceType.TabIndex = 3;
            this.lblServiceType.Text = "Set Service Type";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(54, 133);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(108, 38);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtServiceName
            // 
            this.txtServiceName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceName.Location = new System.Drawing.Point(407, 133);
            this.txtServiceName.MaxLength = 15;
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(261, 38);
            this.txtServiceName.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(54, 314);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(192, 38);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description";
            this.lblDescription.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.BackColor = System.Drawing.Color.Transparent;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(54, 225);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(90, 38);
            this.lblRate.TabIndex = 7;
            this.lblRate.Text = "Rate";
            // 
            // txtRate
            // 
            this.txtRate.AccessibleName = "";
            this.txtRate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(407, 223);
            this.txtRate.MaxLength = 5;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(117, 38);
            this.txtRate.TabIndex = 8;
            this.txtRate.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // txtDescriptionService
            // 
            this.txtDescriptionService.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionService.Location = new System.Drawing.Point(407, 314);
            this.txtDescriptionService.MaxLength = 50;
            this.txtDescriptionService.Name = "txtDescriptionService";
            this.txtDescriptionService.Size = new System.Drawing.Size(357, 93);
            this.txtDescriptionService.TabIndex = 9;
            this.txtDescriptionService.Text = "";
            // 
            // btnAddService
            // 
            this.btnAddService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.Location = new System.Drawing.Point(407, 455);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(269, 67);
            this.btnAddService.TabIndex = 10;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(59, 465);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 53);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.txtDescriptionService);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.cmbBoxSetServiceType);
            this.Controls.Add(this.imgAddService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddService";
            this.Text = "Add Service";
            this.Load += new System.EventHandler(this.frmAddService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAddService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox imgAddService;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.RichTextBox txtDescriptionService;
        private System.Windows.Forms.ComboBox cmbBoxSetServiceType;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnBack;
    }
}