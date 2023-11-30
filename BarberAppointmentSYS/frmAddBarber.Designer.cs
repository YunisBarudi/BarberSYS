namespace BarberAppointmentSYS
{
    partial class frmAddBarber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddBarber));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddBarber = new System.Windows.Forms.Button();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(130, 478);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 53);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddBarber
            // 
            this.btnAddBarber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBarber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBarber.Location = new System.Drawing.Point(476, 464);
            this.btnAddBarber.Name = "btnAddBarber";
            this.btnAddBarber.Size = new System.Drawing.Size(269, 67);
            this.btnAddBarber.TabIndex = 21;
            this.btnAddBarber.Text = "Add Barber";
            this.btnAddBarber.UseVisualStyleBackColor = true;
            this.btnAddBarber.Click += new System.EventHandler(this.btnAddBarber_Click);
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(123, 199);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(162, 38);
            this.lblPostcode.TabIndex = 18;
            this.lblPostcode.Text = "Postcode";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(123, 279);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(248, 38);
            this.lblPhoneNumber.TabIndex = 17;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(476, 114);
            this.txtSurname.MaxLength = 20;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(261, 38);
            this.txtSurname.TabIndex = 16;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(123, 114);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(156, 38);
            this.lblSurname.TabIndex = 15;
            this.lblSurname.Text = "Surname";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(123, 28);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(173, 38);
            this.lblForename.TabIndex = 14;
            this.lblForename.Text = "Forename";
            // 
            // txtForename
            // 
            this.txtForename.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtForename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForename.Location = new System.Drawing.Point(476, 28);
            this.txtForename.MaxLength = 20;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(261, 38);
            this.txtForename.TabIndex = 22;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(123, 365);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(115, 38);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "E-mail";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(476, 279);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(261, 38);
            this.txtPhoneNumber.TabIndex = 24;
            // 
            // txtPostcode
            // 
            this.txtPostcode.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPostcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.Location = new System.Drawing.Point(476, 199);
            this.txtPostcode.MaxLength = 7;
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(261, 38);
            this.txtPostcode.TabIndex = 25;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(476, 365);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(261, 38);
            this.txtEmail.TabIndex = 26;
            // 
            // frmAddBarber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.btnAddBarber);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddBarber";
            this.Text = "Add Barber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddBarber;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtEmail;
    }
}