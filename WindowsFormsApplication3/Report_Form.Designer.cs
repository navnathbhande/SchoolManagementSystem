namespace WindowsFormsApplication3
{
    partial class Report_Form
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
            this.Total_Event = new System.Windows.Forms.TextBox();
            this.Total_Event_Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Total_Event_Money = new System.Windows.Forms.TextBox();
            this.Total_Staff_Sallary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Total_Staff = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Total_Girl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Total_Boys = new System.Windows.Forms.TextBox();
            this.Total_Fee = new System.Windows.Forms.TextBox();
            this.YourFee_Label = new System.Windows.Forms.Label();
            this.Total_Paid_Fee = new System.Windows.Forms.TextBox();
            this.PaidFeeLabel = new System.Windows.Forms.Label();
            this.Total_AStudent = new System.Windows.Forms.Label();
            this.Total_Student = new System.Windows.Forms.TextBox();
            this.Total_Pending_Fee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.academic_year = new System.Windows.Forms.ComboBox();
            this.division = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.AcademicYearA = new System.Windows.Forms.ComboBox();
            this.Show_Button_CD = new System.Windows.Forms.Button();
            this.showReportAcademicYear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PanelA = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.Total_Student_CD = new System.Windows.Forms.TextBox();
            this.Total_Girl_CD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Total_Boys_CD = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.school_DatabaseDataSet3 = new WindowsFormsApplication3.school_DatabaseDataSet3();
            this.changeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.change_TableTableAdapter = new WindowsFormsApplication3.school_DatabaseDataSet3TableAdapters.Change_TableTableAdapter();
            this.panel1.SuspendLayout();
            this.PanelA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.school_DatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkViolet;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Total_Event);
            this.panel1.Controls.Add(this.Total_Event_Label);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Total_Event_Money);
            this.panel1.Controls.Add(this.Total_Staff_Sallary);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Total_Staff);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Total_Girl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Total_Boys);
            this.panel1.Controls.Add(this.Total_Fee);
            this.panel1.Controls.Add(this.YourFee_Label);
            this.panel1.Controls.Add(this.Total_Paid_Fee);
            this.panel1.Controls.Add(this.PaidFeeLabel);
            this.panel1.Controls.Add(this.Total_AStudent);
            this.panel1.Controls.Add(this.Total_Student);
            this.panel1.Controls.Add(this.Total_Pending_Fee);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(589, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 581);
            this.panel1.TabIndex = 2;
            // 
            // Total_Event
            // 
            this.Total_Event.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Event.Location = new System.Drawing.Point(220, 482);
            this.Total_Event.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Total_Event.Name = "Total_Event";
            this.Total_Event.ReadOnly = true;
            this.Total_Event.Size = new System.Drawing.Size(115, 33);
            this.Total_Event.TabIndex = 166;
            // 
            // Total_Event_Label
            // 
            this.Total_Event_Label.AutoSize = true;
            this.Total_Event_Label.BackColor = System.Drawing.Color.Brown;
            this.Total_Event_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Event_Label.Location = new System.Drawing.Point(31, 486);
            this.Total_Event_Label.Name = "Total_Event_Label";
            this.Total_Event_Label.Size = new System.Drawing.Size(116, 25);
            this.Total_Event_Label.TabIndex = 165;
            this.Total_Event_Label.Text = "Total Event ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 25);
            this.label7.TabIndex = 163;
            this.label7.Text = "Total Event Money";
            // 
            // Total_Event_Money
            // 
            this.Total_Event_Money.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Event_Money.Location = new System.Drawing.Point(351, 202);
            this.Total_Event_Money.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Total_Event_Money.Name = "Total_Event_Money";
            this.Total_Event_Money.ReadOnly = true;
            this.Total_Event_Money.Size = new System.Drawing.Size(115, 33);
            this.Total_Event_Money.TabIndex = 164;
            // 
            // Total_Staff_Sallary
            // 
            this.Total_Staff_Sallary.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Staff_Sallary.Location = new System.Drawing.Point(351, 249);
            this.Total_Staff_Sallary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Total_Staff_Sallary.Name = "Total_Staff_Sallary";
            this.Total_Staff_Sallary.ReadOnly = true;
            this.Total_Staff_Sallary.Size = new System.Drawing.Size(115, 33);
            this.Total_Staff_Sallary.TabIndex = 162;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Brown;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 530);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 159;
            this.label5.Text = "Total Staff";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 25);
            this.label6.TabIndex = 161;
            this.label6.Text = "Total Staff Salary one Month";
            // 
            // Total_Staff
            // 
            this.Total_Staff.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Staff.Location = new System.Drawing.Point(220, 530);
            this.Total_Staff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Total_Staff.Name = "Total_Staff";
            this.Total_Staff.ReadOnly = true;
            this.Total_Staff.Size = new System.Drawing.Size(115, 33);
            this.Total_Staff.TabIndex = 160;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 157;
            this.label4.Text = "Total Girl";
            // 
            // Total_Girl
            // 
            this.Total_Girl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Girl.Location = new System.Drawing.Point(220, 408);
            this.Total_Girl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Total_Girl.Name = "Total_Girl";
            this.Total_Girl.ReadOnly = true;
            this.Total_Girl.Size = new System.Drawing.Size(115, 33);
            this.Total_Girl.TabIndex = 158;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 155;
            this.label3.Text = "Total Boys";
            // 
            // Total_Boys
            // 
            this.Total_Boys.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Boys.Location = new System.Drawing.Point(220, 360);
            this.Total_Boys.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Total_Boys.Name = "Total_Boys";
            this.Total_Boys.ReadOnly = true;
            this.Total_Boys.Size = new System.Drawing.Size(115, 33);
            this.Total_Boys.TabIndex = 156;
            // 
            // Total_Fee
            // 
            this.Total_Fee.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Fee.Location = new System.Drawing.Point(220, 27);
            this.Total_Fee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Total_Fee.Name = "Total_Fee";
            this.Total_Fee.ReadOnly = true;
            this.Total_Fee.Size = new System.Drawing.Size(115, 33);
            this.Total_Fee.TabIndex = 154;
            // 
            // YourFee_Label
            // 
            this.YourFee_Label.AutoSize = true;
            this.YourFee_Label.BackColor = System.Drawing.Color.RosyBrown;
            this.YourFee_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourFee_Label.Location = new System.Drawing.Point(31, 35);
            this.YourFee_Label.Name = "YourFee_Label";
            this.YourFee_Label.Size = new System.Drawing.Size(100, 25);
            this.YourFee_Label.TabIndex = 153;
            this.YourFee_Label.Text = "Total  Fee";
            // 
            // Total_Paid_Fee
            // 
            this.Total_Paid_Fee.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Paid_Fee.Location = new System.Drawing.Point(220, 80);
            this.Total_Paid_Fee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Total_Paid_Fee.Name = "Total_Paid_Fee";
            this.Total_Paid_Fee.ReadOnly = true;
            this.Total_Paid_Fee.Size = new System.Drawing.Size(115, 33);
            this.Total_Paid_Fee.TabIndex = 152;
            // 
            // PaidFeeLabel
            // 
            this.PaidFeeLabel.AutoSize = true;
            this.PaidFeeLabel.BackColor = System.Drawing.Color.LimeGreen;
            this.PaidFeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidFeeLabel.Location = new System.Drawing.Point(31, 84);
            this.PaidFeeLabel.Name = "PaidFeeLabel";
            this.PaidFeeLabel.Size = new System.Drawing.Size(149, 25);
            this.PaidFeeLabel.TabIndex = 151;
            this.PaidFeeLabel.Text = "  Total Paid Fee";
            // 
            // Total_AStudent
            // 
            this.Total_AStudent.AutoSize = true;
            this.Total_AStudent.BackColor = System.Drawing.Color.Yellow;
            this.Total_AStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_AStudent.Location = new System.Drawing.Point(31, 324);
            this.Total_AStudent.Name = "Total_AStudent";
            this.Total_AStudent.Size = new System.Drawing.Size(129, 25);
            this.Total_AStudent.TabIndex = 148;
            this.Total_AStudent.Text = "Total Student";
            // 
            // Total_Student
            // 
            this.Total_Student.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Student.Location = new System.Drawing.Point(220, 316);
            this.Total_Student.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Total_Student.Name = "Total_Student";
            this.Total_Student.ReadOnly = true;
            this.Total_Student.Size = new System.Drawing.Size(115, 33);
            this.Total_Student.TabIndex = 150;
            // 
            // Total_Pending_Fee
            // 
            this.Total_Pending_Fee.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Pending_Fee.Location = new System.Drawing.Point(220, 134);
            this.Total_Pending_Fee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Total_Pending_Fee.Name = "Total_Pending_Fee";
            this.Total_Pending_Fee.ReadOnly = true;
            this.Total_Pending_Fee.Size = new System.Drawing.Size(115, 33);
            this.Total_Pending_Fee.TabIndex = 149;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 147;
            this.label2.Text = "Total Pending Fee";
            // 
            // academic_year
            // 
            this.academic_year.DataSource = this.changeTableBindingSource;
            this.academic_year.DisplayMember = "Academic_Year";
            this.academic_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.academic_year.FormattingEnabled = true;
            this.academic_year.Location = new System.Drawing.Point(190, 101);
            this.academic_year.Name = "academic_year";
            this.academic_year.Size = new System.Drawing.Size(121, 28);
            this.academic_year.TabIndex = 128;
            this.academic_year.ValueMember = "Academic_Year";
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.FormattingEnabled = true;
            this.division.Items.AddRange(new object[] {
            "1st year",
            "2nd year",
            "3rd year"});
            this.division.Location = new System.Drawing.Point(190, 63);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(121, 28);
            this.division.TabIndex = 127;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(47, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 20);
            this.label14.TabIndex = 126;
            this.label14.Text = "Academic Year";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(91, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 125;
            this.label13.Text = "Division";
            // 
            // AcademicYearA
            // 
            this.AcademicYearA.DataSource = this.changeTableBindingSource;
            this.AcademicYearA.DisplayMember = "Academic_Year";
            this.AcademicYearA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcademicYearA.FormattingEnabled = true;
            this.AcademicYearA.Location = new System.Drawing.Point(811, 17);
            this.AcademicYearA.Name = "AcademicYearA";
            this.AcademicYearA.Size = new System.Drawing.Size(121, 28);
            this.AcademicYearA.TabIndex = 130;
            this.AcademicYearA.ValueMember = "Academic_Year";
            // 
            // Show_Button_CD
            // 
            this.Show_Button_CD.BackColor = System.Drawing.Color.Blue;
            this.Show_Button_CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Button_CD.Location = new System.Drawing.Point(236, 147);
            this.Show_Button_CD.Name = "Show_Button_CD";
            this.Show_Button_CD.Size = new System.Drawing.Size(75, 38);
            this.Show_Button_CD.TabIndex = 131;
            this.Show_Button_CD.Text = "show";
            this.Show_Button_CD.UseVisualStyleBackColor = false;
            this.Show_Button_CD.Click += new System.EventHandler(this.Show_Button_CD_Click);
            // 
            // showReportAcademicYear
            // 
            this.showReportAcademicYear.BackColor = System.Drawing.Color.Blue;
            this.showReportAcademicYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showReportAcademicYear.Location = new System.Drawing.Point(954, 11);
            this.showReportAcademicYear.Name = "showReportAcademicYear";
            this.showReportAcademicYear.Size = new System.Drawing.Size(75, 38);
            this.showReportAcademicYear.TabIndex = 132;
            this.showReportAcademicYear.Text = "show";
            this.showReportAcademicYear.UseVisualStyleBackColor = false;
            this.showReportAcademicYear.Click += new System.EventHandler(this.showReportAcademicYear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(652, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 133;
            this.label1.Text = "Academic Year";
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
            this.Class.Location = new System.Drawing.Point(190, 20);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(123, 28);
            this.Class.TabIndex = 135;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(113, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 134;
            this.label8.Text = "Class";
            // 
            // PanelA
            // 
            this.PanelA.BackColor = System.Drawing.Color.DarkMagenta;
            this.PanelA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelA.Controls.Add(this.label9);
            this.PanelA.Controls.Add(this.Total_Student_CD);
            this.PanelA.Controls.Add(this.Total_Girl_CD);
            this.PanelA.Controls.Add(this.label11);
            this.PanelA.Controls.Add(this.label10);
            this.PanelA.Controls.Add(this.Total_Boys_CD);
            this.PanelA.Location = new System.Drawing.Point(28, 191);
            this.PanelA.Name = "PanelA";
            this.PanelA.Size = new System.Drawing.Size(362, 200);
            this.PanelA.TabIndex = 136;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 25);
            this.label9.TabIndex = 171;
            this.label9.Text = "Total Girl";
            // 
            // Total_Student_CD
            // 
            this.Total_Student_CD.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Student_CD.Location = new System.Drawing.Point(217, 30);
            this.Total_Student_CD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Total_Student_CD.Name = "Total_Student_CD";
            this.Total_Student_CD.ReadOnly = true;
            this.Total_Student_CD.Size = new System.Drawing.Size(115, 33);
            this.Total_Student_CD.TabIndex = 168;
            // 
            // Total_Girl_CD
            // 
            this.Total_Girl_CD.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Girl_CD.Location = new System.Drawing.Point(217, 122);
            this.Total_Girl_CD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Total_Girl_CD.Name = "Total_Girl_CD";
            this.Total_Girl_CD.ReadOnly = true;
            this.Total_Girl_CD.Size = new System.Drawing.Size(115, 33);
            this.Total_Girl_CD.TabIndex = 172;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Yellow;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 25);
            this.label11.TabIndex = 167;
            this.label11.Text = "Total Student";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Yellow;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 25);
            this.label10.TabIndex = 169;
            this.label10.Text = "Total Boys";
            // 
            // Total_Boys_CD
            // 
            this.Total_Boys_CD.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Boys_CD.Location = new System.Drawing.Point(217, 74);
            this.Total_Boys_CD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Total_Boys_CD.Name = "Total_Boys_CD";
            this.Total_Boys_CD.ReadOnly = true;
            this.Total_Boys_CD.Size = new System.Drawing.Size(115, 33);
            this.Total_Boys_CD.TabIndex = 170;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(455, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 617);
            this.panel2.TabIndex = 137;
            // 
            // school_DatabaseDataSet3
            // 
            this.school_DatabaseDataSet3.DataSetName = "school_DatabaseDataSet3";
            this.school_DatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // changeTableBindingSource
            // 
            this.changeTableBindingSource.DataMember = "Change_Table";
            this.changeTableBindingSource.DataSource = this.school_DatabaseDataSet3;
            // 
            // change_TableTableAdapter
            // 
            this.change_TableTableAdapter.ClearBeforeFill = true;
            // 
            // Report_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 790);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelA);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showReportAcademicYear);
            this.Controls.Add(this.Show_Button_CD);
            this.Controls.Add(this.AcademicYearA);
            this.Controls.Add(this.academic_year);
            this.Controls.Add(this.division);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report_Form";
            this.Text = "Report_Form";
            this.Load += new System.EventHandler(this.Report_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelA.ResumeLayout(false);
            this.PanelA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.school_DatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox academic_year;
        public System.Windows.Forms.ComboBox division;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox AcademicYearA;
        private System.Windows.Forms.Button Show_Button_CD;
        private System.Windows.Forms.Button showReportAcademicYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Total_Event_Money;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Total_Staff_Sallary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Total_Staff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Total_Girl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Total_Boys;
        private System.Windows.Forms.TextBox Total_Fee;
        private System.Windows.Forms.Label YourFee_Label;
        private System.Windows.Forms.TextBox Total_Paid_Fee;
        private System.Windows.Forms.Label PaidFeeLabel;
        private System.Windows.Forms.Label Total_AStudent;
        private System.Windows.Forms.TextBox Total_Student;
        private System.Windows.Forms.TextBox Total_Pending_Fee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Total_Event;
        private System.Windows.Forms.Label Total_Event_Label;
        public System.Windows.Forms.ComboBox Class;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel PanelA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Total_Student_CD;
        private System.Windows.Forms.TextBox Total_Girl_CD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Total_Boys_CD;
        private System.Windows.Forms.Panel panel2;
        private school_DatabaseDataSet3 school_DatabaseDataSet3;
        private System.Windows.Forms.BindingSource changeTableBindingSource;
        private school_DatabaseDataSet3TableAdapters.Change_TableTableAdapter change_TableTableAdapter;
    }
}