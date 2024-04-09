namespace BarberAppointmentSYS
{
    partial class frmYearlyRevenueAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYearlyRevenueAnalysis));
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.grpBoxStatictics = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtFeb = new System.Windows.Forms.TextBox();
            this.txtMay = new System.Windows.Forms.TextBox();
            this.txtApril = new System.Windows.Forms.TextBox();
            this.txtMarch = new System.Windows.Forms.TextBox();
            this.txtJuly = new System.Windows.Forms.TextBox();
            this.txtAugust = new System.Windows.Forms.TextBox();
            this.txtSeptember = new System.Windows.Forms.TextBox();
            this.txtOct = new System.Windows.Forms.TextBox();
            this.txtNov = new System.Windows.Forms.TextBox();
            this.txtDec = new System.Windows.Forms.TextBox();
            this.txtJune = new System.Windows.Forms.TextBox();
            this.txtJan = new System.Windows.Forms.TextBox();
            this.lblDec = new System.Windows.Forms.Label();
            this.lblJuly = new System.Windows.Forms.Label();
            this.lblAugust = new System.Windows.Forms.Label();
            this.lblSept = new System.Windows.Forms.Label();
            this.lblOct = new System.Windows.Forms.Label();
            this.lblNov = new System.Windows.Forms.Label();
            this.lblJune = new System.Windows.Forms.Label();
            this.lblMay = new System.Windows.Forms.Label();
            this.lblMarch = new System.Windows.Forms.Label();
            this.lblApril = new System.Windows.Forms.Label();
            this.lblFeb = new System.Windows.Forms.Label();
            this.lblJan = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpBoxStatictics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
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
            this.cmbYear.Location = new System.Drawing.Point(324, 41);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbYear.Size = new System.Drawing.Size(159, 34);
            this.cmbYear.TabIndex = 17;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbBoxService_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(170, 39);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(81, 36);
            this.lblYear.TabIndex = 16;
            this.lblYear.Text = "Year";
            // 
            // grpBoxStatictics
            // 
            this.grpBoxStatictics.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxStatictics.Controls.Add(this.btnReset);
            this.grpBoxStatictics.Controls.Add(this.txtFeb);
            this.grpBoxStatictics.Controls.Add(this.txtMay);
            this.grpBoxStatictics.Controls.Add(this.txtApril);
            this.grpBoxStatictics.Controls.Add(this.txtMarch);
            this.grpBoxStatictics.Controls.Add(this.txtJuly);
            this.grpBoxStatictics.Controls.Add(this.txtAugust);
            this.grpBoxStatictics.Controls.Add(this.txtSeptember);
            this.grpBoxStatictics.Controls.Add(this.txtOct);
            this.grpBoxStatictics.Controls.Add(this.txtNov);
            this.grpBoxStatictics.Controls.Add(this.txtDec);
            this.grpBoxStatictics.Controls.Add(this.txtJune);
            this.grpBoxStatictics.Controls.Add(this.txtJan);
            this.grpBoxStatictics.Controls.Add(this.lblDec);
            this.grpBoxStatictics.Controls.Add(this.lblJuly);
            this.grpBoxStatictics.Controls.Add(this.lblAugust);
            this.grpBoxStatictics.Controls.Add(this.lblSept);
            this.grpBoxStatictics.Controls.Add(this.lblOct);
            this.grpBoxStatictics.Controls.Add(this.lblNov);
            this.grpBoxStatictics.Controls.Add(this.lblJune);
            this.grpBoxStatictics.Controls.Add(this.lblMay);
            this.grpBoxStatictics.Controls.Add(this.lblMarch);
            this.grpBoxStatictics.Controls.Add(this.lblApril);
            this.grpBoxStatictics.Controls.Add(this.lblFeb);
            this.grpBoxStatictics.Controls.Add(this.lblJan);
            this.grpBoxStatictics.Location = new System.Drawing.Point(139, 103);
            this.grpBoxStatictics.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxStatictics.Name = "grpBoxStatictics";
            this.grpBoxStatictics.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxStatictics.Size = new System.Drawing.Size(553, 337);
            this.grpBoxStatictics.TabIndex = 18;
            this.grpBoxStatictics.TabStop = false;
            this.grpBoxStatictics.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(226, 301);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(71, 36);
            this.btnReset.TabIndex = 40;
            this.btnReset.Text = "OK";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtFeb
            // 
            this.txtFeb.Enabled = false;
            this.txtFeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeb.Location = new System.Drawing.Point(164, 72);
            this.txtFeb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFeb.Name = "txtFeb";
            this.txtFeb.Size = new System.Drawing.Size(76, 32);
            this.txtFeb.TabIndex = 39;
            this.txtFeb.Text = "1200";
            // 
            // txtMay
            // 
            this.txtMay.Enabled = false;
            this.txtMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMay.Location = new System.Drawing.Point(164, 207);
            this.txtMay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMay.Name = "txtMay";
            this.txtMay.Size = new System.Drawing.Size(76, 32);
            this.txtMay.TabIndex = 38;
            this.txtMay.Text = "2500";
            // 
            // txtApril
            // 
            this.txtApril.Enabled = false;
            this.txtApril.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApril.Location = new System.Drawing.Point(164, 158);
            this.txtApril.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApril.Name = "txtApril";
            this.txtApril.Size = new System.Drawing.Size(76, 32);
            this.txtApril.TabIndex = 37;
            this.txtApril.Text = "800";
            // 
            // txtMarch
            // 
            this.txtMarch.Enabled = false;
            this.txtMarch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarch.Location = new System.Drawing.Point(164, 115);
            this.txtMarch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMarch.Name = "txtMarch";
            this.txtMarch.Size = new System.Drawing.Size(76, 32);
            this.txtMarch.TabIndex = 36;
            this.txtMarch.Text = "750";
            // 
            // txtJuly
            // 
            this.txtJuly.Enabled = false;
            this.txtJuly.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJuly.Location = new System.Drawing.Point(434, 31);
            this.txtJuly.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJuly.Name = "txtJuly";
            this.txtJuly.Size = new System.Drawing.Size(76, 32);
            this.txtJuly.TabIndex = 35;
            this.txtJuly.Text = "2750";
            // 
            // txtAugust
            // 
            this.txtAugust.Enabled = false;
            this.txtAugust.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAugust.Location = new System.Drawing.Point(434, 73);
            this.txtAugust.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAugust.Name = "txtAugust";
            this.txtAugust.Size = new System.Drawing.Size(76, 32);
            this.txtAugust.TabIndex = 34;
            this.txtAugust.Text = "2400";
            // 
            // txtSeptember
            // 
            this.txtSeptember.Enabled = false;
            this.txtSeptember.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeptember.Location = new System.Drawing.Point(434, 115);
            this.txtSeptember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSeptember.Name = "txtSeptember";
            this.txtSeptember.Size = new System.Drawing.Size(76, 32);
            this.txtSeptember.TabIndex = 33;
            this.txtSeptember.Text = "2100";
            // 
            // txtOct
            // 
            this.txtOct.Enabled = false;
            this.txtOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOct.Location = new System.Drawing.Point(434, 161);
            this.txtOct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOct.Name = "txtOct";
            this.txtOct.Size = new System.Drawing.Size(76, 32);
            this.txtOct.TabIndex = 32;
            this.txtOct.Text = "1500";
            // 
            // txtNov
            // 
            this.txtNov.Enabled = false;
            this.txtNov.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNov.Location = new System.Drawing.Point(434, 208);
            this.txtNov.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNov.Name = "txtNov";
            this.txtNov.Size = new System.Drawing.Size(76, 32);
            this.txtNov.TabIndex = 31;
            this.txtNov.Text = "2900";
            // 
            // txtDec
            // 
            this.txtDec.Enabled = false;
            this.txtDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDec.Location = new System.Drawing.Point(434, 255);
            this.txtDec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDec.Name = "txtDec";
            this.txtDec.Size = new System.Drawing.Size(76, 32);
            this.txtDec.TabIndex = 30;
            this.txtDec.Text = "3000";
            // 
            // txtJune
            // 
            this.txtJune.Enabled = false;
            this.txtJune.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJune.Location = new System.Drawing.Point(164, 253);
            this.txtJune.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJune.Name = "txtJune";
            this.txtJune.Size = new System.Drawing.Size(76, 32);
            this.txtJune.TabIndex = 29;
            this.txtJune.Text = "3000";
            // 
            // txtJan
            // 
            this.txtJan.Enabled = false;
            this.txtJan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJan.Location = new System.Drawing.Point(164, 30);
            this.txtJan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJan.Name = "txtJan";
            this.txtJan.Size = new System.Drawing.Size(76, 32);
            this.txtJan.TabIndex = 19;
            this.txtJan.Text = "1000";
            // 
            // lblDec
            // 
            this.lblDec.AutoSize = true;
            this.lblDec.BackColor = System.Drawing.Color.White;
            this.lblDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDec.Location = new System.Drawing.Point(286, 255);
            this.lblDec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDec.Name = "lblDec";
            this.lblDec.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblDec.Size = new System.Drawing.Size(125, 30);
            this.lblDec.TabIndex = 28;
            this.lblDec.Text = "December";
            // 
            // lblJuly
            // 
            this.lblJuly.AutoSize = true;
            this.lblJuly.BackColor = System.Drawing.Color.White;
            this.lblJuly.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuly.Location = new System.Drawing.Point(286, 30);
            this.lblJuly.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJuly.Name = "lblJuly";
            this.lblJuly.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblJuly.Size = new System.Drawing.Size(59, 30);
            this.lblJuly.TabIndex = 27;
            this.lblJuly.Text = "July";
            // 
            // lblAugust
            // 
            this.lblAugust.AutoSize = true;
            this.lblAugust.BackColor = System.Drawing.Color.White;
            this.lblAugust.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAugust.Location = new System.Drawing.Point(286, 72);
            this.lblAugust.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAugust.Name = "lblAugust";
            this.lblAugust.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblAugust.Size = new System.Drawing.Size(90, 30);
            this.lblAugust.TabIndex = 26;
            this.lblAugust.Text = "August";
            // 
            // lblSept
            // 
            this.lblSept.AutoSize = true;
            this.lblSept.BackColor = System.Drawing.Color.White;
            this.lblSept.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSept.Location = new System.Drawing.Point(286, 115);
            this.lblSept.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSept.Name = "lblSept";
            this.lblSept.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblSept.Size = new System.Drawing.Size(132, 30);
            this.lblSept.TabIndex = 25;
            this.lblSept.Text = "September";
            // 
            // lblOct
            // 
            this.lblOct.AutoSize = true;
            this.lblOct.BackColor = System.Drawing.Color.White;
            this.lblOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOct.Location = new System.Drawing.Point(286, 161);
            this.lblOct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOct.Name = "lblOct";
            this.lblOct.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblOct.Size = new System.Drawing.Size(100, 30);
            this.lblOct.TabIndex = 24;
            this.lblOct.Text = "October";
            // 
            // lblNov
            // 
            this.lblNov.AutoSize = true;
            this.lblNov.BackColor = System.Drawing.Color.White;
            this.lblNov.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNov.Location = new System.Drawing.Point(286, 208);
            this.lblNov.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNov.Name = "lblNov";
            this.lblNov.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblNov.Size = new System.Drawing.Size(125, 30);
            this.lblNov.TabIndex = 23;
            this.lblNov.Text = "November";
            // 
            // lblJune
            // 
            this.lblJune.AutoSize = true;
            this.lblJune.BackColor = System.Drawing.Color.White;
            this.lblJune.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJune.Location = new System.Drawing.Point(32, 255);
            this.lblJune.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJune.Name = "lblJune";
            this.lblJune.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblJune.Size = new System.Drawing.Size(67, 30);
            this.lblJune.TabIndex = 22;
            this.lblJune.Text = "June";
            // 
            // lblMay
            // 
            this.lblMay.AutoSize = true;
            this.lblMay.BackColor = System.Drawing.Color.White;
            this.lblMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMay.Location = new System.Drawing.Point(32, 208);
            this.lblMay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMay.Name = "lblMay";
            this.lblMay.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblMay.Size = new System.Drawing.Size(60, 30);
            this.lblMay.TabIndex = 21;
            this.lblMay.Text = "May";
            // 
            // lblMarch
            // 
            this.lblMarch.AutoSize = true;
            this.lblMarch.BackColor = System.Drawing.Color.White;
            this.lblMarch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarch.Location = new System.Drawing.Point(32, 115);
            this.lblMarch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarch.Name = "lblMarch";
            this.lblMarch.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblMarch.Size = new System.Drawing.Size(81, 30);
            this.lblMarch.TabIndex = 20;
            this.lblMarch.Text = "March";
            // 
            // lblApril
            // 
            this.lblApril.AutoSize = true;
            this.lblApril.BackColor = System.Drawing.Color.White;
            this.lblApril.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApril.Location = new System.Drawing.Point(32, 161);
            this.lblApril.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApril.Name = "lblApril";
            this.lblApril.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblApril.Size = new System.Drawing.Size(65, 30);
            this.lblApril.TabIndex = 19;
            this.lblApril.Text = "April";
            // 
            // lblFeb
            // 
            this.lblFeb.AutoSize = true;
            this.lblFeb.BackColor = System.Drawing.Color.White;
            this.lblFeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeb.Location = new System.Drawing.Point(32, 72);
            this.lblFeb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeb.Name = "lblFeb";
            this.lblFeb.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblFeb.Size = new System.Drawing.Size(110, 30);
            this.lblFeb.TabIndex = 18;
            this.lblFeb.Text = "February";
            // 
            // lblJan
            // 
            this.lblJan.AutoSize = true;
            this.lblJan.BackColor = System.Drawing.Color.White;
            this.lblJan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJan.Location = new System.Drawing.Point(32, 30);
            this.lblJan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJan.Name = "lblJan";
            this.lblJan.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblJan.Size = new System.Drawing.Size(100, 30);
            this.lblJan.TabIndex = 17;
            this.lblJan.Text = "January";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(38, 388);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 43);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(54, 55);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 41;
            this.chart1.Text = "chart1";
            // 
            // frmYearlyRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpBoxStatictics);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblYear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmYearlyRevenueAnalysis";
            this.Text = "Yearly Revenue Analysis";
            this.grpBoxStatictics.ResumeLayout(false);
            this.grpBoxStatictics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.GroupBox grpBoxStatictics;
        private System.Windows.Forms.Label lblDec;
        private System.Windows.Forms.Label lblJuly;
        private System.Windows.Forms.Label lblAugust;
        private System.Windows.Forms.Label lblSept;
        private System.Windows.Forms.Label lblOct;
        private System.Windows.Forms.Label lblNov;
        private System.Windows.Forms.Label lblJune;
        private System.Windows.Forms.Label lblMay;
        private System.Windows.Forms.Label lblMarch;
        private System.Windows.Forms.Label lblApril;
        private System.Windows.Forms.Label lblFeb;
        private System.Windows.Forms.Label lblJan;
        private System.Windows.Forms.TextBox txtFeb;
        private System.Windows.Forms.TextBox txtMay;
        private System.Windows.Forms.TextBox txtApril;
        private System.Windows.Forms.TextBox txtMarch;
        private System.Windows.Forms.TextBox txtJuly;
        private System.Windows.Forms.TextBox txtAugust;
        private System.Windows.Forms.TextBox txtSeptember;
        private System.Windows.Forms.TextBox txtOct;
        private System.Windows.Forms.TextBox txtNov;
        private System.Windows.Forms.TextBox txtDec;
        private System.Windows.Forms.TextBox txtJune;
        private System.Windows.Forms.TextBox txtJan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}