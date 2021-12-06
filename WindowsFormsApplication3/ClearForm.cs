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
    public partial class ClearForm : Form
    {
        BLClass_Clear bl = new BLClass_Clear();
         public ClearForm()
        {
            InitializeComponent();
            Result.Text = "";

        }

        private void clearStudentTable_Click(object sender, EventArgs e)
        {
            bl.studentClear();
            Result.Text = "delete all the information of  student table";
        }

        private void clearStaffTable_Click(object sender, EventArgs e)
        {
            bl.staffClear();
            Result.Text = "delete all the information of  staff table";
        }

        private void clearSubjectTable_Click(object sender, EventArgs e)
        {
            bl.subjectClear();
            Result.Text = "delete all the information of  subject table";
        }

        private void clearFeeTable_Click(object sender, EventArgs e)
        {
            bl.feeClear();
            Result.Text = "delete all the information of  fee table";
        }

        private void clearEventTable_Click(object sender, EventArgs e)
        {
            bl.eventClear();
            Result.Text = "delete all the information of  event table";
        }
      private void Academic_YearAddB_Click(object sender, EventArgs e)
        {
            if (Academic_Year.Text == "") { }
            else
            {
                bl.AddRemoveAcademicYear(Academic_Year.Text.Trim(), "Academic_Year_insert");
                MessageBox.Show(Academic_Year.Text + " insert successfull");
                Academic_Year.Clear();
            }
            
        }
   private void Academic_Year_RemoveB_Click(object sender, EventArgs e)
        {
            if (Academic_Year.Text == "") { }
            else
            {
                bl.AddRemoveAcademicYear(Academic_Year.Text.Trim(), "Academic_Year_delete");
                MessageBox.Show(Academic_Year.Text + " delete successfull");
                Academic_Year.Clear();
            }
        }

       
    }
}
