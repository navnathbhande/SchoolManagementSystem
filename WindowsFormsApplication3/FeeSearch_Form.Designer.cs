namespace WindowsFormsApplication3
{
    partial class FeeSearch_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.search1 = new System.Windows.Forms.Button();
            this.feeSearchdataGV = new System.Windows.Forms.DataGridView();
            this.division = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feeSearchdataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 51);
            this.panel1.TabIndex = 190;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(251, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fee Search Page";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(200, 153);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(75, 18);
            this.Result.TabIndex = 189;
            this.Result.Text = "RESULT :";
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.Location = new System.Drawing.Point(646, 153);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(79, 30);
            this.RefreshButton.TabIndex = 188;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // search1
            // 
            this.search1.BackColor = System.Drawing.Color.Blue;
            this.search1.Location = new System.Drawing.Point(640, 82);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(84, 35);
            this.search1.TabIndex = 187;
            this.search1.Text = "Search";
            this.search1.UseVisualStyleBackColor = false;
            this.search1.Click += new System.EventHandler(this.search1_Click);
            // 
            // feeSearchdataGV
            // 
            this.feeSearchdataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feeSearchdataGV.Location = new System.Drawing.Point(29, 196);
            this.feeSearchdataGV.Name = "feeSearchdataGV";
            this.feeSearchdataGV.ReadOnly = true;
            this.feeSearchdataGV.RowTemplate.Height = 24;
            this.feeSearchdataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.feeSearchdataGV.Size = new System.Drawing.Size(712, 316);
            this.feeSearchdataGV.TabIndex = 186;
            // 
            // division
            // 
            this.division.FormattingEnabled = true;
            this.division.Items.AddRange(new object[] {
            "1st year",
            "2nd year",
            "3rd year"});
            this.division.Location = new System.Drawing.Point(470, 86);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(136, 26);
            this.division.TabIndex = 185;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(399, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 18);
            this.label13.TabIndex = 184;
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
            this.Class.Location = new System.Drawing.Point(245, 86);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(136, 26);
            this.Class.TabIndex = 183;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 18);
            this.label8.TabIndex = 182;
            this.label8.Text = "Class";
            // 
            // FeeSearch_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.feeSearchdataGV);
            this.Controls.Add(this.division);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FeeSearch_Form";
            this.Text = "FeeSearch_Form";
            this.Load += new System.EventHandler(this.FeeSearch_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feeSearchdataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button search1;
        private System.Windows.Forms.DataGridView feeSearchdataGV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox division;
        public System.Windows.Forms.ComboBox Class;
    }
}