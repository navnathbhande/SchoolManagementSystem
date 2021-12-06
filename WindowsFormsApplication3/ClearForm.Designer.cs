namespace WindowsFormsApplication3
{
    partial class ClearForm
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
            this.clearEventTable = new System.Windows.Forms.Button();
            this.clearFeeTable = new System.Windows.Forms.Button();
            this.clearSubjectTable = new System.Windows.Forms.Button();
            this.clearStaffTable = new System.Windows.Forms.Button();
            this.clearStudentTable = new System.Windows.Forms.Button();
            this.labelEventT = new System.Windows.Forms.Label();
            this.labelFeeT = new System.Windows.Forms.Label();
            this.labelSubjectT = new System.Windows.Forms.Label();
            this.labelStaffT = new System.Windows.Forms.Label();
            this.labelStudentT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Academic_Year = new System.Windows.Forms.TextBox();
            this.Academic_YearAddB = new System.Windows.Forms.Button();
            this.Academic_Year_RemoveB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.clearEventTable);
            this.panel1.Controls.Add(this.clearFeeTable);
            this.panel1.Controls.Add(this.clearSubjectTable);
            this.panel1.Controls.Add(this.clearStaffTable);
            this.panel1.Controls.Add(this.clearStudentTable);
            this.panel1.Controls.Add(this.labelEventT);
            this.panel1.Controls.Add(this.labelFeeT);
            this.panel1.Controls.Add(this.labelSubjectT);
            this.panel1.Controls.Add(this.labelStaffT);
            this.panel1.Controls.Add(this.labelStudentT);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(479, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 276);
            this.panel1.TabIndex = 0;
            // 
            // clearEventTable
            // 
            this.clearEventTable.BackColor = System.Drawing.Color.Red;
            this.clearEventTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearEventTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearEventTable.Location = new System.Drawing.Point(176, 220);
            this.clearEventTable.Name = "clearEventTable";
            this.clearEventTable.Size = new System.Drawing.Size(84, 29);
            this.clearEventTable.TabIndex = 7;
            this.clearEventTable.Text = "clear";
            this.clearEventTable.UseVisualStyleBackColor = false;
            this.clearEventTable.Click += new System.EventHandler(this.clearEventTable_Click);
            // 
            // clearFeeTable
            // 
            this.clearFeeTable.BackColor = System.Drawing.Color.Red;
            this.clearFeeTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearFeeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearFeeTable.Location = new System.Drawing.Point(176, 175);
            this.clearFeeTable.Name = "clearFeeTable";
            this.clearFeeTable.Size = new System.Drawing.Size(84, 29);
            this.clearFeeTable.TabIndex = 9;
            this.clearFeeTable.Text = "clear";
            this.clearFeeTable.UseVisualStyleBackColor = false;
            this.clearFeeTable.Click += new System.EventHandler(this.clearFeeTable_Click);
            // 
            // clearSubjectTable
            // 
            this.clearSubjectTable.BackColor = System.Drawing.Color.Red;
            this.clearSubjectTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearSubjectTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSubjectTable.Location = new System.Drawing.Point(176, 122);
            this.clearSubjectTable.Name = "clearSubjectTable";
            this.clearSubjectTable.Size = new System.Drawing.Size(84, 29);
            this.clearSubjectTable.TabIndex = 8;
            this.clearSubjectTable.Text = "clear";
            this.clearSubjectTable.UseVisualStyleBackColor = false;
            this.clearSubjectTable.Click += new System.EventHandler(this.clearSubjectTable_Click);
            // 
            // clearStaffTable
            // 
            this.clearStaffTable.BackColor = System.Drawing.Color.Red;
            this.clearStaffTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearStaffTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearStaffTable.Location = new System.Drawing.Point(176, 77);
            this.clearStaffTable.Name = "clearStaffTable";
            this.clearStaffTable.Size = new System.Drawing.Size(84, 29);
            this.clearStaffTable.TabIndex = 7;
            this.clearStaffTable.Text = "clear";
            this.clearStaffTable.UseVisualStyleBackColor = false;
            this.clearStaffTable.Click += new System.EventHandler(this.clearStaffTable_Click);
            // 
            // clearStudentTable
            // 
            this.clearStudentTable.BackColor = System.Drawing.Color.Red;
            this.clearStudentTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearStudentTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearStudentTable.Location = new System.Drawing.Point(176, 26);
            this.clearStudentTable.Name = "clearStudentTable";
            this.clearStudentTable.Size = new System.Drawing.Size(84, 29);
            this.clearStudentTable.TabIndex = 6;
            this.clearStudentTable.Text = "clear";
            this.clearStudentTable.UseVisualStyleBackColor = false;
            this.clearStudentTable.Click += new System.EventHandler(this.clearStudentTable_Click);
            // 
            // labelEventT
            // 
            this.labelEventT.AutoSize = true;
            this.labelEventT.BackColor = System.Drawing.Color.White;
            this.labelEventT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventT.Location = new System.Drawing.Point(14, 224);
            this.labelEventT.Name = "labelEventT";
            this.labelEventT.Size = new System.Drawing.Size(117, 25);
            this.labelEventT.TabIndex = 4;
            this.labelEventT.Text = "Event Book ";
            // 
            // labelFeeT
            // 
            this.labelFeeT.AutoSize = true;
            this.labelFeeT.BackColor = System.Drawing.Color.White;
            this.labelFeeT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeeT.Location = new System.Drawing.Point(14, 179);
            this.labelFeeT.Name = "labelFeeT";
            this.labelFeeT.Size = new System.Drawing.Size(101, 25);
            this.labelFeeT.TabIndex = 3;
            this.labelFeeT.Text = "Fee Table";
            // 
            // labelSubjectT
            // 
            this.labelSubjectT.AutoSize = true;
            this.labelSubjectT.BackColor = System.Drawing.Color.White;
            this.labelSubjectT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubjectT.Location = new System.Drawing.Point(14, 131);
            this.labelSubjectT.Name = "labelSubjectT";
            this.labelSubjectT.Size = new System.Drawing.Size(133, 25);
            this.labelSubjectT.TabIndex = 2;
            this.labelSubjectT.Text = "Subject Table";
            // 
            // labelStaffT
            // 
            this.labelStaffT.AutoSize = true;
            this.labelStaffT.BackColor = System.Drawing.Color.White;
            this.labelStaffT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffT.Location = new System.Drawing.Point(14, 81);
            this.labelStaffT.Name = "labelStaffT";
            this.labelStaffT.Size = new System.Drawing.Size(107, 25);
            this.labelStaffT.TabIndex = 1;
            this.labelStaffT.Text = "Staff Table";
            // 
            // labelStudentT
            // 
            this.labelStudentT.AutoSize = true;
            this.labelStudentT.BackColor = System.Drawing.Color.White;
            this.labelStudentT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentT.Location = new System.Drawing.Point(14, 26);
            this.labelStudentT.Name = "labelStudentT";
            this.labelStudentT.Size = new System.Drawing.Size(135, 25);
            this.labelStudentT.TabIndex = 0;
            this.labelStudentT.Text = "Student Table";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(474, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete All Data Of Table permnantly";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(217, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(498, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Causses These Informatio Feelup and Cleare CareFully";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.BackColor = System.Drawing.Color.White;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.Red;
            this.Result.Location = new System.Drawing.Point(451, 426);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(66, 25);
            this.Result.TabIndex = 4;
            this.Result.Text = "Result";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Academic_Year);
            this.panel2.Controls.Add(this.Academic_YearAddB);
            this.panel2.Controls.Add(this.Academic_Year_RemoveB);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 127);
            this.panel2.TabIndex = 5;
            // 
            // Academic_Year
            // 
            this.Academic_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Academic_Year.Location = new System.Drawing.Point(203, 17);
            this.Academic_Year.Margin = new System.Windows.Forms.Padding(2);
            this.Academic_Year.Name = "Academic_Year";
            this.Academic_Year.Size = new System.Drawing.Size(107, 30);
            this.Academic_Year.TabIndex = 16;
            // 
            // Academic_YearAddB
            // 
            this.Academic_YearAddB.BackColor = System.Drawing.Color.Green;
            this.Academic_YearAddB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Academic_YearAddB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Academic_YearAddB.Location = new System.Drawing.Point(93, 65);
            this.Academic_YearAddB.Name = "Academic_YearAddB";
            this.Academic_YearAddB.Size = new System.Drawing.Size(84, 38);
            this.Academic_YearAddB.TabIndex = 12;
            this.Academic_YearAddB.Text = "add";
            this.Academic_YearAddB.UseVisualStyleBackColor = false;
            this.Academic_YearAddB.Click += new System.EventHandler(this.Academic_YearAddB_Click);
            // 
            // Academic_Year_RemoveB
            // 
            this.Academic_Year_RemoveB.BackColor = System.Drawing.Color.Red;
            this.Academic_Year_RemoveB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Academic_Year_RemoveB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Academic_Year_RemoveB.Location = new System.Drawing.Point(203, 65);
            this.Academic_Year_RemoveB.Name = "Academic_Year_RemoveB";
            this.Academic_Year_RemoveB.Size = new System.Drawing.Size(107, 38);
            this.Academic_Year_RemoveB.TabIndex = 8;
            this.Academic_Year_RemoveB.Text = "remove";
            this.Academic_Year_RemoveB.UseVisualStyleBackColor = false;
            this.Academic_Year_RemoveB.Click += new System.EventHandler(this.Academic_Year_RemoveB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Academic Year";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(413, 79);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 404);
            this.panel3.TabIndex = 6;
            // 
            // ClearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 632);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClearForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "ClearForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearEventTable;
        private System.Windows.Forms.Button clearFeeTable;
        private System.Windows.Forms.Button clearSubjectTable;
        private System.Windows.Forms.Button clearStaffTable;
        private System.Windows.Forms.Button clearStudentTable;
        private System.Windows.Forms.Label labelEventT;
        private System.Windows.Forms.Label labelFeeT;
        private System.Windows.Forms.Label labelSubjectT;
        private System.Windows.Forms.Label labelStaffT;
        private System.Windows.Forms.Label labelStudentT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Academic_Year;
        private System.Windows.Forms.Button Academic_YearAddB;
        private System.Windows.Forms.Button Academic_Year_RemoveB;
        private System.Windows.Forms.Label label5;
    }
}