namespace WindowsFormsApplication3
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel2 = new System.Windows.Forms.Panel();
            this.MinimiseButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HomePicture = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.RegistationMain = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.panelRegistation = new System.Windows.Forms.Panel();
            this.FeeRegistation = new System.Windows.Forms.Button();
            this.Registation_Button = new System.Windows.Forms.Button();
            this.SubjectRegistation = new System.Windows.Forms.Button();
            this.StaffRegButton = new System.Windows.Forms.Button();
            this.eventBookButton = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.Staff_Search = new System.Windows.Forms.Button();
            this.Fee_Search = new System.Windows.Forms.Button();
            this.subject_Search = new System.Windows.Forms.Button();
            this.SearchPageButton = new System.Windows.Forms.Button();
            this.HomeClick = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicture)).BeginInit();
            this.panelRegistation.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeClick)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.MinimiseButton);
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Controls.Add(this.HeaderLabel);
            this.panel2.Name = "panel2";
            // 
            // MinimiseButton
            // 
            this.MinimiseButton.BackColor = System.Drawing.Color.DarkSlateGray;
            resources.ApplyResources(this.MinimiseButton, "MinimiseButton");
            this.MinimiseButton.ForeColor = System.Drawing.Color.White;
            this.MinimiseButton.Name = "MinimiseButton";
            this.MinimiseButton.UseVisualStyleBackColor = false;
            this.MinimiseButton.Click += new System.EventHandler(this.MinimiseButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.DarkSlateGray;
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HeaderLabel
            // 
            resources.ApplyResources(this.HeaderLabel, "HeaderLabel");
            this.HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel.Name = "HeaderLabel";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.HomePicture);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.RegistationMain);
            this.panel1.Controls.Add(this.ReportButton);
            this.panel1.Controls.Add(this.panelRegistation);
            this.panel1.Controls.Add(this.eventBookButton);
            this.panel1.Controls.Add(this.Search_button);
            this.panel1.Controls.Add(this.panelSearch);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // HomePicture
            // 
            this.HomePicture.Image = global::WindowsFormsApplication3.Properties.Resources.pngtree_vector_home_icon_png_image_991177__1_;
            resources.ApplyResources(this.HomePicture, "HomePicture");
            this.HomePicture.Name = "HomePicture";
            this.HomePicture.TabStop = false;
            this.HomePicture.Click += new System.EventHandler(this.HomePicture_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.clearButton, "clearButton");
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Image = global::WindowsFormsApplication3.Properties.Resources._404_4040102_clear_icon_color_clear_all_icon_png_transparent__1_;
            this.clearButton.Name = "clearButton";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click_1);
            // 
            // RegistationMain
            // 
            this.RegistationMain.BackColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.RegistationMain, "RegistationMain");
            this.RegistationMain.ForeColor = System.Drawing.Color.White;
            this.RegistationMain.Image = global::WindowsFormsApplication3.Properties.Resources._50501423_pencil_with_eraser_cartoon_icon_isolated_on_a_white_background;
            this.RegistationMain.Name = "RegistationMain";
            this.RegistationMain.UseVisualStyleBackColor = false;
            // 
            // ReportButton
            // 
            this.ReportButton.BackColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.ReportButton, "ReportButton");
            this.ReportButton.ForeColor = System.Drawing.Color.White;
            this.ReportButton.Image = global::WindowsFormsApplication3.Properties.Resources.call_report_icon_3__2_;
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.UseVisualStyleBackColor = false;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // panelRegistation
            // 
            this.panelRegistation.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelRegistation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRegistation.Controls.Add(this.FeeRegistation);
            this.panelRegistation.Controls.Add(this.Registation_Button);
            this.panelRegistation.Controls.Add(this.SubjectRegistation);
            this.panelRegistation.Controls.Add(this.StaffRegButton);
            resources.ApplyResources(this.panelRegistation, "panelRegistation");
            this.panelRegistation.Name = "panelRegistation";
            // 
            // FeeRegistation
            // 
            this.FeeRegistation.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.FeeRegistation, "FeeRegistation");
            this.FeeRegistation.ForeColor = System.Drawing.Color.Black;
            this.FeeRegistation.Image = global::WindowsFormsApplication3.Properties.Resources.new_indian_currency_rupees_d_rendered_image_84057351__1_;
            this.FeeRegistation.Name = "FeeRegistation";
            this.FeeRegistation.UseVisualStyleBackColor = false;
            this.FeeRegistation.Click += new System.EventHandler(this.FeeRegistation_Click);
            // 
            // Registation_Button
            // 
            this.Registation_Button.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Registation_Button, "Registation_Button");
            this.Registation_Button.ForeColor = System.Drawing.Color.Black;
            this.Registation_Button.Image = global::WindowsFormsApplication3.Properties.Resources._71633172_graduation_hat_icon_in_duo_tone_color_education_college_student;
            this.Registation_Button.Name = "Registation_Button";
            this.Registation_Button.UseVisualStyleBackColor = false;
            this.Registation_Button.Click += new System.EventHandler(this.Registation_Button_Click);
            // 
            // SubjectRegistation
            // 
            this.SubjectRegistation.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.SubjectRegistation, "SubjectRegistation");
            this.SubjectRegistation.ForeColor = System.Drawing.Color.Black;
            this.SubjectRegistation.Image = global::WindowsFormsApplication3.Properties.Resources._344_3441162_classroom_icon_stack_of_books_png_transparent_png__1_;
            this.SubjectRegistation.Name = "SubjectRegistation";
            this.SubjectRegistation.UseVisualStyleBackColor = false;
            this.SubjectRegistation.Click += new System.EventHandler(this.SubjectRegistation_Click);
            // 
            // StaffRegButton
            // 
            this.StaffRegButton.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.StaffRegButton, "StaffRegButton");
            this.StaffRegButton.ForeColor = System.Drawing.Color.Black;
            this.StaffRegButton.Image = global::WindowsFormsApplication3.Properties.Resources._129_1298564_staff_and_locations_staff_icon_hd_png_download__1_;
            this.StaffRegButton.Name = "StaffRegButton";
            this.StaffRegButton.UseVisualStyleBackColor = false;
            this.StaffRegButton.Click += new System.EventHandler(this.StaffRegButton_Click);
            // 
            // eventBookButton
            // 
            this.eventBookButton.BackColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.eventBookButton, "eventBookButton");
            this.eventBookButton.ForeColor = System.Drawing.Color.White;
            this.eventBookButton.Image = global::WindowsFormsApplication3.Properties.Resources._176_1767022_news_events_event_icon_clipart__1_;
            this.eventBookButton.Name = "eventBookButton";
            this.eventBookButton.UseVisualStyleBackColor = false;
            this.eventBookButton.Click += new System.EventHandler(this.eventBookButton_Click);
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.Search_button, "Search_button");
            this.Search_button.ForeColor = System.Drawing.Color.White;
            this.Search_button.Image = global::WindowsFormsApplication3.Properties.Resources.icontexto_search_01_icon_icons_com_76897__1_;
            this.Search_button.Name = "Search_button";
            this.Search_button.UseVisualStyleBackColor = false;
            // 
            // panelSearch
            // 
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSearch.Controls.Add(this.Staff_Search);
            this.panelSearch.Controls.Add(this.Fee_Search);
            this.panelSearch.Controls.Add(this.subject_Search);
            this.panelSearch.Controls.Add(this.SearchPageButton);
            resources.ApplyResources(this.panelSearch, "panelSearch");
            this.panelSearch.Name = "panelSearch";
            // 
            // Staff_Search
            // 
            this.Staff_Search.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Staff_Search, "Staff_Search");
            this.Staff_Search.ForeColor = System.Drawing.Color.Black;
            this.Staff_Search.Image = global::WindowsFormsApplication3.Properties.Resources._129_1298564_staff_and_locations_staff_icon_hd_png_download__1_;
            this.Staff_Search.Name = "Staff_Search";
            this.Staff_Search.UseVisualStyleBackColor = false;
            this.Staff_Search.Click += new System.EventHandler(this.Staff_Search_Click);
            // 
            // Fee_Search
            // 
            this.Fee_Search.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Fee_Search, "Fee_Search");
            this.Fee_Search.ForeColor = System.Drawing.Color.Black;
            this.Fee_Search.Image = global::WindowsFormsApplication3.Properties.Resources.new_indian_currency_rupees_d_rendered_image_84057351__1_;
            this.Fee_Search.Name = "Fee_Search";
            this.Fee_Search.UseVisualStyleBackColor = false;
            this.Fee_Search.Click += new System.EventHandler(this.Fee_Search_Click);
            // 
            // subject_Search
            // 
            this.subject_Search.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.subject_Search, "subject_Search");
            this.subject_Search.ForeColor = System.Drawing.Color.Black;
            this.subject_Search.Image = global::WindowsFormsApplication3.Properties.Resources._344_3441162_classroom_icon_stack_of_books_png_transparent_png__1_;
            this.subject_Search.Name = "subject_Search";
            this.subject_Search.UseVisualStyleBackColor = false;
            this.subject_Search.Click += new System.EventHandler(this.subject_Search_Click);
            // 
            // SearchPageButton
            // 
            this.SearchPageButton.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.SearchPageButton, "SearchPageButton");
            this.SearchPageButton.ForeColor = System.Drawing.Color.Black;
            this.SearchPageButton.Image = global::WindowsFormsApplication3.Properties.Resources._71633172_graduation_hat_icon_in_duo_tone_color_education_college_student;
            this.SearchPageButton.Name = "SearchPageButton";
            this.SearchPageButton.UseVisualStyleBackColor = false;
            this.SearchPageButton.Click += new System.EventHandler(this.SearchPageButton_Click);
            // 
            // HomeClick
            // 
            this.HomeClick.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.HomeClick, "HomeClick");
            this.HomeClick.Name = "HomeClick";
            this.HomeClick.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomePicture)).EndInit();
            this.panelRegistation.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeClick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button eventBookButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RegistationMain;
        private System.Windows.Forms.Panel panelRegistation;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.PictureBox HomeClick;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox HomePicture;
        private System.Windows.Forms.Button FeeRegistation;
        private System.Windows.Forms.Button Registation_Button;
        private System.Windows.Forms.Button SubjectRegistation;
        private System.Windows.Forms.Button StaffRegButton;
        private System.Windows.Forms.Button Staff_Search;
        private System.Windows.Forms.Button Fee_Search;
        private System.Windows.Forms.Button subject_Search;
        private System.Windows.Forms.Button SearchPageButton;
        private System.Windows.Forms.Button MinimiseButton;
    }
}

