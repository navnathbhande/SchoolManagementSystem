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
    public partial class EventBook_Form : Form
    {
        BLClass_EventtBook bl = new BLClass_EventtBook();
        public EventBook_Form()
        {
            InitializeComponent();
           
            eventdataGridView.DataSource = bl.showData();
            Result.Text = Convert.ToInt32(eventdataGridView.RowCount - 1) + " no of rows select";
        }
        void clearAll()
        {
            Event_No.Clear();
            Event_Name.Clear();
            dateTimePicker1.Value = DateTime.Now.Date;
            Money.Clear();
        }
        bool verifyMoney()
        {
            int i;
            bool b = int.TryParse(Money.Text.Trim(), out i);
            if (b == true && i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool verify()
        {
           
            if (Event_Name.Text.Trim()=="")
            {
                MessageBox.Show("enter Event name");
                return false;
            }
            else
            { return true; }
        }
        private void clear_button_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        bool verifyregno()
        {
        int i;
            bool b = int.TryParse(Event_No.Text.Trim(), out i);
            if(b==true&&i>0)
            {
            
                return true;
            }
            else {
                MessageBox.Show("insert event no proper");
                return false;
            }
        }
        private void update_button_Click(object sender, EventArgs e)
        {
            if(verifyregno()&&verify()&&verifyMoney())
            {
                bl.operationIU(Convert.ToInt32(Event_No.Text.Trim()), Event_Name.Text.Trim(), dateTimePicker1.Value, Money.Text.Trim(),"update_Event");
                MessageBox.Show("update event successfull");
                clearAll();
                eventdataGridView.DataSource = bl.showData();
                Result.Text = Convert.ToInt32(eventdataGridView.RowCount - 1) + " no of rows select";
            }
            else
            {
                MessageBox.Show("do not update event no");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (verifyregno() )
            {
                bl.deleteM(Convert.ToInt32(Event_No.Text.Trim()));
                MessageBox.Show("event delete successfull");
                clearAll();
                eventdataGridView.DataSource = bl.showData();
                Result.Text = Convert.ToInt32(eventdataGridView.RowCount - 1) + " no of rows select";
            }
            else
            {
                MessageBox.Show("enter event no value properly");
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (verifyregno() && verify()&&verifyMoney())
            {
               if( bl.operationIU(Convert.ToInt32(Event_No.Text.Trim()), Event_Name.Text.Trim(), dateTimePicker1.Value, Money.Text.Trim(), "insert_Event"))
                { MessageBox.Show("insert event successfull");
                    clearAll();
                    eventdataGridView.DataSource = bl.showData();
                    Result.Text = Convert.ToInt32(eventdataGridView.RowCount - 1) + " no of rows select";
                }
               else
                {
                    MessageBox.Show("these no allreddy available in table insert another event no");
                }
                
                     
            }
              
        }
        private void eventdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Event_No.Text = eventdataGridView.SelectedRows[0].Cells[0].Value.ToString();
              Event_Name.Text= eventdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            dateTimePicker1.Value=Convert.ToDateTime( eventdataGridView.SelectedRows[0].Cells[2].Value.ToString());
            Money.Text= eventdataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }
        bool verifyEvent_Search()
        {
            if (eventname.Text != null)
                return true;
            else
                return false;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (verifyEvent_Search())
            {
                eventdataGridView.DataSource = bl.showEvent(eventname.Text.Trim());
                eventname.Text = "";
                Result.Text = Convert.ToInt32(eventdataGridView.RowCount - 1) + " no of rows select";
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            eventdataGridView.DataSource = bl.showData();
            Result.Text = Convert.ToInt32(eventdataGridView.RowCount - 1) + " no of rows select";
        }
    }
}
