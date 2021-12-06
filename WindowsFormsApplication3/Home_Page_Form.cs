using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication3
{
    public partial class Home_Page_Form : Form
    { BLClass_HomePage1cs bl = new BLClass_HomePage1cs();
        public Home_Page_Form()
        {
            InitializeComponent();
            FeePane.Visible = false;
            Photo.Visible = false;
            Name_label.Visible = false;
        }

        private void searchReg_Click(object sender, EventArgs e)
        {
            
            if (verify_Rg())
            {
                HomedataGridView.DataSource = bl.showRegNo(Convert.ToInt32(reg_no.Text.Trim()));
                reg_no.Text = "";
                FeePane.Visible = false;
                Photo.Visible = false;
                Name_label.Visible = false;
            }
        }

        private void searchName_Click(object sender, EventArgs e)
        {
            HomedataGridView.DataSource = bl.showName(Full_Name.Text.Trim(),academic_year.Text);
            Full_Name.Text = "";
            FeePane.Visible = false;
            Photo.Visible = false;
            Name_label.Visible = false;
        }
        int Regno;
        private void HomedataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Regno =Convert.ToInt32( HomedataGridView.Rows[0].Cells[0].Value.ToString());
            Name_label.Text = HomedataGridView.Rows[0].Cells[1].Value.ToString();
            PaidFee.Text =HomedataGridView.Rows[0].Cells[14].Value.ToString();
            Pending_Fee.Text = HomedataGridView.Rows[0].Cells[15].Value.ToString();
            YourFee.Text = HomedataGridView.Rows[0].Cells[16].Value.ToString();
            object o  = HomedataGridView.Rows[0].Cells[17].Value;
            byte[] img = (byte[])o;
            MemoryStream ms = new MemoryStream(img);
            Photo.Image = System.Drawing.Image.FromStream(ms);
            FeePane.Visible = true;
            Photo.Visible = true;
            Name_label.Visible = true;
        }
        bool verify()
        {
            int i;
            bool b = int.TryParse(Fee.Text.Trim(), out i);
            if(b==true)
                return true;
            else
            return false;
        }
        bool verify_Rg()
        {
            int i;
            bool b = int.TryParse(reg_no.Text.Trim(), out i);
            if (b == true)
                return true;
            else
                return false;
        }
        private void Add_Button_Click(object sender, EventArgs e)
        {if (verify())
            {
                if (Convert.ToInt32(Fee.Text.Trim()) <= Convert.ToInt32(Pending_Fee.Text))
                {
                    bl.AddFee(Regno, Convert.ToInt32(Fee.Text.Trim()));
                    MessageBox.Show(" Your Fee update successfully");
                    HomedataGridView.DataSource = bl.showRegNo(Regno);
                    Fee.Clear();
                    FeePane.Visible = false;
                    Photo.Visible = false;
                    Name_label.Visible = false;
                }
                else
                {
                    MessageBox.Show("enter Fee valid");
                }
            }
        }

        private void Home_Page_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'school_DatabaseDataSet2.Change_Table' table. You can move, or remove it, as needed.
            this.change_TableTableAdapter.Fill(this.school_DatabaseDataSet2.Change_Table);
        }
    }
}
