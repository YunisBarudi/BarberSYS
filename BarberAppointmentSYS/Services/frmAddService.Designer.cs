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
            this.imgAddService.Margin = new System.Windows.Forms.Padding(2);
            this.imgAddService.Name = "imgAddService";
            this.imgAddService.Size = new System.Drawing.Size(800, 450);
            this.imgAddService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAddService.TabIndex = 1;
            this.imgAddService.TabStop = false;
            // 
            // cmbBoxSetServiceType
            // 
            this.cmbBoxSetServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSetServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxSetServiceType.Location = new System.Drawing.Point(305, 36);
            this.cmbBoxSetServiceType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxSetServiceType.Name = "cmbBoxSetServiceType";
            this.cmbBoxSetServiceType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbBoxSetServiceType.Size = new System.Drawing.Size(217, 34);
            this.cmbBoxSetServiceType.TabIndex = 2;
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.Location = new System.Drawing.Point(39, 36);
            this.lblServiceType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(237, 31);
            this.lblServiceType.TabIndex = 3;
            this.lblServiceType.Text = "Set Service Type";
            this.lblServiceType.Click += new System.EventHandler(this.lblServiceType_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(40, 108);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 31);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // txtServiceName
            // 
            this.txtServiceName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceName.Location = new System.Drawing.Point(305, 108);
            this.txtServiceName.Margin = new System.Windows.Forms.Padding(2);
            this.txtServiceName.MaxLength = 10;
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(197, 32);
            this.txtServiceName.TabIndex = 5;
            this.txtServiceName.TextChanged += new System.EventHandler(this.txtServiceName_TextChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(40, 255);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(162, 31);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.BackColor = System.Drawing.Color.Transparent;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(40, 183);
            this.lblRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(76, 31);
            this.lblRate.TabIndex = 7;
            this.lblRate.Text = "Rate";
            this.lblRate.Click += new System.EventHandler(this.lblRate_Click);
            // 
            // txtRate
            // 
            this.txtRate.AccessibleName = "";
            this.txtRate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(305, 181);
            this.txtRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtRate.MaxLength = 5;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(89, 32);
            this.txtRate.TabIndex = 8;
            // 
            // txtDescriptionService
            // 
            this.txtDescriptionService.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionService.Location = new System.Drawing.Point(305, 255);
            this.txtDescriptionService.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescriptionService.MaxLength = 20;
            this.txtDescriptionService.Name = "txtDescriptionService";
            this.txtDescriptionService.Size = new System.Drawing.Size(269, 76);
            this.txtDescriptionService.TabIndex = 9;
            this.txtDescriptionService.Text = "";
            this.txtDescriptionService.TextChanged += new System.EventHandler(this.txtDescriptionService_TextChanged);
            // 
            // btnAddService
            // 
            this.btnAddService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.Location = new System.Drawing.Point(305, 370);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(202, 54);
            this.btnAddService.TabIndex = 10;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(44, 378);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 43);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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