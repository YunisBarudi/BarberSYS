namespace BarberAppointmentSYS
{
    partial class frmListBarbers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListBarbers));
            this.chkBoxForename = new System.Windows.Forms.CheckBox();
            this.btnListBarbers = new System.Windows.Forms.Button();
            this.chkBoxPhoneNumber = new System.Windows.Forms.CheckBox();
            this.chkBoxPostcode = new System.Windows.Forms.CheckBox();
            this.chkBoxSurname = new System.Windows.Forms.CheckBox();
            this.chkBoxEmail = new System.Windows.Forms.CheckBox();
            this.tblListBarbers = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkBoxForename
            // 
            this.chkBoxForename.AutoSize = true;
            this.chkBoxForename.BackColor = System.Drawing.Color.Transparent;
            this.chkBoxForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxForename.ForeColor = System.Drawing.Color.Black;
            this.chkBoxForename.Location = new System.Drawing.Point(42, 411);
            this.chkBoxForename.Name = "chkBoxForename";
            this.chkBoxForename.Size = new System.Drawing.Size(193, 41);
            this.chkBoxForename.TabIndex = 0;
            this.chkBoxForename.Text = "Forename";
            this.chkBoxForename.UseVisualStyleBackColor = false;
            // 
            // btnListBarbers
            // 
            this.btnListBarbers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListBarbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListBarbers.Location = new System.Drawing.Point(437, 475);
            this.btnListBarbers.Name = "btnListBarbers";
            this.btnListBarbers.Size = new System.Drawing.Size(269, 67);
            this.btnListBarbers.TabIndex = 22;
            this.btnListBarbers.Text = "List Barbers";
            this.btnListBarbers.UseVisualStyleBackColor = true;
            this.btnListBarbers.Click += new System.EventHandler(this.btnListBarbers_Click);
            // 
            // chkBoxPhoneNumber
            // 
            this.chkBoxPhoneNumber.AutoSize = true;
            this.chkBoxPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.chkBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.chkBoxPhoneNumber.Location = new System.Drawing.Point(709, 411);
            this.chkBoxPhoneNumber.Name = "chkBoxPhoneNumber";
            this.chkBoxPhoneNumber.Size = new System.Drawing.Size(136, 41);
            this.chkBoxPhoneNumber.TabIndex = 23;
            this.chkBoxPhoneNumber.Text = "Phone";
            this.chkBoxPhoneNumber.UseVisualStyleBackColor = false;
            // 
            // chkBoxPostcode
            // 
            this.chkBoxPostcode.AutoSize = true;
            this.chkBoxPostcode.BackColor = System.Drawing.Color.Transparent;
            this.chkBoxPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxPostcode.ForeColor = System.Drawing.Color.Black;
            this.chkBoxPostcode.Location = new System.Drawing.Point(488, 411);
            this.chkBoxPostcode.Name = "chkBoxPostcode";
            this.chkBoxPostcode.Size = new System.Drawing.Size(180, 41);
            this.chkBoxPostcode.TabIndex = 24;
            this.chkBoxPostcode.Text = "Postcode";
            this.chkBoxPostcode.UseVisualStyleBackColor = false;
            // 
            // chkBoxSurname
            // 
            this.chkBoxSurname.AutoSize = true;
            this.chkBoxSurname.BackColor = System.Drawing.Color.Transparent;
            this.chkBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxSurname.ForeColor = System.Drawing.Color.Black;
            this.chkBoxSurname.Location = new System.Drawing.Point(274, 411);
            this.chkBoxSurname.Name = "chkBoxSurname";
            this.chkBoxSurname.Size = new System.Drawing.Size(176, 41);
            this.chkBoxSurname.TabIndex = 25;
            this.chkBoxSurname.Text = "Surname";
            this.chkBoxSurname.UseVisualStyleBackColor = false;
            // 
            // chkBoxEmail
            // 
            this.chkBoxEmail.AutoSize = true;
            this.chkBoxEmail.BackColor = System.Drawing.Color.Transparent;
            this.chkBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxEmail.ForeColor = System.Drawing.Color.Black;
            this.chkBoxEmail.Location = new System.Drawing.Point(891, 411);
            this.chkBoxEmail.Name = "chkBoxEmail";
            this.chkBoxEmail.Size = new System.Drawing.Size(135, 41);
            this.chkBoxEmail.TabIndex = 26;
            this.chkBoxEmail.Text = "E-mail";
            this.chkBoxEmail.UseVisualStyleBackColor = false;
            // 
            // tblListBarbers
            // 
            this.tblListBarbers.ColumnCount = 1;
            this.tblListBarbers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblListBarbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblListBarbers.Location = new System.Drawing.Point(42, 80);
            this.tblListBarbers.Name = "tblListBarbers";
            this.tblListBarbers.RowCount = 1;
            this.tblListBarbers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblListBarbers.Size = new System.Drawing.Size(984, 263);
            this.tblListBarbers.TabIndex = 27;
            this.tblListBarbers.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(42, 485);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 53);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmListBarbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tblListBarbers);
            this.Controls.Add(this.chkBoxEmail);
            this.Controls.Add(this.chkBoxSurname);
            this.Controls.Add(this.chkBoxPostcode);
            this.Controls.Add(this.chkBoxPhoneNumber);
            this.Controls.Add(this.btnListBarbers);
            this.Controls.Add(this.chkBoxForename);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListBarbers";
            this.Text = "List Barbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBoxForename;
        private System.Windows.Forms.Button btnListBarbers;
        private System.Windows.Forms.CheckBox chkBoxPhoneNumber;
        private System.Windows.Forms.CheckBox chkBoxPostcode;
        private System.Windows.Forms.CheckBox chkBoxSurname;
        private System.Windows.Forms.CheckBox chkBoxEmail;
        private System.Windows.Forms.TableLayoutPanel tblListBarbers;
        private System.Windows.Forms.Button btnBack;
    }
}