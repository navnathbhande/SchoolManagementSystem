namespace WindowsFormsApplication3
{
    partial class FeeRegistation_Form1
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
            this.update_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.RGNOLabel = new System.Windows.Forms.Label();
            this.Fee = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchClass = new System.Windows.Forms.ComboBox();
            this.reg_no = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.division = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FeeGridView = new System.Windows.Forms.DataGridView();
            this.Result = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Red;
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Location = new System.Drawing.Point(516, 463);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(93, 38);
            this.delete_button.TabIndex = 211;
            this.delete_button.Text = "delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.LightCoral;
            this.update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(403, 463);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(93, 38);
            this.update_button.TabIndex = 210;
            this.update_button.Text = "update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.DarkGray;
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(273, 463);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(100, 38);
            this.clear_button.TabIndex = 209;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Blue;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(754, 463);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(128, 38);
            this.submit.TabIndex = 208;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // RGNOLabel
            // 
            this.RGNOLabel.AutoSize = true;
            this.RGNOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGNOLabel.Location = new System.Drawing.Point(582, 425);
            this.RGNOLabel.Name = "RGNOLabel";
            this.RGNOLabel.Size = new System.Drawing.Size(37, 20);
            this.RGNOLabel.TabIndex = 207;
            this.RGNOLabel.Text = "Fee";
            // 
            // Fee
            // 
            this.Fee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fee.Location = new System.Drawing.Point(647, 418);
            this.Fee.Name = "Fee";
            this.Fee.Size = new System.Drawing.Size(153, 27);
            this.Fee.TabIndex = 206;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.Location = new System.Drawing.Point(789, 121);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(93, 29);
            this.RefreshButton.TabIndex = 205;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.Searchbutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchClass);
            this.panel1.Location = new System.Drawing.Point(49, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 51);
            this.panel1.TabIndex = 204;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(203, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 27);
            this.label11.TabIndex = 0;
            this.label11.Text = "Fee Registation Page";
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(719, 8);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(93, 29);
            this.Searchbutton.TabIndex = 183;
            this.Searchbutton.Text = "search";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(476, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 134;
            this.label1.Text = "Class";
            // 
            // searchClass
            // 
            this.searchClass.FormattingEnabled = true;
            this.searchClass.Items.AddRange(new object[] {
            "bca",
            "bcs",
            "mca",
            "mcs"});
            this.searchClass.Location = new System.Drawing.Point(543, 8);
            this.searchClass.Name = "searchClass";
            this.searchClass.Size = new System.Drawing.Size(153, 28);
            this.searchClass.TabIndex = 135;
            // 
            // reg_no
            // 
            this.reg_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_no.Location = new System.Drawing.Point(149, 381);
            this.reg_no.Name = "reg_no";
            this.reg_no.Size = new System.Drawing.Size(92, 27);
            this.reg_no.TabIndex = 203;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(58, 381);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 20);
            this.label16.TabIndex = 202;
            this.label16.Text = "RG_NO";
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.FormattingEnabled = true;
            this.division.Items.AddRange(new object[] {
            "1st year",
            "2nd year",
            "3rd year"});
            this.division.Location = new System.Drawing.Point(649, 384);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(151, 28);
            this.division.TabIndex = 201;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(554, 387);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 200;
            this.label13.Text = "Division";
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
            this.Class.Location = new System.Drawing.Point(371, 384);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(153, 28);
            this.Class.TabIndex = 199;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(313, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 198;
            this.label8.Text = "Class";
            // 
            // FeeGridView
            // 
            this.FeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeeGridView.Location = new System.Drawing.Point(49, 157);
            this.FeeGridView.Name = "FeeGridView";
            this.FeeGridView.ReadOnly = true;
            this.FeeGridView.RowTemplate.Height = 24;
            this.FeeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FeeGridView.Size = new System.Drawing.Size(833, 212);
            this.FeeGridView.TabIndex = 197;
            this.FeeGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FeeGridView_CellContentClick);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(173, 131);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(57, 20);
            this.Result.TabIndex = 212;
            this.Result.Text = "Result";
            // 
            // FeeRegistation_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 703);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.RGNOLabel);
            this.Controls.Add(this.Fee);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reg_no);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.division);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FeeGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FeeRegistation_Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FeeRegistation_Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label RGNOLabel;
        private System.Windows.Forms.TextBox Fee;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox searchClass;
        private System.Windows.Forms.TextBox reg_no;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.ComboBox division;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox Class;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView FeeGridView;
        private System.Windows.Forms.Label Result;
    }
}