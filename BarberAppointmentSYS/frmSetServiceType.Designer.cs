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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetServiceType));
            this.imgSetType = new System.Windows.Forms.PictureBox();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.txtServiceType = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescriptionType = new System.Windows.Forms.RichTextBox();
            this.btnSetServiceType = new System.Windows.Forms.Button();
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
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.Location = new System.Drawing.Point(12, 101);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(319, 42);
            this.lblServiceType.TabIndex = 1;
            this.lblServiceType.Text = "Set Service Type";
            this.lblServiceType.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtServiceType
            // 
            this.txtServiceType.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceType.Location = new System.Drawing.Point(408, 101);
            this.txtServiceType.MaxLength = 2;
            this.txtServiceType.Name = "txtServiceType";
            this.txtServiceType.Size = new System.Drawing.Size(87, 49);
            this.txtServiceType.TabIndex = 2;
            this.txtServiceType.TextChanged += new System.EventHandler(this.txtServiceType_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(12, 223);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(216, 42);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // txtDescriptionType
            // 
            this.txtDescriptionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionType.Location = new System.Drawing.Point(408, 223);
            this.txtDescriptionType.MaxLength = 50;
            this.txtDescriptionType.Name = "txtDescriptionType";
            this.txtDescriptionType.Size = new System.Drawing.Size(473, 145);
            this.txtDescriptionType.TabIndex = 5;
            this.txtDescriptionType.Text = "";
            this.txtDescriptionType.TextChanged += new System.EventHandler(this.txtDescriptionType_TextChanged);
            // 
            // btnSetServiceType
            // 
            this.btnSetServiceType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetServiceType.Location = new System.Drawing.Point(408, 442);
            this.btnSetServiceType.Name = "btnSetServiceType";
            this.btnSetServiceType.Size = new System.Drawing.Size(280, 70);
            this.btnSetServiceType.TabIndex = 6;
            this.btnSetServiceType.Text = "Set Service Type";
            this.btnSetServiceType.UseVisualStyleBackColor = true;
            this.btnSetServiceType.Click += new System.EventHandler(this.btnSetServiceType_Click);
            // 
            // frmSetServiceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSetServiceType);
            this.Controls.Add(this.txtDescriptionType);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtServiceType);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.imgSetType);
            this.Name = "frmSetServiceType";
            this.Text = "Set Service Type";
            ((System.ComponentModel.ISupportInitialize)(this.imgSetType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox imgSetType;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.TextBox txtServiceType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox txtDescriptionType;
        private System.Windows.Forms.Button btnSetServiceType;
    }
}