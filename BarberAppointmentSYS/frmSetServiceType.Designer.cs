namespace BarberAppointmentSYS
{
    partial class frmSetServiceType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetServiceType));
            this.imgSetType = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgSetType)).BeginInit();
            this.SuspendLayout();
            // 
            // imgSetType
            // 
            this.imgSetType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgSetType.BackgroundImage")));
            this.imgSetType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgSetType.Image = global::BarberAppointmentSYS.Properties.Resources.backlogo;
            this.imgSetType.Location = new System.Drawing.Point(0, 0);
            this.imgSetType.Name = "imgSetType";
            this.imgSetType.Size = new System.Drawing.Size(1067, 554);
            this.imgSetType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSetType.TabIndex = 0;
            this.imgSetType.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set Service Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmSetServiceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgSetType);
            this.Name = "frmSetServiceType";
            this.Text = "Set Service Type";
            ((System.ComponentModel.ISupportInitialize)(this.imgSetType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox imgSetType;
        private System.Windows.Forms.Label label1;
    }
}