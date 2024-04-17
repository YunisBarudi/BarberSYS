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
            this.btnListBarbers = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.radForename = new System.Windows.Forms.RadioButton();
            this.radSurname = new System.Windows.Forms.RadioButton();
            this.radPostcode = new System.Windows.Forms.RadioButton();
            this.radPhone = new System.Windows.Forms.RadioButton();
            this.radEmail = new System.Windows.Forms.RadioButton();
            this.txtListBarbers = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnListBarbers
            // 
            this.btnListBarbers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListBarbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListBarbers.Location = new System.Drawing.Point(328, 386);
            this.btnListBarbers.Margin = new System.Windows.Forms.Padding(2);
            this.btnListBarbers.Name = "btnListBarbers";
            this.btnListBarbers.Size = new System.Drawing.Size(202, 54);
            this.btnListBarbers.TabIndex = 22;
            this.btnListBarbers.Text = "List Barbers";
            this.btnListBarbers.UseVisualStyleBackColor = true;
            this.btnListBarbers.Click += new System.EventHandler(this.btnListBarbers_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(32, 394);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 43);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // radForename
            // 
            this.radForename.AutoSize = true;
            this.radForename.BackColor = System.Drawing.Color.Transparent;
            this.radForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radForename.ForeColor = System.Drawing.Color.Black;
            this.radForename.Location = new System.Drawing.Point(32, 334);
            this.radForename.Name = "radForename";
            this.radForename.Size = new System.Drawing.Size(150, 33);
            this.radForename.TabIndex = 29;
            this.radForename.TabStop = true;
            this.radForename.Text = "Forename";
            this.radForename.UseVisualStyleBackColor = false;
            // 
            // radSurname
            // 
            this.radSurname.AutoSize = true;
            this.radSurname.BackColor = System.Drawing.Color.Transparent;
            this.radSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSurname.ForeColor = System.Drawing.Color.Black;
            this.radSurname.Location = new System.Drawing.Point(202, 334);
            this.radSurname.Name = "radSurname";
            this.radSurname.Size = new System.Drawing.Size(135, 33);
            this.radSurname.TabIndex = 30;
            this.radSurname.TabStop = true;
            this.radSurname.Text = "Surname";
            this.radSurname.UseVisualStyleBackColor = false;
            // 
            // radPostcode
            // 
            this.radPostcode.AutoSize = true;
            this.radPostcode.BackColor = System.Drawing.Color.Transparent;
            this.radPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPostcode.ForeColor = System.Drawing.Color.Black;
            this.radPostcode.Location = new System.Drawing.Point(361, 334);
            this.radPostcode.Name = "radPostcode";
            this.radPostcode.Size = new System.Drawing.Size(141, 33);
            this.radPostcode.TabIndex = 31;
            this.radPostcode.TabStop = true;
            this.radPostcode.Text = "Postcode";
            this.radPostcode.UseVisualStyleBackColor = false;
            // 
            // radPhone
            // 
            this.radPhone.AutoSize = true;
            this.radPhone.BackColor = System.Drawing.Color.Transparent;
            this.radPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPhone.ForeColor = System.Drawing.Color.Black;
            this.radPhone.Location = new System.Drawing.Point(532, 334);
            this.radPhone.Name = "radPhone";
            this.radPhone.Size = new System.Drawing.Size(106, 33);
            this.radPhone.TabIndex = 32;
            this.radPhone.TabStop = true;
            this.radPhone.Text = "Phone";
            this.radPhone.UseVisualStyleBackColor = false;
            // 
            // radEmail
            // 
            this.radEmail.AutoSize = true;
            this.radEmail.BackColor = System.Drawing.Color.Transparent;
            this.radEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEmail.ForeColor = System.Drawing.Color.Black;
            this.radEmail.Location = new System.Drawing.Point(672, 334);
            this.radEmail.Name = "radEmail";
            this.radEmail.Size = new System.Drawing.Size(97, 33);
            this.radEmail.TabIndex = 33;
            this.radEmail.TabStop = true;
            this.radEmail.Text = "Email";
            this.radEmail.UseVisualStyleBackColor = false;
            // 
            // txtListBarbers
            // 
            this.txtListBarbers.Location = new System.Drawing.Point(72, 39);
            this.txtListBarbers.Name = "txtListBarbers";
            this.txtListBarbers.Size = new System.Drawing.Size(633, 249);
            this.txtListBarbers.TabIndex = 34;
            this.txtListBarbers.Text = "";
            // 
            // frmListBarbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtListBarbers);
            this.Controls.Add(this.radEmail);
            this.Controls.Add(this.radPhone);
            this.Controls.Add(this.radPostcode);
            this.Controls.Add(this.radSurname);
            this.Controls.Add(this.radForename);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnListBarbers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmListBarbers";
            this.Text = "List Barbers";
            this.Load += new System.EventHandler(this.frmListBarbers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnListBarbers;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RadioButton radForename;
        private System.Windows.Forms.RadioButton radSurname;
        private System.Windows.Forms.RadioButton radPostcode;
        private System.Windows.Forms.RadioButton radPhone;
        private System.Windows.Forms.RadioButton radEmail;
        private System.Windows.Forms.RichTextBox txtListBarbers;
    }
}