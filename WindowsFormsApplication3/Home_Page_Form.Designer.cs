namespace WindowsFormsApplication3
{
    partial class Home_Page_Form
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
            this.reg_no = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Full_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HomedataGridView = new System.Windows.Forms.DataGridView();
            this.FeePane = new System.Windows.Forms.Panel();
            this.YourFee = new System.Windows.Forms.TextBox();
            this.YourFee_Label = new System.Windows.Forms.Label();
            this.PaidFee = new System.Windows.Forms.TextBox();
            this.PaidFeeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Fee = new System.Windows.Forms.TextBox();
            this.Pending_Fee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.searchReg = new System.Windows.Forms.Button();
            this.searchName = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.academic_year = new System.Windows.Forms.ComboBox();
            this.changeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.school_DatabaseDataSet2 = new WindowsFormsApplication3.school_DatabaseDataSet2();
            this.label14 = new System.Windows.Forms.Label();
            this.change_TableTableAdapter = new WindowsFormsApplication3.school_DatabaseDataSet2TableAdapters.Change_TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HomedataGridView)).BeginInit();
            this.FeePane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_DatabaseDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // reg_no
            // 
            this.reg_no.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_no.Location = new System.Drawing.Point(106, 20);
            this.reg_no.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reg_no.Name = "reg_no";
            this.reg_no.Size = new System.Drawing.Size(74, 33);
            this.reg_no.TabIndex = 136;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(25, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 19);
            this.label16.TabIndex = 135;
            this.label16.Text = "RG_NO";
            // 
            // Full_Name
            // 
            this.Full_Name.BackColor = System.Drawing.Color.White;
            this.Full_Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Full_Name.Location = new System.Drawing.Point(106, 64);
            this.Full_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.Size = new System.Drawing.Size(455, 33);
            this.Full_Name.TabIndex = 133;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 132;
            this.label2.Text = "Full Name";
            // 
            // HomedataGridView
            // 
            this.HomedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HomedataGridView.Location = new System.Drawing.Point(33, 106);
            this.HomedataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HomedataGridView.Name = "HomedataGridView";
            this.HomedataGridView.ReadOnly = true;
            this.HomedataGridView.RowTemplate.Height = 24;
            this.HomedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HomedataGridView.Size = new System.Drawing.Size(844, 99);
            this.HomedataGridView.TabIndex = 137;
            this.HomedataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HomedataGridView_CellContentClick);
            // 
            // FeePane
            // 
            this.FeePane.BackColor = System.Drawing.Color.Black;
            this.FeePane.Controls.Add(this.YourFee);
            this.FeePane.Controls.Add(this.YourFee_Label);
            this.FeePane.Controls.Add(this.PaidFee);
            this.FeePane.Controls.Add(this.PaidFeeLabel);
            this.FeePane.Controls.Add(this.label3);
            this.FeePane.Controls.Add(this.Add_Button);
            this.FeePane.Controls.Add(this.Fee);
            this.FeePane.Controls.Add(this.Pending_Fee);
            this.FeePane.Controls.Add(this.label1);
            this.FeePane.Location = new System.Drawing.Point(508, 223);
            this.FeePane.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FeePane.Name = "FeePane";
            this.FeePane.Size = new System.Drawing.Size(294, 279);
            this.FeePane.TabIndex = 139;
            // 
            // YourFee
            // 
            this.YourFee.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourFee.Location = new System.Drawing.Point(153, 23);
            this.YourFee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.YourFee.Name = "YourFee";
            this.YourFee.ReadOnly = true;
            this.YourFee.Size = new System.Drawing.Size(115, 33);
            this.YourFee.TabIndex = 146;
            // 
            // YourFee_Label
            // 
            this.YourFee_Label.AutoSize = true;
            this.YourFee_Label.BackColor = System.Drawing.Color.RosyBrown;
            this.YourFee_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourFee_Label.Location = new System.Drawing.Point(24, 28);
            this.YourFee_Label.Name = "YourFee_Label";
            this.YourFee_Label.Size = new System.Drawing.Size(117, 25);
            this.YourFee_Label.TabIndex = 145;
            this.YourFee_Label.Text = "     Your Fee";
            // 
            // PaidFee
            // 
            this.PaidFee.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidFee.Location = new System.Drawing.Point(153, 74);
            this.PaidFee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PaidFee.Name = "PaidFee";
            this.PaidFee.ReadOnly = true;
            this.PaidFee.Size = new System.Drawing.Size(115, 33);
            this.PaidFee.TabIndex = 144;
            // 
            // PaidFeeLabel
            // 
            this.PaidFeeLabel.AutoSize = true;
            this.PaidFeeLabel.BackColor = System.Drawing.Color.White;
            this.PaidFeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidFeeLabel.Location = new System.Drawing.Point(24, 82);
            this.PaidFeeLabel.Name = "PaidFeeLabel";
            this.PaidFeeLabel.Size = new System.Drawing.Size(115, 25);
            this.PaidFeeLabel.TabIndex = 143;
            this.PaidFeeLabel.Text = "     Paid Fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LimeGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 141;
            this.label3.Text = "             Fee";
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.Color.Blue;
            this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.ForeColor = System.Drawing.Color.White;
            this.Add_Button.Location = new System.Drawing.Point(80, 204);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(124, 55);
            this.Add_Button.TabIndex = 141;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Fee
            // 
            this.Fee.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fee.Location = new System.Drawing.Point(153, 172);
            this.Fee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Fee.Name = "Fee";
            this.Fee.Size = new System.Drawing.Size(115, 33);
            this.Fee.TabIndex = 142;
            // 
            // Pending_Fee
            // 
            this.Pending_Fee.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pending_Fee.Location = new System.Drawing.Point(153, 124);
            this.Pending_Fee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pending_Fee.Name = "Pending_Fee";
            this.Pending_Fee.ReadOnly = true;
            this.Pending_Fee.Size = new System.Drawing.Size(115, 33);
            this.Pending_Fee.TabIndex = 141;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pending Fee";
            // 
            // Photo
            // 
            this.Photo.Location = new System.Drawing.Point(94, 223);
            this.Photo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(251, 226);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo.TabIndex = 140;
            this.Photo.TabStop = false;
            // 
            // searchReg
            // 
            this.searchReg.BackColor = System.Drawing.Color.Blue;
            this.searchReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchReg.ForeColor = System.Drawing.Color.White;
            this.searchReg.Location = new System.Drawing.Point(202, 15);
            this.searchReg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchReg.Name = "searchReg";
            this.searchReg.Size = new System.Drawing.Size(84, 33);
            this.searchReg.TabIndex = 142;
            this.searchReg.Text = "Search";
            this.searchReg.UseVisualStyleBackColor = false;
            this.searchReg.Click += new System.EventHandler(this.searchReg_Click);
            // 
            // searchName
            // 
            this.searchName.BackColor = System.Drawing.Color.Blue;
            this.searchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchName.ForeColor = System.Drawing.Color.White;
            this.searchName.Location = new System.Drawing.Point(808, 57);
            this.searchName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(87, 33);
            this.searchName.TabIndex = 143;
            this.searchName.Text = "Search";
            this.searchName.UseVisualStyleBackColor = false;
            this.searchName.Click += new System.EventHandler(this.searchName_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 144;
            this.label4.Text = "Student search";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.Location = new System.Drawing.Point(88, 470);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(111, 32);
            this.Name_label.TabIndex = 145;
            this.Name_label.Text = "Name :";
            // 
            // academic_year
            // 
            this.academic_year.DataSource = this.changeTableBindingSource;
            this.academic_year.DisplayMember = "Academic_Year";
            this.academic_year.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.academic_year.FormattingEnabled = true;
            this.academic_year.Location = new System.Drawing.Point(681, 61);
            this.academic_year.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.academic_year.Name = "academic_year";
            this.academic_year.Size = new System.Drawing.Size(121, 35);
            this.academic_year.TabIndex = 147;
            this.academic_year.ValueMember = "Academic_Year";
            // 
            // changeTableBindingSource
            // 
            this.changeTableBindingSource.DataMember = "Change_Table";
            this.changeTableBindingSource.DataSource = this.school_DatabaseDataSet2;
            // 
            // school_DatabaseDataSet2
            // 
            this.school_DatabaseDataSet2.DataSetName = "school_DatabaseDataSet2";
            this.school_DatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(567, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 19);
            this.label14.TabIndex = 146;
            this.label14.Text = "Academic Year";
            // 
            // change_TableTableAdapter
            // 
            this.change_TableTableAdapter.ClearBeforeFill = true;
            // 
            // Home_Page_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.about;
            this.ClientSize = new System.Drawing.Size(1088, 608);
            this.Controls.Add(this.academic_year);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.searchReg);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.FeePane);
            this.Controls.Add(this.HomedataGridView);
            this.Controls.Add(this.reg_no);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Full_Name);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Home_Page_Form";
            this.Text = "Home_Page_Form";
            this.Load += new System.EventHandler(this.Home_Page_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HomedataGridView)).EndInit();
            this.FeePane.ResumeLayout(false);
            this.FeePane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_DatabaseDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reg_no;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Full_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView HomedataGridView;
        private System.Windows.Forms.Panel FeePane;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Fee;
        private System.Windows.Forms.TextBox Pending_Fee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button searchReg;
        private System.Windows.Forms.Button searchName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Name_label;
        public System.Windows.Forms.ComboBox academic_year;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox YourFee;
        private System.Windows.Forms.Label YourFee_Label;
        private System.Windows.Forms.TextBox PaidFee;
        private System.Windows.Forms.Label PaidFeeLabel;
        private school_DatabaseDataSet2 school_DatabaseDataSet2;
        private System.Windows.Forms.BindingSource changeTableBindingSource;
        private school_DatabaseDataSet2TableAdapters.Change_TableTableAdapter change_TableTableAdapter;
    }
}