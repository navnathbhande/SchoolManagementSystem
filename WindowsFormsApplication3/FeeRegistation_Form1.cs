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
    public partial class FeeRegistation_Form1 : Form
    {
        BLClassFee_RPage bl = new BLClassFee_RPage();
        public FeeRegistation_Form1()
        {
            InitializeComponent();
            FeeGridView.DataSource = bl.showData();
            Result.Text = Convert.ToInt32(FeeGridView.RowCount - 1) + " no of rows select";
        }
        public void Allclear()
        {
            reg_no.Clear();
            Class.Text ="";
            division.Text ="";

            Fee.Clear();
            searchClass.Text ="";
        }
        private void Searchbutton_Click(object sender, EventArgs e)
        {
            FeeGridView.DataSource = bl.searchShow(searchClass.Text.Trim());
            Result.Text = Convert.ToInt32(FeeGridView.RowCount - 1) + " no of rows select";
            Allclear();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            Allclear();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (verify() && verifyregno() && verifyFee())
            {
                if (bl.check_Class(Class.Text, division.Text))
                {
                    if (bl.operationIU(Convert.ToInt32(reg_no.Text.Trim()), Class.Text.Trim(), division.Text.Trim(), Convert.ToInt32(Fee.Text.Trim()), "update_Fee"))
                    {
                        MessageBox.Show("record update successfull");
                        FeeGridView.DataSource = bl.showData();
                        Result.Text = Convert.ToInt32(FeeGridView.RowCount - 1) + " no of rows select";
                        Allclear();
                    }
                }
                else
                {
                if( bl.single_Fee_Update(Class.Text.Trim(), division.Text.Trim(), Convert.ToInt32(Fee.Text.Trim())))
                        {
                        MessageBox.Show(Class.Text+" "+division.Text+" record available to so update fee only successfull");
                        FeeGridView.DataSource = bl.showData();
                        Result.Text = Convert.ToInt32(FeeGridView.RowCount - 1) + " no of rows select";
                        Allclear();
                       } 
                }

            }
        }
        bool verifyregno()
        {
            int r;
            bool b = int.TryParse(reg_no.Text.Trim(), out r);
            if (b == true&&r>0)
            {
              
                return true;
            }
            else {
                MessageBox.Show("enter reg no in proper");
                return false;
            }
        }
        bool verifyFee()
        {
            int f;
            bool b = int.TryParse(Fee.Text.Trim(), out f);
            if (b == true && f >= 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("insert fee in digits");
                return false;
            }
        }
        bool verify()
        {
           
            if (Class.Text== "" || division.Text== "" )
            {
                MessageBox.Show("insert all feel properly");
                return false;
            }
            else
            {
             return true;
            }
        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            if (verifyregno())
            {
                if (bl.deleteM(Convert.ToInt32(reg_no.Text.Trim())))
                {
                    MessageBox.Show(reg_no.Text + " no of record delete");
                    FeeGridView.DataSource = bl.showData();
                    Result.Text = Convert.ToInt32(FeeGridView.RowCount - 1) + " no of rows select";
                    Allclear();
                }
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (verify() && verifyregno()&&verifyFee())
            {
                if (bl.check_Class(Class.Text, division.Text))
                {
                    if (bl.operationIU(Convert.ToInt32(reg_no.Text.Trim()), Class.Text, division.Text, Convert.ToInt32(Fee.Text.Trim()), "insert_Fee"))
                    {
                        MessageBox.Show("record insert successfull");
                        FeeGridView.DataSource = bl.showData();
                        Result.Text = Convert.ToInt32(FeeGridView.RowCount - 1) + " no of rows select";
                        Allclear();
                    }
                    else
                    {
                        MessageBox.Show("check your rg no");
                    }
                }
                else
                {
                    MessageBox.Show(Class.Text + " " + division.Text + " is allReaddy available in this Table insert Another or update");
                }

            }
        }

        private void FeeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            reg_no.Text = FeeGridView.SelectedRows[0].Cells[0].Value.ToString();
            Class.Text = FeeGridView.SelectedRows[0].Cells[1].Value.ToString();
            division.Text = FeeGridView.SelectedRows[0].Cells[2].Value.ToString();

            Fee.Text = FeeGridView.SelectedRows[0].Cells[3].Value.ToString();
        }
       
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            FeeGridView.DataSource = bl.showData();
            Result.Text = Convert.ToInt32(FeeGridView.RowCount - 1) + " no of rows select";
            Allclear();
        }

        private void FeeRegistation_Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
