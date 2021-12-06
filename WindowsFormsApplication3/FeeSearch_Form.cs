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
    public partial class FeeSearch_Form : Form
    {
        BLClass_FeeSearch bl = new BLClass_FeeSearch();
        public FeeSearch_Form()
        {
            InitializeComponent();
            feeSearchdataGV.DataSource = bl.searchMLoad();
            Result.Text = "total no of select " + Convert.ToString(feeSearchdataGV.RowCount - 1);
        }

        private void search1_Click(object sender, EventArgs e)
        {
            feeSearchdataGV.DataSource = bl.searchM(Class.Text,division.Text);
            Result.Text = "total no of select " + Convert.ToString(feeSearchdataGV.RowCount - 1);
            Class.Text = "";
            division.Text = "";
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            feeSearchdataGV.DataSource = bl.searchMLoad();
            Result.Text = "total no of select " + Convert.ToString(feeSearchdataGV.RowCount - 1);
      }

        private void FeeSearch_Form_Load(object sender, EventArgs e)
        {
           
        }
    }
}
