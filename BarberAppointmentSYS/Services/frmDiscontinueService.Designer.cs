namespace BarberAppointmentSYS
{
    partial class frmDiscontinueService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiscontinueService));
            this.imgDiscontinueService = new System.Windows.Forms.PictureBox();
            this.lblService = new System.Windows.Forms.Label();
            this.cmbBoxService = new System.Windows.Forms.ComboBox();
            this.btnDiscontinueService = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgDiscontinueService)).BeginInit();
            this.SuspendLayout();
            // 
            // imgDiscontinueService
            // 
            this.imgDiscontinueService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgDiscontinueService.BackgroundImage")));
            this.imgDiscontinueService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgDiscontinueService.Enabled = false;
            this.imgDiscontinueService.Image = global::BarberAppointmentSYS.Properties.Resources.backlogo;
            this.imgDiscontinueService.Location = new System.Drawing.Point(0, 0);
            this.imgDiscontinueService.Margin = new System.Windows.Forms.Padding(2);
            this.imgDiscontinueService.Name = "imgDiscontinueService";
            this.imgDiscontinueService.Size = new System.Drawing.Size(800, 450);
            this.imgDiscontinueService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgDiscontinueService.TabIndex = 3;
            this.imgDiscontinueService.TabStop = false;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.BackColor = System.Drawing.Color.Transparent;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(75, 99);
            this.lblService.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(121, 36);
            this.lblService.TabIndex = 14;
            this.lblService.Text = "Service";
            // 
            // cmbBoxService
            // 
            this.cmbBoxService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxService.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxService.Location = new System.Drawing.Point(294, 102);
            this.cmbBoxService.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxService.Name = "cmbBoxService";
            this.cmbBoxService.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbBoxService.Size = new System.Drawing.Size(217, 34);
            this.cmbBoxService.TabIndex = 15;
            // 
            // btnDiscontinueService
            // 
            this.btnDiscontinueService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscontinueService.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscontinueService.Location = new System.Drawing.Point(286, 369);
            this.btnDiscontinueService.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiscontinueService.Name = "btnDiscontinueService";
            this.btnDiscontinueService.Size = new System.Drawing.Size(234, 54);
            this.btnDiscontinueService.TabIndex = 19;
            this.btnDiscontinueService.Text = "Discontinue Service";
            this.btnDiscontinueService.UseVisualStyleBackColor = true;
            this.btnDiscontinueService.Click += new System.EventHandler(this.btnDiscontinueService_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(80, 380);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 43);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmDiscontinueService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDiscontinueService);
            this.Controls.Add(this.cmbBoxService);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.imgDiscontinueService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDiscontinueService";
            this.Text = "Discontinue Service";
            this.Load += new System.EventHandler(this.frmDiscontinueService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgDiscontinueService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox imgDiscontinueService;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ComboBox cmbBoxService;
        private System.Windows.Forms.Button btnDiscontinueService;
        private System.Windows.Forms.Button btnBack;
    }
}