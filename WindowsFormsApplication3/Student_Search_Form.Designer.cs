namespace WindowsFormsApplication3
{
    partial class Student_Search_Form
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
            this.label8 = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchPendingFee = new System.Windows.Forms.Button();
            this.AcademicYearPendingFee = new System.Windows.Forms.ComboBox();
            this.changeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.school_DatabaseDataSet = new WindowsFormsApplication3.school_DatabaseDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.DivisionPendingFee = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClassPendingFee = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelsearchS3 = new System.Windows.Forms.Panel();
            this.search2 = new System.Windows.Forms.Button();
            this.academic_year2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.search1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.transport = new System.Windows.Forms.ComboBox();
            this.academic_year1 = new System.Windows.Forms.ComboBox();
            this.panelsearchS2 = new System.Windows.Forms.Label();
            this.panelsearchS1 = new System.Windows.Forms.Panel();
            this.SearchSButton = new System.Windows.Forms.Button();
            this.academic_year = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.division = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.ComboBox();
            this.SearchGridView = new System.Windows.Forms.DataGridView();
            this.result = new System.Windows.Forms.Label();
            this.result1 = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.change_TableTableAdapter = new WindowsFormsApplication3.school_DatabaseDataSetTableAdapters.Change_TableTableAdapter();
            this.searchPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_DatabaseDataSet)).BeginInit();
            this.panelsearchS3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelsearchS1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 18);
            this.label8.TabIndex = 125;
            this.label8.Text = "Class";
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.searchPanel.Controls.Add(this.label1);
            this.searchPanel.Location = new System.Drawing.Point(27, 5);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(864, 38);
            this.searchPanel.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(343, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Search Page";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelsearchS3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelsearchS1);
            this.panel1.Location = new System.Drawing.Point(27, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 231);
            this.panel1.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.SearchPendingFee);
            this.panel3.Controls.Add(this.AcademicYearPendingFee);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.DivisionPendingFee);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.ClassPendingFee);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(3, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(850, 52);
            this.panel3.TabIndex = 147;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Location = new System.Drawing.Point(253, -3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 18);
            this.label6.TabIndex = 132;
            this.label6.Text = "Search Pending Fee Student";
            // 
            // SearchPendingFee
            // 
            this.SearchPendingFee.BackColor = System.Drawing.Color.Blue;
            this.SearchPendingFee.Location = new System.Drawing.Point(719, 12);
            this.SearchPendingFee.Name = "SearchPendingFee";
            this.SearchPendingFee.Size = new System.Drawing.Size(122, 32);
            this.SearchPendingFee.TabIndex = 131;
            this.SearchPendingFee.Text = "Search";
            this.SearchPendingFee.UseVisualStyleBackColor = false;
            this.SearchPendingFee.Click += new System.EventHandler(this.SearchPendingFee_Click);
            // 
            // AcademicYearPendingFee
            // 
            this.AcademicYearPendingFee.DataSource = this.changeTableBindingSource;
            this.AcademicYearPendingFee.DisplayMember = "Academic_Year";
            this.AcademicYearPendingFee.FormattingEnabled = true;
            this.AcademicYearPendingFee.Location = new System.Drawing.Point(548, 13);
            this.AcademicYearPendingFee.Margin = new System.Windows.Forms.Padding(2);
            this.AcademicYearPendingFee.Name = "AcademicYearPendingFee";
            this.AcademicYearPendingFee.Size = new System.Drawing.Size(151, 26);
            this.AcademicYearPendingFee.TabIndex = 130;
            this.AcademicYearPendingFee.ValueMember = "Academic_Year";
            // 
            // changeTableBindingSource
            // 
            this.changeTableBindingSource.DataMember = "Change_Table";
            this.changeTableBindingSource.DataSource = this.school_DatabaseDataSet;
            // 
            // school_DatabaseDataSet
            // 
            this.school_DatabaseDataSet.DataSetName = "school_DatabaseDataSet";
            this.school_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 128;
            this.label2.Text = "Academic Year";
            // 
            // DivisionPendingFee
            // 
            this.DivisionPendingFee.FormattingEnabled = true;
            this.DivisionPendingFee.Items.AddRange(new object[] {
            "1st year",
            "2nd year",
            "3rd year"});
            this.DivisionPendingFee.Location = new System.Drawing.Point(262, 16);
            this.DivisionPendingFee.Margin = new System.Windows.Forms.Padding(2);
            this.DivisionPendingFee.Name = "DivisionPendingFee";
            this.DivisionPendingFee.Size = new System.Drawing.Size(144, 26);
            this.DivisionPendingFee.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 127;
            this.label3.Text = "Division";
            // 
            // ClassPendingFee
            // 
            this.ClassPendingFee.FormattingEnabled = true;
            this.ClassPendingFee.Items.AddRange(new object[] {
            "bca",
            "bcs",
            "mca",
            "mcs"});
            this.ClassPendingFee.Location = new System.Drawing.Point(67, 16);
            this.ClassPendingFee.Margin = new System.Windows.Forms.Padding(2);
            this.ClassPendingFee.Name = "ClassPendingFee";
            this.ClassPendingFee.Size = new System.Drawing.Size(132, 26);
            this.ClassPendingFee.TabIndex = 126;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 125;
            this.label4.Text = "Class";
            // 
            // panelsearchS3
            // 
            this.panelsearchS3.BackColor = System.Drawing.Color.DarkCyan;
            this.panelsearchS3.Controls.Add(this.search2);
            this.panelsearchS3.Controls.Add(this.academic_year2);
            this.panelsearchS3.Controls.Add(this.label5);
            this.panelsearchS3.Location = new System.Drawing.Point(0, 182);
            this.panelsearchS3.Name = "panelsearchS3";
            this.panelsearchS3.Size = new System.Drawing.Size(850, 45);
            this.panelsearchS3.TabIndex = 146;
            // 
            // search2
            // 
            this.search2.BackColor = System.Drawing.Color.Blue;
            this.search2.Location = new System.Drawing.Point(719, 10);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(122, 32);
            this.search2.TabIndex = 144;
            this.search2.Text = "Search";
            this.search2.UseVisualStyleBackColor = false;
            this.search2.Click += new System.EventHandler(this.search2_Click);
            // 
            // academic_year2
            // 
            this.academic_year2.DataSource = this.changeTableBindingSource;
            this.academic_year2.DisplayMember = "Academic_Year";
            this.academic_year2.FormattingEnabled = true;
            this.academic_year2.Location = new System.Drawing.Point(548, 10);
            this.academic_year2.Margin = new System.Windows.Forms.Padding(2);
            this.academic_year2.Name = "academic_year2";
            this.academic_year2.Size = new System.Drawing.Size(151, 26);
            this.academic_year2.TabIndex = 143;
            this.academic_year2.ValueMember = "Academic_Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 142;
            this.label5.Text = "Academic Year";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.search1);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.transport);
            this.panel2.Controls.Add(this.academic_year1);
            this.panel2.Controls.Add(this.panelsearchS2);
            this.panel2.Location = new System.Drawing.Point(3, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 45);
            this.panel2.TabIndex = 145;
            // 
            // search1
            // 
            this.search1.BackColor = System.Drawing.Color.Blue;
            this.search1.Location = new System.Drawing.Point(719, 10);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(122, 32);
            this.search1.TabIndex = 144;
            this.search1.Text = "Search";
            this.search1.UseVisualStyleBackColor = false;
            this.search1.Click += new System.EventHandler(this.search1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(191, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 18);
            this.label15.TabIndex = 140;
            this.label15.Text = "Transport";
            // 
            // transport
            // 
            this.transport.FormattingEnabled = true;
            this.transport.Items.AddRange(new object[] {
            "Bus",
            "Bike",
            "Hostel"});
            this.transport.Location = new System.Drawing.Point(262, 12);
            this.transport.Name = "transport";
            this.transport.Size = new System.Drawing.Size(144, 26);
            this.transport.TabIndex = 141;
            // 
            // academic_year1
            // 
            this.academic_year1.DataSource = this.changeTableBindingSource;
            this.academic_year1.DisplayMember = "Academic_Year";
            this.academic_year1.FormattingEnabled = true;
            this.academic_year1.Location = new System.Drawing.Point(548, 10);
            this.academic_year1.Margin = new System.Windows.Forms.Padding(2);
            this.academic_year1.Name = "academic_year1";
            this.academic_year1.Size = new System.Drawing.Size(151, 26);
            this.academic_year1.TabIndex = 143;
            this.academic_year1.ValueMember = "Academic_Year";
            // 
            // panelsearchS2
            // 
            this.panelsearchS2.AutoSize = true;
            this.panelsearchS2.Location = new System.Drawing.Point(437, 18);
            this.panelsearchS2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.panelsearchS2.Name = "panelsearchS2";
            this.panelsearchS2.Size = new System.Drawing.Size(107, 18);
            this.panelsearchS2.TabIndex = 142;
            this.panelsearchS2.Text = "Academic Year";
            // 
            // panelsearchS1
            // 
            this.panelsearchS1.BackColor = System.Drawing.Color.DarkCyan;
            this.panelsearchS1.Controls.Add(this.SearchSButton);
            this.panelsearchS1.Controls.Add(this.academic_year);
            this.panelsearchS1.Controls.Add(this.label14);
            this.panelsearchS1.Controls.Add(this.division);
            this.panelsearchS1.Controls.Add(this.label13);
            this.panelsearchS1.Controls.Add(this.Class);
            this.panelsearchS1.Controls.Add(this.label8);
            this.panelsearchS1.Location = new System.Drawing.Point(3, 15);
            this.panelsearchS1.Name = "panelsearchS1";
            this.panelsearchS1.Size = new System.Drawing.Size(850, 52);
            this.panelsearchS1.TabIndex = 144;
            // 
            // SearchSButton
            // 
            this.SearchSButton.BackColor = System.Drawing.Color.Blue;
            this.SearchSButton.Location = new System.Drawing.Point(719, 12);
            this.SearchSButton.Name = "SearchSButton";
            this.SearchSButton.Size = new System.Drawing.Size(122, 32);
            this.SearchSButton.TabIndex = 131;
            this.SearchSButton.Text = "Search";
            this.SearchSButton.UseVisualStyleBackColor = false;
            this.SearchSButton.Click += new System.EventHandler(this.SearchSButton_Click);
            // 
            // academic_year
            // 
            this.academic_year.DataSource = this.changeTableBindingSource;
            this.academic_year.DisplayMember = "Academic_Year";
            this.academic_year.FormattingEnabled = true;
            this.academic_year.Location = new System.Drawing.Point(548, 13);
            this.academic_year.Margin = new System.Windows.Forms.Padding(2);
            this.academic_year.Name = "academic_year";
            this.academic_year.Size = new System.Drawing.Size(151, 26);
            this.academic_year.TabIndex = 130;
            this.academic_year.ValueMember = "Academic_Year";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(432, 19);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 18);
            this.label14.TabIndex = 128;
            this.label14.Text = "Academic Year";
            // 
            // division
            // 
            this.division.FormattingEnabled = true;
            this.division.Items.AddRange(new object[] {
            "1st year",
            "2nd year",
            "3rd year"});
            this.division.Location = new System.Drawing.Point(262, 16);
            this.division.Margin = new System.Windows.Forms.Padding(2);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(144, 26);
            this.division.TabIndex = 129;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(203, 19);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 18);
            this.label13.TabIndex = 127;
            this.label13.Text = "Division";
            // 
            // Class
            // 
            this.Class.FormattingEnabled = true;
            this.Class.Items.AddRange(new object[] {
            "bca",
            "bcs",
            "mca",
            "mcs"});
            this.Class.Location = new System.Drawing.Point(67, 16);
            this.Class.Margin = new System.Windows.Forms.Padding(2);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(132, 26);
            this.Class.TabIndex = 126;
            // 
            // SearchGridView
            // 
            this.SearchGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SearchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchGridView.Location = new System.Drawing.Point(27, 315);
            this.SearchGridView.Margin = new System.Windows.Forms.Padding(2);
            this.SearchGridView.Name = "SearchGridView";
            this.SearchGridView.ReadOnly = true;
            this.SearchGridView.RowTemplate.Height = 24;
            this.SearchGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchGridView.Size = new System.Drawing.Size(864, 199);
            this.SearchGridView.TabIndex = 26;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(349, 300);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 18);
            this.result.TabIndex = 147;
            // 
            // result1
            // 
            this.result1.AutoSize = true;
            this.result1.Location = new System.Drawing.Point(283, 282);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(66, 18);
            this.result1.TabIndex = 148;
            this.result1.Text = "Reasult :";
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.Crimson;
            this.Refresh.Location = new System.Drawing.Point(816, 284);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 34);
            this.Refresh.TabIndex = 147;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // change_TableTableAdapter
            // 
            this.change_TableTableAdapter.ClearBeforeFill = true;
            // 
            // Student_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 721);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearchGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student_Search";
            this.Text = "SearchForm1";
            this.Load += new System.EventHandler(this.Student_Search_Load);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_DatabaseDataSet)).EndInit();
            this.panelsearchS3.ResumeLayout(false);
            this.panelsearchS3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelsearchS1.ResumeLayout(false);
            this.panelsearchS1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchSButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView SearchGridView;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panelsearchS3;
        private System.Windows.Forms.Button search2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button search1;
        private System.Windows.Forms.Label panelsearchS2;
        private System.Windows.Forms.Panel panelsearchS1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label result1;
        public System.Windows.Forms.ComboBox academic_year;
        public System.Windows.Forms.ComboBox division;
        public System.Windows.Forms.ComboBox Class;
        public System.Windows.Forms.ComboBox transport;
        public System.Windows.Forms.ComboBox academic_year2;
        public System.Windows.Forms.ComboBox academic_year1;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SearchPendingFee;
        public System.Windows.Forms.ComboBox AcademicYearPendingFee;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox DivisionPendingFee;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox ClassPendingFee;
        private System.Windows.Forms.Label label4;
        private school_DatabaseDataSet school_DatabaseDataSet;
        private System.Windows.Forms.BindingSource changeTableBindingSource;
        private school_DatabaseDataSetTableAdapters.Change_TableTableAdapter change_TableTableAdapter;
    }
}