using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class MainPage : Form
    {
        
        public MainPage()
        {
            InitializeComponent();
            loadform(new Home_Page_Form());
        }

        private void pictureBox1_Click(object sender, EventArgs e)    //appllication close
        {
            Application.Exit();

        }
        public void loadform(object Form)                           // show all pages in panel3
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(f);
            this.panel3.Tag = f;
            f.Show();
        }
   
     private void Registation_Button_Click(object sender, EventArgs e)   //call student registation page
        {
            loadform(new Student_RegistationForm());
        }

        private void StaffRegButton_Click(object sender, EventArgs e)    //call staff registation page
        {
            loadform(new Staff_RegistationForm());
        }

        private void SubjectRegistation_Click(object sender, EventArgs e)
        {
            loadform(new Subject_RegistationForm());                     //call subject Registation page
        }

        private void FeeRegistation_Click(object sender, EventArgs e)
        {
            loadform(new FeeRegistation_Form1());
           
           
        }
      private void SearchPageButton_Click(object sender, EventArgs e)
        {
            loadform(new Student_Search_Form());
        }

        private void Staff_Search_Click(object sender, EventArgs e)
        {
            loadform(new StaffSearchForm());
        }

        private void subject_Search_Click(object sender, EventArgs e)
        {
            loadform(new SubjectSearch_Form());
        }

        private void Fee_Search_Click(object sender, EventArgs e)
        {
            loadform(new FeeSearch_Form());
        }
     private void clearButton_Click_1(object sender, EventArgs e)
        {
            loadform(new ClearForm());
        }

        private void eventBookButton_Click(object sender, EventArgs e)
        {
            loadform(new EventBook_Form());
        }
    private void ExitButton_Click(object sender, EventArgs e)
        {
           LogInForm lg = new LogInForm();
           lg.closeM();
        }

        private void HomePicture_Click(object sender, EventArgs e)
        {
            loadform(new Home_Page_Form());
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            loadform(new Report_Form());
        }

        private void MinimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
