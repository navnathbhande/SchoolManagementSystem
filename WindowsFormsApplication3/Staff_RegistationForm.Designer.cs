namespace WindowsFormsApplication3
{
    partial class Staff_RegistationForm
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
            this.delete_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.Upload = new System.Windows.Forms.Button();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.female_rb = new System.Windows.Forms.RadioButton();
            this.male_rb = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.TextBox();
            this.Mobile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.reg_no = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Full_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.search_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Qualified = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Expirance = new System.Windows.Forms.ComboBox();
            this.Position = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.Sall = new System.Windows.Forms.TextBox();
            this.StaffdataGridView1 = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Red;
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Location = new System.Drawing.Point(704, 598);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(96, 43);
            this.delete_button.TabIndex = 149;
            this.delete_button.Text = "delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.DarkGray;
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(453, 598);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(104, 43);
            this.clear_button.TabIndex = 147;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // Upload
            // 
            this.Upload.BackColor = System.Drawing.Color.LimeGreen;
            this.Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload.Location = new System.Drawing.Point(963, 467);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(146, 50);
            this.Upload.TabIndex = 146;
            this.Upload.Text = "select image";
            this.Upload.UseVisualStyleBackColor = false;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker1.Location = new System.Drawing.Point(502, 525);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(195, 27);
            this.DateTimePicker1.TabIndex = 144;
            // 
            // female_rb
            // 
            this.female_rb.AutoSize = true;
            this.female_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female_rb.Location = new System.Drawing.Point(266, 530);
            this.female_rb.Name = "female_rb";
            this.female_rb.Size = new System.Drawing.Size(85, 24);
            this.female_rb.TabIndex = 143;
            this.female_rb.Text = "Female";
            this.female_rb.UseVisualStyleBackColor = true;
            // 
            // male_rb
            // 
            this.male_rb.AutoSize = true;
            this.male_rb.Checked = true;
            this.male_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_rb.Location = new System.Drawing.Point(194, 530);
            this.male_rb.Name = "male_rb";
            this.male_rb.Size = new System.Drawing.Size(66, 24);
            this.male_rb.TabIndex = 142;
            this.male_rb.TabStop = true;
            this.male_rb.Text = "Male";
            this.male_rb.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(108, 534);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 20);
            this.label12.TabIndex = 141;
            this.label12.Text = "Gender";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Blue;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(813, 599);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(119, 42);
            this.submit.TabIndex = 140;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(165, 384);
            this.Address.MaxLength = 150;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(760, 27);
            this.Address.TabIndex = 139;
            // 
            // Mobile
            // 
            this.Mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mobile.Location = new System.Drawing.Point(172, 475);
            this.Mobile.MaxLength = 10;
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(111, 27);
            this.Mobile.TabIndex = 138;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 137;
            this.label6.Text = "Birth Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 136;
            this.label5.Text = "Mobile";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 135;
            this.label7.Text = "Location";
            // 
            // reg_no
            // 
            this.reg_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_no.Location = new System.Drawing.Point(165, 334);
            this.reg_no.MaxLength = 10;
            this.reg_no.Name = "reg_no";
            this.reg_no.Size = new System.Drawing.Size(89, 27);
            this.reg_no.TabIndex = 157;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(82, 336);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 20);
            this.label16.TabIndex = 156;
            this.label16.Text = "RG_NO";
            // 
            // Full_Name
            // 
            this.Full_Name.BackColor = System.Drawing.Color.White;
            this.Full_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Full_Name.Location = new System.Drawing.Point(368, 334);
            this.Full_Name.MaxLength = 60;
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.Size = new System.Drawing.Size(557, 27);
            this.Full_Name.TabIndex = 155;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 154;
            this.label2.Text = "Full Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Controls.Add(this.search_Button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchText);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(29, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 47);
            this.panel1.TabIndex = 158;
            // 
            // search_Button
            // 
            this.search_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_Button.Image = global::WindowsFormsApplication3.Properties.Resources.SAVE_20211114_134720;
            this.search_Button.Location = new System.Drawing.Point(1050, 9);
            this.search_Button.Name = "search_Button";
            this.search_Button.Size = new System.Drawing.Size(74, 27);
            this.search_Button.TabIndex = 134;
            this.search_Button.UseVisualStyleBackColor = true;
            this.search_Button.Click += new System.EventHandler(this.search_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(870, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 133;
            this.label1.Text = "Rg_no";
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.Location = new System.Drawing.Point(934, 9);
            this.searchText.MaxLength = 10;
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(95, 27);
            this.searchText.TabIndex = 132;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(351, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(211, 27);
            this.label11.TabIndex = 0;
            this.label11.Text = "Staff Registation page";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 159;
            this.label3.Text = "QualiFied";
            // 
            // Qualified
            // 
            this.Qualified.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qualified.Location = new System.Drawing.Point(165, 430);
            this.Qualified.MaxLength = 150;
            this.Qualified.Name = "Qualified";
            this.Qualified.Size = new System.Drawing.Size(453, 27);
            this.Qualified.TabIndex = 160;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 161;
            this.label4.Text = "Expirance";
            // 
            // Expirance
            // 
            this.Expirance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expirance.FormattingEnabled = true;
            this.Expirance.Items.AddRange(new object[] {
            "no",
            "one year",
            "two year",
            "three year",
            "more"});
            this.Expirance.Location = new System.Drawing.Point(502, 475);
            this.Expirance.Name = "Expirance";
            this.Expirance.Size = new System.Drawing.Size(116, 28);
            this.Expirance.TabIndex = 162;
            // 
            // Position
            // 
            this.Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Position.FormattingEnabled = true;
            this.Position.Items.AddRange(new object[] {
            "prinsiple",
            "hod",
            "teacher",
            "library",
            "puen",
            "security"});
            this.Position.Location = new System.Drawing.Point(809, 472);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(116, 28);
            this.Position.TabIndex = 164;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(722, 475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 165;
            this.label8.Text = "Position";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(731, 525);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 166;
            this.label9.Text = "Sallary";
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(1079, 63);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(88, 27);
            this.RefreshButton.TabIndex = 151;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Sall
            // 
            this.Sall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sall.Location = new System.Drawing.Point(809, 522);
            this.Sall.MaxLength = 10;
            this.Sall.Name = "Sall";
            this.Sall.Size = new System.Drawing.Size(116, 27);
            this.Sall.TabIndex = 167;
            // 
            // StaffdataGridView1
            // 
            this.StaffdataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StaffdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffdataGridView1.Location = new System.Drawing.Point(29, 86);
            this.StaffdataGridView1.Name = "StaffdataGridView1";
            this.StaffdataGridView1.ReadOnly = true;
            this.StaffdataGridView1.RowTemplate.Height = 24;
            this.StaffdataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StaffdataGridView1.Size = new System.Drawing.Size(1138, 227);
            this.StaffdataGridView1.TabIndex = 168;
            this.StaffdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffdataGridView1_CellContentClick_1);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Salmon;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(581, 598);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(103, 43);
            this.update.TabIndex = 169;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(194, 63);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(48, 17);
            this.Result.TabIndex = 170;
            this.Result.Text = "Result";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(976, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 145;
            this.pictureBox1.TabStop = false;
            // 
            // Staff_RegistationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1165, 653);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.update);
            this.Controls.Add(this.StaffdataGridView1);
            this.Controls.Add(this.Sall);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.Expirance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Qualified);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reg_no);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Full_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.female_rb);
            this.Controls.Add(this.male_rb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Mobile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff_RegistationForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Staff_RegistationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.RadioButton female_rb;
        private System.Windows.Forms.RadioButton male_rb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Mobile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox reg_no;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Full_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Qualified;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Expirance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Sall;
        private System.Windows.Forms.Button search_Button;
        private System.Windows.Forms.DataGridView StaffdataGridView1;
        private System.Windows.Forms.Button update;
        public System.Windows.Forms.ComboBox Position;
        private System.Windows.Forms.Label Result;
    }
}