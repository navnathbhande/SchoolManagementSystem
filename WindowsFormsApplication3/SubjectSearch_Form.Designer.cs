namespace WindowsFormsApplication3
{
    partial class SubjectSearch_Form
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
            this.division = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.search1 = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.subjectSearchdataGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectSearchdataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // division
            // 
            this.division.FormattingEnabled = true;
            this.division.Items.AddRange(new object[] {
            "1st year",
            "2nd year",
            "3rd year"});
            this.division.Location = new System.Drawing.Point(462, 93);
            this.division.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(136, 26);
            this.division.TabIndex = 176;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(391, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 18);
            this.label13.TabIndex = 175;
            this.label13.Text = "Division";
            // 
            // Class
            // 
            this.Class.FormattingEnabled = true;
            this.Class.Items.AddRange(new object[] {
            "bcs",
            "bca",
            "mca",
            "mcs"});
            this.Class.Location = new System.Drawing.Point(237, 93);
            this.Class.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(136, 26);
            this.Class.TabIndex = 174;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 18);
            this.label8.TabIndex = 173;
            this.label8.Text = "Class";
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.Location = new System.Drawing.Point(751, 93);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(78, 30);
            this.RefreshButton.TabIndex = 179;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // search1
            // 
            this.search1.BackColor = System.Drawing.Color.Blue;
            this.search1.Location = new System.Drawing.Point(633, 89);
            this.search1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(84, 34);
            this.search1.TabIndex = 178;
            this.search1.Text = "Search";
            this.search1.UseVisualStyleBackColor = false;
            this.search1.Click += new System.EventHandler(this.search1_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(192, 159);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(75, 18);
            this.Result.TabIndex = 180;
            this.Result.Text = "RESULT :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(86, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 46);
            this.panel1.TabIndex = 181;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(266, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Search Page";
            // 
            // subjectSearchdataGV
            // 
            this.subjectSearchdataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectSearchdataGV.Location = new System.Drawing.Point(86, 181);
            this.subjectSearchdataGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subjectSearchdataGV.Name = "subjectSearchdataGV";
            this.subjectSearchdataGV.ReadOnly = true;
            this.subjectSearchdataGV.RowTemplate.Height = 24;
            this.subjectSearchdataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectSearchdataGV.Size = new System.Drawing.Size(781, 333);
            this.subjectSearchdataGV.TabIndex = 182;
            // 
            // SubjectSearch_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1054, 562);
            this.Controls.Add(this.subjectSearchdataGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.division);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SubjectSearch_Form";
            this.Text = "SubjectEarch_Form";
            this.Load += new System.EventHandler(this.SubjectSearch_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectSearchdataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button search1;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox division;
        public System.Windows.Forms.ComboBox Class;
        private System.Windows.Forms.DataGridView subjectSearchdataGV;
    }
}