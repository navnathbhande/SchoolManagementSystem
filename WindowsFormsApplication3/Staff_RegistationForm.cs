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
    public partial class Staff_RegistationForm : Form
    {
        public Staff_RegistationForm()
        {
            InitializeComponent();
            StaffdataGridView1.DataSource = BL.DataShow();     //show data load time
            Result.Text = Convert.ToInt32(StaffdataGridView1.RowCount - 1) + " no of rows select";
        }
        BLClassStaff_RPage BL = new BLClassStaff_RPage();                   //object create of BLClassStaff_RPage class
        byte[] img;
        int sallary;
        string gender;
        bool verifySallary()
        {
            bool b = int.TryParse(Sall.Text.Trim(), out sallary);

            //check fees
            if (b == true && sallary >= 0)
            {
                return true;
            }
            else
            {

                MessageBox.Show("enter sallary proper");
                return false;
            }
        }
        private bool verify()                                                //verify all without check primary key record only
        {
           
            int pdate = DateTimePicker1.Value.Year;
            int adate = DateTime.Now.Year;
            if (pictureBox1.Image != null)                          //save image
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                img = ms.ToArray();
            }
            else
            {
                MessageBox.Show("select image");
            }
           
            //check gender
            if (male_rb.Checked)
                gender = "male";
            else
                gender = "female";
            //check phone no

            if (Mobile.Text.Count() != 10)
                MessageBox.Show("enter valid phone");
            //check birth date
            int currentYear = DateTime.Now.Year;
            int beforeYear = DateTimePicker1.Value.Year;
            bool tempDate;
            if (currentYear - beforeYear < 100 && currentYear - beforeYear > 5) { tempDate = true; }
            else { MessageBox.Show("enter proper date"); tempDate = false; }

            if (tempDate==false|| pictureBox1.Image==null || Mobile.Text.Count()!=10|| Full_Name.Text == "" || Address.Text.Trim() == "" || Mobile.Text == "" || Qualified.Text.Trim() == "" || Expirance.Text.Trim() == "" || Position.Text.Trim() == "" )
            {
                MessageBox.Show("insert all feeld");
                return false;
            }
            else
            { return true; }
        }
        public void clearAll()            //clear all user enter section
        {
            reg_no.Clear();
            Full_Name.Clear();
            Address.Clear();
            Mobile.Clear();
            Qualified.Text = "";
            Expirance.Text = "";
            Position.Text = "";
            Sall.Clear();
            DateTimePicker1.Value = DateTime.Now.Date;
            searchText.Text = "";
            pictureBox1.Image = null;
        }
     private void submit_Click(object sender, EventArgs e)    //submit or insert record
        {
            if (verify()&&verifyregno()&&verifySallary())
            {
                if (BL.operationIU(Convert.ToInt32(reg_no.Text.Trim()), Full_Name.Text.Trim(), Address.Text.Trim(), Mobile.Text, DateTimePicker1.Value.Date, Qualified.Text.Trim(), gender, Expirance.Text, Position.Text, img, "insert_Staff", Sall.Text.Trim()))
                {
                    MessageBox.Show("record insert successfully");
                    StaffdataGridView1.DataSource = BL.DataShow();
                    clearAll();
                    Result.Text = Convert.ToInt32(StaffdataGridView1.RowCount - 1) + " no of rows select";
                }
                else
                {
                    MessageBox.Show("check your reg no");   //retrive exception primary key only
                }
            }
        
        }

        private void RefreshButton_Click(object sender, EventArgs e)   //clear all user enter section or redisplay record
        {

            StaffdataGridView1.DataSource = BL.DataShow();
            Result.Text = Convert.ToInt32(StaffdataGridView1.RowCount - 1) + " no of rows select";
            clearAll();
        }

       
        int reg;
        bool verifyregno()           //verify reg no only use only delete record mainly
        {
            bool b1 = int.TryParse(reg_no.Text.Trim(), out reg);
            if (b1 == true&&reg>0)
                return true;
            else
            {
                MessageBox.Show("enter reg no proper");
                return false;
            }

        }
        private void delete_button_Click(object sender, EventArgs e)   //delete select row or enter row no only then press
        {
            if (verifyregno())
            {
                if (reg_no.Text.Trim()!= null)
                {
                    if (BL.deleteM(Convert.ToInt32(reg_no.Text)))
                    {
                        MessageBox.Show(reg_no.Text + " no record delete successfully");
                        StaffdataGridView1.DataSource = BL.DataShow();
                        clearAll();
                        Result.Text = Convert.ToInt32(StaffdataGridView1.RowCount - 1) + " no of rows select";
                    }
                }
            }
        }
   private void clear_button_Click(object sender, EventArgs e)     //clear all user enter section
        {
            clearAll();
        }
 

        private void Upload_Click(object sender, EventArgs e)        //upload image 
        {
            string imagelocation;
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "select photo(*.jpg;*.png,*.gif)|*.jpg;*.png*.gif";
                if(opf.ShowDialog()==System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = opf.FileName;
                    pictureBox1.ImageLocation = imagelocation;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("select image");
            }
        }
        byte[] photo;
        object o;
     
        private void StaffdataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)    //selected row text any cell then add data user enter  section
        {
            reg_no.Text = StaffdataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Full_Name.Text = StaffdataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Address.Text = StaffdataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Mobile.Text = StaffdataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            Qualified.Text = StaffdataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Expirance.Text = StaffdataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            Position.Text = StaffdataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            string gendr = StaffdataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            if (gendr.ToString() == "male")
            { male_rb.Checked = true; }
            else
            { female_rb.Checked = true; }
            DateTimePicker1.Value = Convert.ToDateTime(StaffdataGridView1.SelectedRows[0].Cells[8].Value.ToString());
            Sall.Text = StaffdataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            o = StaffdataGridView1.SelectedRows[0].Cells[10].Value;
            photo = (byte[])o;
            MemoryStream ms = new MemoryStream(photo);
            pictureBox1.Image = System.Drawing.Image.FromStream(ms);

        }

        private void update_Click(object sender, EventArgs e)         //update record selected row or enter data all correctly update
        {
            if (verifyregno()&&verify()&&verifySallary())
            {
                if (BL.operationIU(Convert.ToInt32(reg_no.Text.Trim()), Full_Name.Text.Trim(), Address.Text.Trim(), Mobile.Text, DateTimePicker1.Value.Date, Qualified.Text.Trim(), gender, Expirance.Text, Position.Text, img, "update_Staff", Sall.Text.Trim()))
                {
                    MessageBox.Show("record update successfully");
                    StaffdataGridView1.DataSource = BL.DataShow();
                    clearAll();
                    Result.Text = Convert.ToInt32(StaffdataGridView1.RowCount - 1) + " no of rows select";
                }
                else
                {
                    MessageBox.Show("check your reg no");
                }
            }
        }

        private void search_Button_Click(object sender, EventArgs e)     //enter reg no search record
        {
            int i;
            bool b = int.TryParse(searchText.Text.Trim(), out i);
            if (b==true)
            {
                StaffdataGridView1.DataSource = BL.searchShow(Convert.ToInt32(searchText.Text.Trim()));
                Result.Text = Convert.ToInt32(StaffdataGridView1.RowCount - 1) + " no of rows select";
                clearAll();
            }
        }

        private void Staff_RegistationForm_Load(object sender, EventArgs e)
        {
           
        }
    }
    }

