using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;                       //use for memorystream
namespace WindowsFormsApplication3
{
    public partial class Student_RegistationForm : Form
    {
        BLClassStudent_RPage bl = new BLClassStudent_RPage();    //object create of blclass
        
        public Student_RegistationForm()
        {
            InitializeComponent();
            RegistationGV.DataSource = bl.DataShow();           //data show in load time
            Result.Text = Convert.ToInt32(RegistationGV.RowCount - 1) + " no of rows select";
        }
        int fee;
        string gender;
        byte[] img;
        bool verifyFee()
        {
            bool b = int.TryParse(Fees.Text.Trim(), out fee);

            //check fees
            if (b == true && fee >= 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("enter fees proper");
                return false;
            }
        }
        private bool verify()                         //   verify all
        {
           
            int pdate = DateTimePicker1.Value.Year;
            int adate = DateTime.Now.Year;
            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();                     // convert image to byte formate
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
            //check all user enter section validation
            if (tempDate==false||pictureBox1.Image==null || Mobile.Text.Count()!=10|| Full_Name.Text.Trim() == "" || Address.Text.Trim() == "" || prev_collage.Text.Trim() == "" || Mobile.Text == "" || Class.Text.Trim() == "" || Gap.Text.Trim() == "" || division.Text.Trim() == "" || transport.Text.Trim() == "" || academic_year.Text.Trim() == "")
            {
                MessageBox.Show("insert all feeld");
                return false;
            }
            else
            { return true; }
        }
        int reg;
        bool verifyregno()      //verify regno he is mainly use in row delete using regno
            {
            bool b1=int .TryParse(reg_no.Text.Trim(),out reg);
            if (b1 == true&&reg>0)
                return true;
            else
            {
                MessageBox.Show("enter reg no proper");
                return false;
            }
        }
       
        byte[] photo;
        object o;
        private void RegistationGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            reg_no.Text = RegistationGV.SelectedRows[0].Cells[0].Value.ToString();
            Full_Name.Text = RegistationGV.SelectedRows[0].Cells[1].Value.ToString();
            Mother.Text = RegistationGV.SelectedRows[0].Cells[2].Value.ToString();
            Address.Text = RegistationGV.SelectedRows[0].Cells[3].Value.ToString();
            prev_collage.Text = RegistationGV.SelectedRows[0].Cells[4].Value.ToString();
            Mobile.Text = RegistationGV.SelectedRows[0].Cells[5].Value.ToString();

            DateTimePicker1.Value= Convert.ToDateTime(RegistationGV.SelectedRows[0].Cells[6].Value.ToString());
            
