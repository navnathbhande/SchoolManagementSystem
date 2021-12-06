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
    public partial class StaffSearchForm : Form
    {
        BLClass_StaffSearch bl = new BLClass_StaffSearch();
        public StaffSearchForm()
        {
            InitializeComponent();
            staffSearchdataGV.DataSource = bl.searchM();
            Result.Text =Convert.ToString(staffSearchdataGV.RowCount-1)+" no of staff ";
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            int i;
            bool b = int.TryParse(reg_no.Text.Trim(), out i);
            if (b == true)
            {
                Result.Text = "";
                staffSearchdataGV.DataSource = bl.searchStaff(Convert.ToInt32(reg_no.Text));
                reg_no.Text = "";
            }
        }

        private void search1_Click(object sender, EventArgs e)
        {
         
            staffSearchdataGV.DataSource = bl.searchStaffPossition(Position.Text);
            Position.Text = "";
            Result.Text = "no of search = " + Convert.ToString(staffSearchdataGV.RowCount - 1);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            staffSearchdataGV.DataSource = bl.searchM();
            Result.Text = "no of search = " + Convert.ToString(staffSearchdataGV.RowCount - 1);
        }

        private void StaffSearchForm_Load(object sender, EventArgs e)
        {
          
        }
    }
}
