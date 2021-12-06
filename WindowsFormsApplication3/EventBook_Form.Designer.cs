namespace WindowsFormsApplication3
{
    partial class EventBook_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.Event_No = new System.Windows.Forms.TextBox();
            this.eventdataGridView = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Event_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Money = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.eventname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventdataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event_No";
            // 
            // Event_No
            // 
            this.Event_No.Location = new System.Drawing.Point(145, 337);
            this.Event_No.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Event_No.Name = "Event_No";
            this.Event_No.Size = new System.Drawing.Size(112, 24);
            this.Event_No.TabIndex = 1;
            // 
            // eventdataGridView
            // 
            this.eventdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventdataGridView.Location = new System.Drawing.Point(151, 162);
            this.eventdataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eventdataGridView.Name = "eventdataGridView";
            this.eventdataGridView.ReadOnly = true;
            this.eventdataGridView.RowTemplate.Height = 24;
            this.eventdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eventdataGridView.Size = new System.Drawing.Size(706, 150);
            this.eventdataGridView.TabIndex = 2;
            this.eventdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventdataGridView_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 383);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 24);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date";
            // 
            // Event_Name
            // 
            this.Event_Name.Location = new System.Drawing.Point(362, 340);
            this.Event_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Event_Name.MaxLength = 200;
            this.Event_Name.Name = "Event_Name";
            this.Event_Name.Size = new System.Drawing.Size(523, 24);
            this.Event_Name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Event_Name";
            // 
            // Money
            // 
            this.Money.Location = new System.Drawing.Point(580, 385);
            this.Money.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Money.MaxLength = 10;
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(112, 24);
            this.Money.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Money";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(56, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 48);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(316, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Event-Book";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(486, 427);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(114, 36);
            this.deleteButton.TabIndex = 183;
            this.deleteButton.Text = "delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.LightCoral;
            this.update_button.Location = new System.Drawing.Point(347, 428);
            this.update_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(84, 34);
            this.update_button.TabIndex = 182;
            this.update_button.Text = "update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.DarkGray;
            this.clear_button.Location = new System.Drawing.Point(185, 428);
            this.clear_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(90, 34);
            this.clear_button.TabIndex = 181;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Blue;
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(655, 427);
            this.submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(114, 36);
            this.submit.TabIndex = 180;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Blue;
            this.searchButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.searchButton.Location = new System.Drawing.Point(715, 87);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(84, 38);
            this.searchButton.TabIndex = 184;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.Coral;
            this.RefreshButton.Location = new System.Drawing.Point(812, 88);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(84, 38);
            this.RefreshButton.TabIndex = 185;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // eventname
            // 
            this.eventname.Location = new System.Drawing.Point(160, 94);
            this.eventname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eventname.Name = "eventname";
            this.eventname.Size = new System.Drawing.Size(507, 24);
            this.eventname.TabIndex = 187;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 186;
            this.label6.Text = "Event_Name";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(207, 126);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(50, 18);
            this.Result.TabIndex = 188;
            this.Result.Text = "Result";
            // 
            // EventBook_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 699);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.eventname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Event_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.eventdataGridView);
            this.Controls.Add(this.Event_No);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EventBook_Form";
            this.Text = "EventBook_Form";
            ((System.ComponentModel.ISupportInitialize)(this.eventdataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Event_No;
        private System.Windows.Forms.DataGridView eventdataGridView;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Event_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Money;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TextBox eventname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Result;
    }
}