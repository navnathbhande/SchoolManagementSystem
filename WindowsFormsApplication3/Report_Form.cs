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
    public partial class Report_Form : Form
    { BLClass_Report bl = new BLClass_Report();
        public Report_Form()
        {
            InitializeComponent();
        }

        private void showReportAcademicYear_Click(object sender, EventArgs e)
        {
            int TEM;
            string TFee, TPFee, TPEFee, TSS, TS, TB, TG, TSF,TE;
            bl.showReportAcademic(AcademicYearA.Text, out TFee, out TPFee, out TPEFee, out TSS, out TEM, out TS, out TB, out TG, out TSF,out TE);
             
                Total_Fee.Text = TFee;
                Total_Paid_Fee.Text = TPFee;
                Total_Pending_Fee.Text = TPEFee;
                Total_Staff_Sallary.Text = TSS;
                Total_Event_Money.Text =Convert.ToString( TEM);
                Total_Student.Text = TS;
                Total_Boys.Text = TB;
                Total_Girl.Text = TG;
                Total_Staff.Text = TSF;
                Total_Event.Text = TE;
     }

        private void Show_Button_CD_Click(object sender, EventArgs e)
        {
            string TS, TB, TG;
            bl.show_CD(academic_year.Text, Class.Text, division.Text, out TS, out TB, out TG);
                Total_Student_CD.Text = TS;
                Total_Boys_CD.Text = TB;
                Total_Girl_CD.Text = TG;
        }

        private void Report_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'school_DatabaseDataSet3.Change_Table' table. You can move, or remove it, as needed.
            this.change_TableTableAdapter.Fill(this.school_DatabaseDataSet3.Change_Table);
        }
    }
    }

