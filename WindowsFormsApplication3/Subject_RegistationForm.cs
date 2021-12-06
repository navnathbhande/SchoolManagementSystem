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
    public partial class Subject_RegistationForm : Form
    {
        BLClassSubject_RPage bl = new BLClassSubject_RPage(); 
        public Subject_RegistationForm()
        {
            InitializeComponent();
            subjectGridView.DataSource =bl.DataShow();
            Result.Text = Convert.ToInt32(subjectGridView.RowCount - 1) + " no of rows select";
        }
        public void clearAll()
        {
            Subject_Code.Clear();
            Subject_Name.Clear();
            Teacher_Name.Clear();
            Qualified.Clear();
            Class.Text = "";
            division.Text = "";
            RG_NO.Clear();
            searchClass.Text = "";
        }
        bool verify()
        {
            if (Subject_Code.Text == "" || Subject_Name.Text == "" || Teacher_Name.Text == "" || Qualified.Text == "" || Class.Text == "" || division.Text == "")
            {
                MessageBox.Show("insert all feeld Properly");
                return false;
               
            }
            else
            {
               
                return true;
            }
               
        }
        private void clear_button_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        int rg;//register no varable
        bool verifyrg()
        {
            bool b = int.TryParse(RG_NO.Text.Trim(), out rg);
            if (b == true&&rg>0)
            {
               
                return true;
               
            }
            else
            { MessageBox.Show("enetr valid rgno "); return false; }
               
        }

      

        private void submit_Click(object sender, EventArgs e)
        {
            if (verify()&&verifyrg())
            {
                if (bl.operationIU(Convert.ToInt32(RG_NO.Text.Trim()), Subject_Code.Text.Trim(), Subject_Name.Text.Trim(), Teacher_Name.Text.Trim(), Qualified.Text.Trim(), Class.Text, division.Text, "insert_Subject"))
                {
                    MessageBox.Show("insert record successFully");
                    Result.Text = Convert.ToInt32(subjectGridView.RowCount - 1) + " no of rows select";
                }
                else
                {
                    MessageBox.Show("enter reg_no aallreddy inserted use another");
                }
                subjectGridView.DataSource = bl.DataShow();
                clearAll();
            }
        }

        

        private void subjectGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RG_NO.Text = subjectGridView.SelectedRows[0].Cells[0].Value.ToString();
            Subject_Code.Text = subjectGridView.SelectedRows[0].Cells[1].Value.ToString();
            Subject_Name.Text = subjectGridView.SelectedRows[0].Cells[2].Value.ToString();
            Teacher_Name.Text = subjectGridView.SelectedRows[0].Cells[3].Value.ToString();
            Qualified.Text = subjectGridView.SelectedRows[0].Cells[4].Value.ToString();
            Class.Text = subjectGridView.SelectedRows[0].Cells[5].Value.ToString();
            division.Text = subjectGridView.SelectedRows[0].Cells[6].Value.ToString();
        }

       

        private void update_button_Click_1(object sender, EventArgs e)
        {
            if (verify()&&verifyrg())
            {
                if (bl.operationIU(Convert.ToInt32(RG_NO.Text.Trim()), Subject_Code.Text.Trim(), Subject_Name.Text.Trim(), Teacher_Name.Text.Trim(), Qualified.Text.Trim(), Class.Text, division.Text, "update_Subject"))
                {
                    MessageBox.Show("update record successFully");
                }
                 subjectGridView.DataSource = bl.DataShow();
                clearAll();
                Result.Text = Convert.ToInt32(subjectGridView.RowCount - 1) + " no of rows select";
            }
            else
            {
                MessageBox.Show("enter all feeld");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (verifyrg())
            {
                if (bl.deleteM(Convert.ToInt32(RG_NO.Text.Trim())))
                    {
                    MessageBox.Show(RG_NO.Text + " no delete record sucesfull");
                    subjectGridView.DataSource = bl.DataShow();
                    Result.Text = Convert.ToInt32(subjectGridView.RowCount - 1) + " no of rows select";
                    clearAll();
                    }
            }
        }

        private void Searchbutton_Click_1(object sender, EventArgs e)
        {
            subjectGridView.DataSource = bl.searchShow(searchClass.Text);
            Result.Text =Convert.ToInt32( subjectGridView.RowCount- 1)+" no of rows select";
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            subjectGridView.DataSource = bl.DataShow();
            Result.Text = Convert.ToInt32(subjectGridView.RowCount - 1) + " no of rows select";
            clearAll();
        }

        private void Subject_RegistationForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
