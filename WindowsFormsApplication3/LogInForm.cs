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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            string user = "navnath";
            string password = "1234";
            if (User_Name.Text == user && Password.Text == password)
            {
                MainPage mp = new MainPage();
                this.Hide();
                mp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Your user name and password incorrect");
            }
        }
       public void closeM()
        {
            Application.Exit();
        }

        private void LoginCloseLabel_Click(object sender, EventArgs e)
        {
            closeM();
        }
    }
}