           string gendr=RegistationGV.SelectedRows[0].Cells[7].Value.ToString();
            if(gendr.ToString()=="male")
            { male_rb.Checked = true; }
            else
            { female_rb.Checked = true; }
            Gap.Text = RegistationGV.SelectedRows[0].Cells[8].Value.ToString();
            Class.Text = RegistationGV.SelectedRows[0].Cells[9].Value.ToString();
            division.Text = RegistationGV.SelectedRows[0].Cells[10].Value.ToString();
            transport.Text = RegistationGV.SelectedRows[0].Cells[11].Value.ToString();
            academic_year.Text = RegistationGV.SelectedRows[0].Cells[12].Value.ToString();
            Medium.Text= RegistationGV.SelectedRows[0].Cells[13].Value.ToString();
            Fees.Text = RegistationGV.SelectedRows[0].Cells[14].Value.ToString();
            o = RegistationGV.SelectedRows[0].Cells[15].Value;
            photo = (byte[])o;
            MemoryStream ms = new MemoryStream(photo);
            pictureBox1.Image = System.Drawing.Image.FromStream(ms);
           
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            string imagelocation;
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "select photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
                if (opf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = opf.FileName;
                    pictureBox1.ImageLocation = imagelocation;

                }

            }
            catch (Exception)
            {
                MessageBox.Show("error image");
            }
         
    }
        
        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (verify()&&verifyregno()&&verifyFee())
                {
                    if (bl.check_Class(Class.Text, division.Text))
                    {
                        if (bl.check_Fee(Class.Text, division.Text, fee))
                        {
                            if (bl.operationIU(Convert.ToInt32(reg_no.Text.Trim()), Full_Name.Text.Trim(), Address.Text.Trim(), prev_collage.Text.Trim(), Mobile.Text, DateTimePicker1.Value, Class.Text, gender, Gap.Text, fee, img, division.Text, transport.Text, academic_year.Text, "update_StudReg",Medium.Text.Trim(),Mother.Text.Trim()))//f means fees
                              {
                               MessageBox.Show("record update successfully");
                               Result.Text = Convert.ToInt32(RegistationGV.RowCount - 1) + " no of rows select";
                                 clearAll();
                                }
                                else
                                {
                                  MessageBox.Show("enter proper Roll_no ");
                                }
                        }
                        else
                        {
                            MessageBox.Show(Class.Text + " " + division.Text + " " + fee + " is more than fee limit");
                        }
                    }
                    else { MessageBox.Show(Class.Text + " " + division.Text + " not available record in fee table"); }

                    RegistationGV.DataSource = bl.DataShow();//bl is BLclass object

                }
            }
            catch(Exception)     //catch exception of image
            {
                MessageBox.Show("select image");
            }
        }
       
        private void delete_button_Click(object sender, EventArgs e)       //delete selected row or regno valid enter
        {   if (verifyregno())
            {
                if (reg_no.Text.Trim() != null)
                {
                    if (bl.deleteM(Convert.ToInt32(reg_no.Text.Trim())))
                    {
                        MessageBox.Show(reg_no.Text + " no record delete successfully");
                        RegistationGV.DataSource = bl.DataShow();//bl is BLclass object
                        clearAll();
                        Result.Text = Convert.ToInt32(RegistationGV.RowCount - 1) + " no of rows select";
                    }
                }
            }
        
        }

        public void clearAll()   // clear all user enter section
        {
            reg_no.Clear();
            Full_Name.Clear();
            Address.Clear();
            prev_collage.Clear();
            Mobile.Clear();
            Gap.Text = "";
            Class.Text = "";
            division.Text = "";
            transport.Text = "";
            academic_year.Text = "";
            Fees.Clear();
            Medium.Text = "";
            DateTimePicker1.Value = DateTime.Now.Date;
            searchText.Clear();
            pictureBox1.Image = null;
            Mother.Clear();
        }

        private void RefreshButton_Click(object sender, EventArgs e)    //redisplay all record or clear user enter section
        {
            RegistationGV.DataSource = bl.DataShow();
            clearAll();
            Result.Text = Convert.ToInt32(RegistationGV.RowCount - 1) + " no of rows select";
        }

      
     private void clear_button_Click(object sender, EventArgs e)         //clear  button click clear all user enter section
        {
            clearAll();
        }

        private void submit_Click(object sender, EventArgs e)              //submit or insert record
        {
           
            try
            {
                if (verify() && verifyregno() && verifyFee())
                {
                    if (bl.check_Class(Class.Text, division.Text))
                    {
                        if (bl.check_Fee(Class.Text, division.Text, fee))
                        {
                            if (bl.operationIU(Convert.ToInt32(reg_no.Text.Trim()), Full_Name.Text.Trim(), Address.Text.Trim(), prev_collage.Text.Trim(), Mobile.Text, DateTimePicker1.Value, Class.Text, gender, Gap.Text, fee, img, division.Text, transport.Text, academic_year.Text, "insert_StudReg", Medium.Text, Mother.Text.Trim()))//f means fees
                            {
                                MessageBox.Show("record insert successfully");
                                clearAll();
                                Result.Text = Convert.ToInt32(RegistationGV.RowCount - 1) + " no of rows select";
                            }
                            else                                                    //return exception regno primary key
                            {
                                MessageBox.Show("Enter proper reg no ");
                            }
                            RegistationGV.DataSource = bl.DataShow();//bl is BLclass object
                        }
                        else
                        {
                            MessageBox.Show(Class.Text + " " + division.Text + " " + fee + " is more than fee limit");
                        }
                    }
                    else { MessageBox.Show(Class.Text + " " + division.Text + " not available record in fee table"); }
                }
            }


            catch (Exception)                            //return emage exception return
            {
                MessageBox.Show("select image");
            }
        
        }

        private void Searchbutton_Click_1(object sender, EventArgs e)
        {
            int i;
            bool b = int.TryParse(searchText.Text.Trim(), out i);
            if (b == true)
            {
                RegistationGV.DataSource = bl.searchShow(Convert.ToInt32(searchText.Text.Trim()));
                Result.Text = Convert.ToInt32(RegistationGV.RowCount - 1) + " no of rows select";
                clearAll();
            }
        }

        private void Student_RegistationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'school_DatabaseDataSet1.Change_Table' table. You can move, or remove it, as needed.
            this.change_TableTableAdapter.Fill(this.school_DatabaseDataSet1.Change_Table);

        }
    }
}



