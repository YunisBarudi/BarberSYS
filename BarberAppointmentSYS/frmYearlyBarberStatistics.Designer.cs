namespace BarberAppointmentSYS
{
    partial class frmYearlyBarberStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYearlyBarberStatistics));
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.grpBoxStatictics = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtBarber2 = new System.Windows.Forms.TextBox();
            this.txtBarber4 = new System.Windows.Forms.TextBox();
            this.txtBarber3 = new System.Windows.Forms.TextBox();
            this.txtBarber1 = new System.Windows.Forms.TextBox();
            this.lblBarber3 = new System.Windows.Forms.Label();
            this.lblBarber4 = new System.Windows.Forms.Label();
            this.lblBarber2 = new System.Windows.Forms.Label();
            this.lblBarber1 = new System.Windows.Forms.Label();
            this.grpBoxStatictics.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(58, 460);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 53);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cmbYear.Location = new System.Drawing.Point(511, 55);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbYear.Size = new System.Drawing.Size(211, 39);
            this.cmbYear.TabIndex = 32;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(306, 52);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(101, 42);
            this.lblYear.TabIndex = 31;
            this.lblYear.Text = "Year";
            // 
            // grpBoxStatictics
            // 
            this.grpBoxStatictics.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxStatictics.Controls.Add(this.btnReset);
            this.grpBoxStatictics.Controls.Add(this.txtBarber2);
            this.grpBoxStatictics.Controls.Add(this.txtBarber4);
            this.grpBoxStatictics.Controls.Add(this.txtBarber3);
            this.grpBoxStatictics.Controls.Add(this.txtBarber1);
            this.grpBoxStatictics.Controls.Add(this.lblBarber3);
            this.grpBoxStatictics.Controls.Add(this.lblBarber4);
            this.grpBoxStatictics.Controls.Add(this.lblBarber2);
            this.grpBoxStatictics.Controls.Add(this.lblBarber1);
            this.grpBoxStatictics.Location = new System.Drawing.Point(198, 111);
            this.grpBoxStatictics.Name = "grpBoxStatictics";
            this.grpBoxStatictics.Size = new System.Drawing.Size(737, 415);
            this.grpBoxStatictics.TabIndex = 34;
            this.grpBoxStatictics.TabStop = false;
            this.grpBoxStatictics.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(313, 349);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 53);
            this.btnReset.TabIndex = 40;
            this.btnReset.Text = "OK";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtBarber2
            // 
            this.txtBarber2.Enabled = false;
            this.txtBarber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarber2.Location = new System.Drawing.Point(442, 127);
            this.txtBarber2.Name = "txtBarber2";
            this.txtBarber2.Size = new System.Drawing.Size(100, 38);
            this.txtBarber2.TabIndex = 39;
            this.txtBarber2.Text = "5950";
            // 
            // txtBarber4
            // 
            this.txtBarber4.Enabled = false;
            this.txtBarber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarber4.ForeColor = System.Drawing.Color.Red;
            this.txtBarber4.Location = new System.Drawing.Point(442, 272);
            this.txtBarber4.Name = "txtBarber4";
            this.txtBarber4.Size = new System.Drawing.Size(100, 38);
            this.txtBarber4.TabIndex = 37;
            this.txtBarber4.Text = "3950";
            // 
            // txtBarber3
            // 
            this.txtBarber3.Enabled = false;
            this.txtBarber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarber3.ForeColor = System.Drawing.Color.Lime;
            this.txtBarber3.Location = new System.Drawing.Point(442, 197);
            this.txtBarber3.Name = "txtBarber3";
            this.txtBarber3.Size = new System.Drawing.Size(100, 38);
            this.txtBarber3.TabIndex = 36;
            this.txtBarber3.Text = "9000";
            // 
            // txtBarber1
            // 
            this.txtBarber1.Enabled = false;
            this.txtBarber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarber1.Location = new System.Drawing.Point(442, 51);
            this.txtBarber1.Name = "txtBarber1";
            this.txtBarber1.Size = new System.Drawing.Size(100, 38);
            this.txtBarber1.TabIndex = 19;
            this.txtBarber1.Text = "5000";
            // 
            // lblBarber3
            // 
            this.lblBarber3.AutoSize = true;
            this.lblBarber3.BackColor = System.Drawing.Color.White;
            this.lblBarber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarber3.ForeColor = System.Drawing.Color.Lime;
            this.lblBarber3.Location = new System.Drawing.Point(109, 197);
            this.lblBarber3.Name = "lblBarber3";
            this.lblBarber3.Padding = new System.Windows.Forms.Padding(3);
            this.lblBarber3.Size = new System.Drawing.Size(247, 38);
            this.lblBarber3.TabIndex = 20;
            this.lblBarber3.Text = "003 Roman Hnat";
            // 
            // lblBarber4
            // 
            this.lblBarber4.AutoSize = true;
            this.lblBarber4.BackColor = System.Drawing.Color.White;
            this.lblBarber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarber4.ForeColor = System.Drawing.Color.Red;
            this.lblBarber4.Location = new System.Drawing.Point(109, 272);
            this.lblBarber4.Name = "lblBarber4";
            this.lblBarber4.Padding = new System.Windows.Forms.Padding(3);
            this.lblBarber4.Size = new System.Drawing.Size(250, 38);
            this.lblBarber4.TabIndex = 19;
            this.lblBarber4.Text = "004 Lionel Messi";
            // 
            // lblBarber2
            // 
            this.lblBarber2.AutoSize = true;
            this.lblBarber2.BackColor = System.Drawing.Color.White;
            this.lblBarber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarber2.Location = new System.Drawing.Point(109, 127);
            this.lblBarber2.Name = "lblBarber2";
            this.lblBarber2.Padding = new System.Windows.Forms.Padding(3);
            this.lblBarber2.Size = new System.Drawing.Size(261, 38);
            this.lblBarber2.TabIndex = 18;
            this.lblBarber2.Text = "002 Barudi Yunis ";
            // 
            // lblBarber1
            // 
            this.lblBarber1.AutoSize = true;
            this.lblBarber1.BackColor = System.Drawing.Color.White;
            this.lblBarber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarber1.Location = new System.Drawing.Point(109, 51);
            this.lblBarber1.Name = "lblBarber1";
            this.lblBarber1.Padding = new System.Windows.Forms.Padding(3);
            this.lblBarber1.Size = new System.Drawing.Size(230, 38);
            this.lblBarber1.TabIndex = 17;
            this.lblBarber1.Text = "001 Joe Bloggs";
            // 
            // frmYearlyBarberStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpBoxStatictics);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblYear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmYearlyBarberStatistics";
            this.Text = "Yearly Barber Statistics";
            this.grpBoxStatictics.ResumeLayout(false);
            this.grpBoxStatictics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.GroupBox grpBoxStatictics;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtBarber2;
        private System.Windows.Forms.TextBox txtBarber4;
        private System.Windows.Forms.TextBox txtBarber3;
        private System.Windows.Forms.TextBox txtBarber1;
        private System.Windows.Forms.Label lblBarber3;
        private System.Windows.Forms.Label lblBarber4;
        private System.Windows.Forms.Label lblBarber2;
        private System.Windows.Forms.Label lblBarber1;
    }
}