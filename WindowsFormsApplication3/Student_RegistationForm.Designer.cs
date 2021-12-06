namespace WindowsFormsApplication3
{
    partial class Student_RegistationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.RegistationGV = new System.Windows.Forms.DataGridView();
            this.Upload = new System.Windows.Forms.Button();
            this.Gap = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.prev_collage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.female_rb = new System.Windows.Forms.RadioButton();
            this.male_rb = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.Class = new System.Windows.Forms.ComboBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Full_Name = new System.Windows.Forms.TextBox();
            this.Fees = new System.Windows.Forms.TextBox();
            this.Mobile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.division = new System.Windows.Forms.ComboBox();
            this.academic_year = new System.Windows.Forms.ComboBox();
            this.changeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.school_DatabaseDataSet1 = new WindowsFormsApplication3.school_DatabaseDataSet1();
            this.label15 = new System.Windows.Forms.Label();
            this.transport = new System.Windows.Forms.ComboBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.reg_no = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Medium = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Mother = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.change_TableTableAdapter = new WindowsFormsApplication3.school_DatabaseDataSet1TableAdapters.Change_TableTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegistationGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_DatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.Searchbutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchText);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(29, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 49);
            this.panel1.TabIndex = 120;
            // 
            // Searchbutton
            // 
            this.Searchbutton.Image = global::WindowsFormsApplication3.Properties.Resources.SAVE_20211114_134720;
            this.Searchbutton.Location = new System.Drawing.Point(1041, 7);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(75, 29);
            this.Searchbutton.TabIndex = 183;
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(863, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 133;
            this.label1.Text = "Rg_no";
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.Location = new System.Drawing.Point(935, 7);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(100, 27);
            this.searchText.TabIndex = 132;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(371, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(239, 27);
            this.label11.TabIndex = 0;
            this.label11.Text = "Student Registation Page";
            // 
            // RegistationGV
            // 
            this.RegistationGV.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.RegistationGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RegistationGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistationGV.Location = new System.Drawing.Point(29, 82);
            this.RegistationGV.Name = "RegistationGV";
            this.RegistationGV.ReadOnly = true;
            this.RegistationGV.RowTemplate.Height = 24;
            this.RegistationGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RegistationGV.Size = new System.Drawing.Size(1123, 211);
            this.RegistationGV.TabIndex = 119;
            this.RegistationGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RegistationGV_CellContentClick);
            // 
            // Upload
            // 
            this.Upload.BackColor = System.Drawing.Color.LimeGreen;
            this.Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload.Location = new System.Drawing.Point(1017, 493);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(135, 41);
            this.Upload.TabIndex = 118;
            this.Upload.Text = "select image";
            this.Upload.UseVisualStyleBackColor = false;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // Gap
            // 
            this.Gap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gap.FormattingEnabled = true;
            this.Gap.Items.AddRange(new object[] {
            "no",
            "one year",
            "two year"});
            this.Gap.Location = new System.Drawing.Point(851, 517);
            this.Gap.Name = "Gap";
            this.Gap.Size = new System.Drawing.Size(121, 28);
            this.Gap.TabIndex = 116;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(762, 517);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 115;
            this.label10.Text = "Gap";
            // 
            // prev_collage
            // 
            this.prev_collage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_collage.Location = new System.Drawing.Point(167, 422);
            this.prev_collage.MaxLength = 150;
            this.prev_collage.Name = "prev_collage";
            this.prev_collage.Size = new System.Drawing.Size(805, 27);
            this.prev_collage.TabIndex = 114;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 113;
            this.label9.Text = "Prev Collage";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker1.Location = new System.Drawing.Point(462, 473);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.DateTimePicker1.TabIndex = 112;
            // 
            // female_rb
            // 
            this.female_rb.AutoSize = true;
            this.female_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female_rb.Location = new System.Drawing.Point(876, 560);
            this.female_rb.Name = "female_rb";
            this.female_rb.Size = new System.Drawing.Size(85, 24);
            this.female_rb.TabIndex = 111;
            this.female_rb.Text = "Female";
            this.female_rb.UseVisualStyleBackColor = true;
            // 
            // male_rb
            // 
            this.male_rb.AutoSize = true;
            this.male_rb.Checked = true;
            this.male_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_rb.Location = new System.Drawing.Point(796, 560);
            this.male_rb.Name = "male_rb";
            this.male_rb.Size = new System.Drawing.Size(66, 24);
            this.male_rb.TabIndex = 110;
            this.male_rb.TabStop = true;
            this.male_rb.Text = "Male";
            this.male_rb.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(734, 562);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 20);
            this.label12.TabIndex = 109;
            this.label12.Text = "Gender";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Blue;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(870, 599);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(102, 47);
            this.submit.TabIndex = 108;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Class
            // 
            this.Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.FormattingEnabled = true;
            this.Class.Items.AddRange(new object[] {
            "bca",
            "bcs",
            "mca",
            "mcs"});
            this.Class.Location = new System.Drawing.Point(167, 509);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(123, 28);
            this.Class.TabIndex = 107;
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(167, 387);
            this.Address.MaxLength = 200;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(805, 27);
            this.Address.TabIndex = 106;
            // 
            // Full_Name
            // 
            this.Full_Name.BackColor = System.Drawing.Color.White;
            this.Full_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Full_Name.Location = new System.Drawing.Point(337, 310);
            this.Full_Name.MaxLength = 60;
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.Size = new System.Drawing.Size(635, 27);
            this.Full_Name.TabIndex = 104;
            // 
            // Fees
            // 
            this.Fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fees.Location = new System.Drawing.Point(167, 599);
            this.Fees.MaxLength = 10;
            this.Fees.Name = "Fees";
            this.Fees.Size = new System.Drawing.Size(123, 27);
            this.Fees.TabIndex = 102;
            // 
            // Mobile
            // 
            this.Mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mobile.Location = new System.Drawing.Point(167, 473);
            this.Mobile.MaxLength = 10;
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(123, 27);
            this.Mobile.TabIndex = 101;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(90, 517);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 100;
            this.label8.Text = "Class";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 599);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 99;
            this.label7.Text = "Fees";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 98;
            this.label6.Text = "Birth Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 96;
            this.label4.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 94;
            this.label2.Text = "Full Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(382, 560);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 20);
            this.label14.TabIndex = 122;
            this.label14.Text = "Academic Year";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(435, 522);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 121;
            this.label13.Text = "Division";
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.FormattingEnabled = true;
            this.division.Items.AddRange(new object[] {
            "1st year",
            "2nd year",
            "3rd year"});
            this.division.Location = new System.Drawing.Point(541, 514);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(121, 28);
            this.division.TabIndex = 123;
            // 
            // academic_year
            // 
            this.academic_year.DataSource = this.changeTableBindingSource;
            this.academic_year.DisplayMember = "Academic_Year";
            this.academic_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.academic_year.FormattingEnabled = true;
            this.academic_year.Location = new System.Drawing.Point(541, 552);
            this.academic_year.Name = "academic_year";
            this.academic_year.Size = new System.Drawing.Size(121, 28);
            this.academic_year.TabIndex = 124;
            this.academic_year.ValueMember = "Academic_Year";
            // 
            // changeTableBindingSource
            // 
            this.changeTableBindingSource.DataMember = "Change_Table";
            this.changeTableBindingSource.DataSource = this.school_DatabaseDataSet1;
            // 
            // school_DatabaseDataSet1
            // 
            this.school_DatabaseDataSet1.DataSetName = "school_DatabaseDataSet1";
            this.school_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(58, 560);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 20);
            this.label15.TabIndex = 125;
            this.label15.Text = "Transport";
            // 
            // transport
            // 
            this.transport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transport.FormattingEnabled = true;
            this.transport.Items.AddRange(new object[] {
            "Bus",
            "Bike",
            "Hostel"});
            this.transport.Location = new System.Drawing.Point(167, 556);
            this.transport.Name = "transport";
            this.transport.Size = new System.Drawing.Size(121, 28);
            this.transport.TabIndex = 126;
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.DarkGray;
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(485, 601);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(91, 45);
            this.clear_button.TabIndex = 127;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.LightCoral;
            this.update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(613, 601);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(96, 45);
            this.update_button.TabIndex = 128;
            this.update_button.Text = "update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Red;
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Location = new System.Drawing.Point(715, 601);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(101, 45);
            this.delete_button.TabIndex = 129;
            this.delete_button.Text = "delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(38, 341);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 20);
            this.label16.TabIndex = 130;
            this.label16.Text = "RG_NO";
            // 
            // reg_no
            // 
            this.reg_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_no.Location = new System.Drawing.Point(128, 341);
            this.reg_no.MaxLength = 10;
            this.reg_no.Name = "reg_no";
            this.reg_no.Size = new System.Drawing.Size(74, 27);
            this.reg_no.TabIndex = 131;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(1061, 58);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(91, 28);
            this.RefreshButton.TabIndex = 132;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 137;
            this.label5.Text = "Mobile";
            // 
            // Medium
            // 
            this.Medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medium.FormattingEnabled = true;
            this.Medium.Items.AddRange(new object[] {
            "English",
            "Marathi",
            "Hindi"});
            this.Medium.Location = new System.Drawing.Point(851, 480);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(121, 28);
            this.Medium.TabIndex = 139;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(751, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 138;
            this.label3.Text = "Medium";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1026, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 117;
            this.pictureBox1.TabStop = false;
            // 
            // Mother
            // 
            this.Mother.BackColor = System.Drawing.Color.White;
            this.Mother.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mother.Location = new System.Drawing.Point(337, 351);
            this.Mother.MaxLength = 150;
            this.Mother.Name = "Mother";
            this.Mother.Size = new System.Drawing.Size(635, 27);
            this.Mother.TabIndex = 141;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(241, 354);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 20);
            this.label17.TabIndex = 140;
            this.label17.Text = "Mother";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(354, 65);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(48, 17);
            this.Result.TabIndex = 142;
            this.Result.Text = "Result";
            // 
            // change_TableTableAdapter
            // 
            this.change_TableTableAdapter.ClearBeforeFill = true;
            // 
            // Student_RegistationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1276, 706);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Mother);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Medium);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.reg_no);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.transport);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.academic_year);
            this.Controls.Add(this.division);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RegistationGV);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Gap);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.prev_collage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.female_rb);
            this.Controls.Add(this.male_rb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Full_Name);
            this.Controls.Add(this.Fees);
            this.Controls.Add(this.Mobile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student_RegistationForm";
            this.Load += new System.EventHandler(this.Student_RegistationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegistationGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_DatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView RegistationGV;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Gap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox prev_collage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.RadioButton female_rb;
        private System.Windows.Forms.RadioButton male_rb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Full_Name;
        private System.Windows.Forms.TextBox Fees;
        private System.Windows.Forms.TextBox Mobile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox transport;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox reg_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox Class;
        public System.Windows.Forms.ComboBox division;
        public System.Windows.Forms.ComboBox academic_year;
        public System.Windows.Forms.ComboBox Medium;
        private System.Windows.Forms.TextBox Mother;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Label Result;
        private school_DatabaseDataSet1 school_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource changeTableBindingSource;
        private school_DatabaseDataSet1TableAdapters.Change_TableTableAdapter change_TableTableAdapter;
    }
}