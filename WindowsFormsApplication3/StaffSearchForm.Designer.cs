namespace WindowsFormsApplication3
{
    partial class StaffSearchForm
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
            this.staffSearchdataGV = new System.Windows.Forms.DataGridView();
            this.SearchB = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.reg_no = new System.Windows.Forms.TextBox();
            this.search1 = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.staffSearchdataGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // staffSearchdataGV
            // 
            this.staffSearchdataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffSearchdataGV.Location = new System.Drawing.Point(12, 206);
            this.staffSearchdataGV.Name = "staffSearchdataGV";
            this.staffSearchdataGV.ReadOnly = true;
            this.staffSearchdataGV.RowTemplate.Height = 24;
            this.staffSearchdataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffSearchdataGV.Size = new System.Drawing.Size(1080, 326);
            this.staffSearchdataGV.TabIndex = 0;
            // 
            // SearchB
            // 
            this.SearchB.BackColor = System.Drawing.Color.Blue;
            this.SearchB.Location = new System.Drawing.Point(237, 131);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(75, 31);
            this.SearchB.TabIndex = 160;
            this.SearchB.Text = "Search";
            this.SearchB.UseVisualStyleBackColor = false;
            this.SearchB.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(342, 175);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(71, 17);
            this.Result.TabIndex = 161;
            this.Result.Text = "RESULT :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 52);
            this.panel1.TabIndex = 162;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(434, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Search Page";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(594, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 167;
            this.label8.Text = "Position";
            // 
            // Position
            // 
            this.Position.FormattingEnabled = true;
            this.Position.Items.AddRange(new object[] {
            "prinsiple",
            "hod",
            "teacher",
            "library",
            "puen",
            "security"});
            this.Position.Location = new System.Drawing.Point(672, 135);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(116, 24);
            this.Position.TabIndex = 166;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(40, 138);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 17);
            this.label16.TabIndex = 158;
            this.label16.Text = "RG_NO";
            // 
            // reg_no
            // 
            this.reg_no.Location = new System.Drawing.Point(103, 135);
            this.reg_no.Name = "reg_no";
            this.reg_no.Size = new System.Drawing.Size(113, 22);
            this.reg_no.TabIndex = 159;
            // 
            // search1
            // 
            this.search1.BackColor = System.Drawing.Color.Blue;
            this.search1.Location = new System.Drawing.Point(818, 131);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(75, 31);
            this.search1.TabIndex = 168;
            this.search1.Text = "Search";
            this.search1.UseVisualStyleBackColor = false;
            this.search1.Click += new System.EventHandler(this.search1_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.Location = new System.Drawing.Point(975, 131);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(77, 39);
            this.RefreshButton.TabIndex = 169;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // StaffSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 475);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.SearchB);
            this.Controls.Add(this.reg_no);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.staffSearchdataGV);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffSearchForm";
            this.Text = "StaffSearchForm";
            this.Load += new System.EventHandler(this.StaffSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffSearchdataGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView staffSearchdataGV;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox reg_no;
        private System.Windows.Forms.Button search1;
        private System.Windows.Forms.Button RefreshButton;
        public System.Windows.Forms.ComboBox Position;
    }
}