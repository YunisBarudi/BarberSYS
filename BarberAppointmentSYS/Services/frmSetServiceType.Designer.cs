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
            this.lblServiceType = new System.Windows.Forms.Label();
            this.txtServiceType = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescriptionType = new System.Windows.Forms.RichTextBox();
            this.btnSetServiceType = new System.Windows.Forms.Button();
            this.imgSetType = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgSetType)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.Location = new System.Drawing.Point(9, 82);
            this.lblServiceType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(256, 36);
            this.lblServiceType.TabIndex = 1;
            this.lblServiceType.Text = "Set Service Type";
            this.lblServiceType.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtServiceType
            // 
            this.txtServiceType.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceType.Location = new System.Drawing.Point(306, 82);
            this.txtServiceType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtServiceType.MaxLength = 2;
            this.txtServiceType.Name = "txtServiceType";
            this.txtServiceType.Size = new System.Drawing.Size(66, 41);
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
            this.lblDescription.Location = new System.Drawing.Point(9, 181);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(176, 36);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // txtDescriptionType
            // 
            this.txtDescriptionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionType.Location = new System.Drawing.Point(306, 181);
            this.txtDescriptionType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescriptionType.MaxLength = 20;
            this.txtDescriptionType.Name = "txtDescriptionType";
            this.txtDescriptionType.Size = new System.Drawing.Size(356, 119);
            this.txtDescriptionType.TabIndex = 5;
            this.txtDescriptionType.Text = "";
            this.txtDescriptionType.TextChanged += new System.EventHandler(this.txtDescriptionType_TextChanged);
            // 
            // btnSetServiceType
            // 
            this.btnSetServiceType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetServiceType.Location = new System.Drawing.Point(306, 359);
            this.btnSetServiceType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSetServiceType.Name = "btnSetServiceType";
            this.btnSetServiceType.Size = new System.Drawing.Size(210, 57);
            this.btnSetServiceType.TabIndex = 6;
            this.btnSetServiceType.Text = "Set Service Type";
            this.btnSetServiceType.UseVisualStyleBackColor = true;
            this.btnSetServiceType.Click += new System.EventHandler(this.btnSetServiceType_Click);
            // 
            // imgSetType
            // 
            this.imgSetType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgSetType.BackgroundImage")));
            this.imgSetType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgSetType.Image = global::BarberAppointmentSYS.Properties.Resources.backlogo;
            this.imgSetType.Location = new System.Drawing.Point(0, 0);
            this.imgSetType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgSetType.Name = "imgSetType";
            this.imgSetType.Size = new System.Drawing.Size(800, 450);
            this.imgSetType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSetType.TabIndex = 0;
            this.imgSetType.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 371);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSetServiceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSetServiceType);
            this.Controls.Add(this.txtDescriptionType);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtServiceType);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.imgSetType);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button button1;
    }
}