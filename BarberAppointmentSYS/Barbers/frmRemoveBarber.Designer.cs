namespace BarberAppointmentSYS
{
    partial class frmRemoveBarber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveBarber));
            this.btnChangeBarber = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblBarber = new System.Windows.Forms.Label();
            this.cmbBoxBarber = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnChangeBarber
            // 
            this.btnChangeBarber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeBarber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeBarber.Location = new System.Drawing.Point(334, 337);
            this.btnChangeBarber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeBarber.Name = "btnChangeBarber";
            this.btnChangeBarber.Size = new System.Drawing.Size(202, 61);
            this.btnChangeBarber.TabIndex = 41;
            this.btnChangeBarber.Text = "Remove Barber";
            this.btnChangeBarber.UseVisualStyleBackColor = true;
            this.btnChangeBarber.Click += new System.EventHandler(this.btnChangeBarber_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(94, 349);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 43);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblBarber
            // 
            this.lblBarber.AutoSize = true;
            this.lblBarber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblBarber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarber.Location = new System.Drawing.Point(88, 89);
            this.lblBarber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarber.Name = "lblBarber";
            this.lblBarber.Size = new System.Drawing.Size(119, 37);
            this.lblBarber.TabIndex = 39;
            this.lblBarber.Text = "Barber";
            // 
            // cmbBoxBarber
            // 
            this.cmbBoxBarber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxBarber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxBarber.Location = new System.Drawing.Point(294, 89);
            this.cmbBoxBarber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBoxBarber.Name = "cmbBoxBarber";
            this.cmbBoxBarber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbBoxBarber.Size = new System.Drawing.Size(312, 38);
            this.cmbBoxBarber.TabIndex = 38;
            // 
            // frmRemoveBarber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangeBarber);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblBarber);
            this.Controls.Add(this.cmbBoxBarber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRemoveBarber";
            this.Text = "Remove Barber";
            this.Load += new System.EventHandler(this.frmRemoveBarber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeBarber;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblBarber;
        private System.Windows.Forms.ComboBox cmbBoxBarber;
    }
}