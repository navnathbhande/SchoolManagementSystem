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
    public partial class Student_Search_Form : Form
    {
        BLClass_StudSearch sp = new BLClass_StudSearch();
        public Student_Search_Form()
        {
            InitializeComponent();
       
            SearchGridView.DataSource = sp.searchSLoadTime();
            result1.Text=Convert.ToString(SearchGridView.RowCount-1)+"  Total no of employee.";
        }
        private void SearchSButton_Click(object sender, EventArgs e)
        {
         
                SearchGridView.DataSource = sp.searchS(Class.Text, division.Text, academic_year.Text);
                Class.Text = "";division.Text = "";academic_year.Text = "";result.Text = "";
                result1.Text = "Select total rows=  " + Convert.ToString( SearchGridView.RowCount - 1);
            
        }
       
           private void search1_Click(object sender, EventArgs e)
        {
            
                SearchGridView.DataSource = sp.searchS1(transport.Text,academic_year1.Text);
                transport.Text = ""; academic_year1.Text = "";result.Text = "";
                result1.Text = "Select total rows=  " + Convert.ToString(SearchGridView.RowCount - 1);
            
           
        }
        private void search2_Click(object sender, EventArgs e)
        {
            
                SearchGridView.DataSource = sp.searchS2(academic_year2.Text);
                academic_year2.Text = "";
                result1.Text ="Select total rows=  "+ Convert.ToString(SearchGridView.RowCount - 1);
            
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            SearchGridView.DataSource = sp.searchSLoadTime();
            result1.Text = "Select total rows=  " + Convert.ToString(SearchGridView.RowCount - 1);
        }

        private void SearchPendingFee_Click(object sender, EventArgs e)
        {
            SearchGridView.DataSource = sp.searchPendingFee(ClassPendingFee.Text, DivisionPendingFee.Text, AcademicYearPendingFee.Text);
            ClassPendingFee.Text = ""; DivisionPendingFee.Text = "";AcademicYearPendingFee.Text = "";
            result1.Text = "Select total rows=  " + Convert.ToString(SearchGridView.RowCount - 1);
        }

        private void Student_Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'school_DatabaseDataSet.Change_Table' table. You can move, or remove it, as needed.
            this.change_TableTableAdapter.Fill(this.school_DatabaseDataSet.Change_Table);


        }
    }
}
