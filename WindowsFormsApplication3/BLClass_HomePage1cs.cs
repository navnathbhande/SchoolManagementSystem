using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication3
{
    class BLClass_HomePage1cs
    {
        
        DBClass db = new DBClass();
        public object showRegNo(int RG_NO)
        {
            SqlDataAdapter da=new SqlDataAdapter("select  REG_NO, NAME, CLASS, Division, MOBILE, MOTHER, LOCATION, PREV_COLLAGE, BIRTH_DATE, GENDER, GAP, Transport, Academic_Year, Medium, PaidFee, PendingFee, Your_Fee, Photo  from StudRG_Table where REG_NO='"+RG_NO+"'",db.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public object showName(string Name,string academic_Year)
        {
            SqlDataAdapter da = new SqlDataAdapter("select  REG_NO, NAME, CLASS, Division, MOBILE, MOTHER, LOCATION, PREV_COLLAGE, BIRTH_DATE, GENDER, GAP, Transport, Academic_Year, Medium, PaidFee, PendingFee, Your_Fee, Photo  from StudRG_Table where NAME='" + Name + "'and Academic_Year='"+academic_Year+"'", db.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public void AddFee(int Regno,int Fee)
        {
            SqlCommand cmd = new SqlCommand("update table StudRG_Table", db.connectM());
            db.openM();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_FeeUpdate";
            cmd.Parameters.AddWithValue("REG_NO", Regno);
            cmd.Parameters.AddWithValue("PaidFee", Fee);
            cmd.ExecuteNonQuery();
            db.closeM();
        }
    }
   
}
