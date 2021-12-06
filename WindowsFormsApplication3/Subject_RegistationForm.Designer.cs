namespace WindowsFormsApplication3
{
    partial class Subject_RegistationForm
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
            this.subjectGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Subject_Code = new System.Windows.Forms.TextBox();
            this.Subject_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Teacher_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Qualified = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RG_NO = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchClass = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.subjectGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // subjectGridView
            // 
            this.subjectGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subjectGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectGridView.Location = new System.Drawing.Point(45, 110);
            this.subjectGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subjectGridView.MultiSelect = false;
            this.subjectGridView.Name = "subjectGridView";
            this.subjectGridView.ReadOnly = true;
            this.subjectGridView.RowTemplate.Height = 24;
            this.subjectGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectGridView.Size = new System.Drawing.Size(815, 207);
            this.subjectGridView.TabIndex = 0;
            this.subjectGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject Code";
            // 
            // Subject_Code
            // 
            this.Subject_Code.Location = new System.Drawing.Point(623, 324);
            this.Subject_Code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Subject_Code.Name = "Subject_Code";
            this.Subject_Code.Size = new System.Drawing.Size(236, 28);
            this.Subject_Code.TabIndex = 2;
            // 
            // Subject_Name
            // 
            this.Subject_Name.Location = new System.Drawing.Point(186, 361);
            this.Subject_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Subject_Name.Name = "Subject_Name";
            this.Subject_Name.Size = new System.Drawing.Size(673, 28);
            this.Subject_Name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject Name";
            // 
            // Teacher_Name
            // 
            this.Teacher_Name.Location = new System.Drawing.Point(186, 394);
            this.Teacher_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Teacher_Name.Name = "Teacher_Name";
            this.Teacher_Name.Size = new System.Drawing.Size(673, 28);
            this.Teacher_Name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Teacher Full Name";
            // 
            // Qualified
            // 
            this.Qualified.Location = new System.Drawing.Point(182, 434);
            this.Qualified.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Qualified.Name = "Qualified";
            this.Qualified.Size = new System.Drawing.Size(140, 28);
            this.Qualified.TabIndex = 162;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 161;
            this.label4.Text = "QualiFied";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 25);
            this.label5.TabIndex = 163;
            this.label5.Text = "Subject Registation Page";
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.DarkGray;
            this.clear_button.Location = new System.Drawing.Point(183, 482);
            this.clear_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(100, 41);
            this.clear_button.TabIndex = 165;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Blue;
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(705, 479);
            this.submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(127, 44);
            this.submit.TabIndex = 164;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // division
            // 
            this.division.FormattingEnabled = true;
            this.division.Items.AddRange(new object[] {
            "1st year",
            "2nd year",
            "3rd year"});
            this.division.Location = new System.Drawing.Point(705, 430);
            this.division.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(151, 30);
            this.division.TabIndex = 172;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(608, 438);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 24);
            this.label13.TabIndex = 171;
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
            this.Class.Location = new System.Drawing.Point(422, 434);
            this.Class.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(151, 30);
            this.Class.TabIndex = 169;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 24);
            this.label8.TabIndex = 168;
            this.label8.Text = "Class";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 175;
            this.label6.Text = "RG NO";
            // 
            // RG_NO
            // 
            this.RG_NO.Location = new System.Drawing.Point(186, 324);
            this.RG_NO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RG_NO.Name = "RG_NO";
            this.RG_NO.Size = new System.Drawing.Size(124, 28);
            this.RG_NO.TabIndex = 176;
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.LightCoral;
            this.update_button.Location = new System.Drawing.Point(363, 482);
            this.update_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(93, 41);
            this.update_button.TabIndex = 178;
            this.update_button.Text = "update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click_1);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(517, 479);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(127, 44);
            this.deleteButton.TabIndex = 179;
            this.deleteButton.Text = "delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // searchClass
            // 
            this.searchClass.FormattingEnabled = true;
            this.searchClass.Items.AddRange(new object[] {
            "bca",
            "bcs",
            "mca",
            "mcs"});
            this.searchClass.Location = new System.Drawing.Point(544, 16);
            this.searchClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchClass.Name = "searchClass";
            this.searchClass.Size = new System.Drawing.Size(151, 30);
            this.searchClass.TabIndex = 180;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.Controls.Add(this.Searchbutton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.searchClass);
            this.panel1.Location = new System.Drawing.Point(36, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 63);
            this.panel1.TabIndex = 181;
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(712, 16);
            this.Searchbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(93, 32);
            this.Searchbutton.TabIndex = 182;
            this.Searchbutton.Text = "search";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click_1);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(161, 75);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(62, 24);
            this.Result.TabIndex = 182;
            this.Result.Text = "Result";
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.DarkBlue;
            this.Refresh.ForeColor = System.Drawing.Color.White;
            this.Refresh.Location = new System.Drawing.Point(776, 75);
            this.Refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(83, 38);
            this.Refresh.TabIndex = 183;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Subject_RegistationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1157, 695);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.RG_NO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.division);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.Qualified);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Teacher_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Subject_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Subject_Code);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjectGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Subject_RegistationForm";
            this.Text = "SubjectRegistationForm";
            this.Load += new System.EventHandler(this.Subject_RegistationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView subjectGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Subject_Code;
        private System.Windows.Forms.TextBox Subject_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Teacher_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Qualified;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RG_NO;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox division;
        public System.Windows.Forms.ComboBox Class;
        public System.Windows.Forms.ComboBox searchClass;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Refresh;
    }
}