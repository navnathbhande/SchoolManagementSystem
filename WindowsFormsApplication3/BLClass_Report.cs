using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication3
{
    
    class BLClass_Report
    {
        DBClass db = new DBClass();
        public void showReportAcademic(string Academic_year,out string Total_Fee,out string Total_paid_Fee,out string Total_Pending_Fee,out string Total_Staff_Sallary,out int Total_Event_Money,out string Total_Student,out string Total_Boys,out string Total_Girls,out string Total_Staff,out string Total_Event)
        {
            SqlDataAdapter da = new SqlDataAdapter("select sum(Your_Fee),sum(PaidFee),sum(PendingFee) From StudRG_Table where Academic_Year='" + Academic_year + "'", db.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds,"Tabel1");
            Total_Fee = ds.Tables[0].Rows[0][0].ToString();
            Total_paid_Fee= ds.Tables[0].Rows[0][1].ToString();
            Total_Pending_Fee = ds.Tables[0].Rows[0][2].ToString();
            string M = "male", F = "Female";       
            SqlDataAdapter da1 = new SqlDataAdapter("select count(NAME) From StudRG_Table where Academic_Year='" + Academic_year + "'and GENDER='"+M+"'", db.connectM());
            da1.Fill(ds, "Table2");
            Total_Boys= ds.Tables[1].Rows[0][0].ToString();
            SqlDataAdapter da2 = new SqlDataAdapter("select count(NAME) From StudRG_Table where Academic_Year='" + Academic_year + "'and GENDER='" +F+ "'", db.connectM());
            da2.Fill(ds, "Table3");
            Total_Girls = ds.Tables[2].Rows[0][0].ToString();
            SqlDataAdapter da3 = new SqlDataAdapter("select count(NAME) From StudRG_Table where Academic_Year='" + Academic_year + "'", db.connectM());
            da3.Fill(ds,"Table4");
            Total_Student = ds.Tables[3].Rows[0][0].ToString();
            SqlDataAdapter da4 = new SqlDataAdapter("select count(NAME) From Staff_Table ", db.connectM());
            da4.Fill(ds,"Table5");
            Total_Staff = ds.Tables[4].Rows[0][0].ToString();
            SqlDataAdapter da5 = new SqlDataAdapter("select sum(SALLARY) From Staff_Table", db.connectM());
            da5.Fill(ds,"Table6");
            Total_Staff_Sallary = ds.Tables[5].Rows[0][0].ToString();
            SqlDataAdapter da6 = new SqlDataAdapter("select sum(Event_Money) From Event_Table", db.connectM());
            da6.Fill(ds,"Table7");
            int i = Convert.ToInt32(ds.Tables[6].Rows[0][0].ToString());
            Total_Event_Money = i;
            SqlDataAdapter da7 = new SqlDataAdapter("select count(Event_No) from event_Table", db.connectM());
            da7.Fill(ds, "Table8");
            Total_Event = ds.Tables[7].Rows[0][0].ToString();
        }
        public void show_CD(string Academic_Year,string Class,String Division, out string Total_Student, out String Total_Boys, out string Total_Girls)
        {
            SqlDataAdapter da = new SqlDataAdapter("select count(NAME) from StudRG_Table where CLASS='"+Class+"'and Division='"+Division+"'", db.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds, "Table0");
            Total_Student = ds.Tables[0].Rows[0][0].ToString();
            SqlDataAdapter da1 = new SqlDataAdapter("select count(NAME) from StudRG_Table where CLASS='" + Class + "'and Division='" + Division + "'and GENDER='"+"Male"+"'", db.connectM());
            da1.Fill(ds, "Table1");
            Total_Boys = ds.Tables[1].Rows[0][0].ToString();
            SqlDataAdapter da2 = new SqlDataAdapter("select count(NAME) from StudRG_Table where CLASS='" + Class + "'and Division='" + Division + "'and GENDER='" + "Female" + "'", db.connectM());
            da2.Fill(ds, "Table2");
            Total_Girls = ds.Tables[2].Rows[0][0].ToString();
        }
    }
}
