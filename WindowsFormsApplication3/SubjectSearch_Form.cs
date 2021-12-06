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
    public partial class SubjectSearch_Form : Form
    {
        BLClass_SubjectSearch bl = new BLClass_SubjectSearch();
        public SubjectSearch_Form()
        {
            InitializeComponent();
            subjectSearchdataGV.DataSource = bl.searchMLoad();
            Result.Text = "total no of subject select is " + Convert.ToString(subjectSearchdataGV.RowCount - 1);
        }

        private void search1_Click(object sender, EventArgs e)
        {
            subjectSearchdataGV.DataSource = bl.searchM(Class.Text, division.Text);
            Result.Text = "total no of subject select is " + Convert.ToString(subjectSearchdataGV.RowCount - 1);
            Class.Text = "";
            division.Text = "";
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            subjectSearchdataGV.DataSource = bl.searchMLoad();
            Result.Text = "total no of subject select is " + Convert.ToString(subjectSearchdataGV.RowCount - 1);
        }

        private void SubjectSearch_Form_Load(object sender, EventArgs e)
        {
        }
    }
}
