using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication3
{
   
    class BLClass_Clear
    {
        DBClass db = new DBClass();
        public void studentClear()
        {
            SqlCommand cmd = new SqlCommand("select * from StudRG_Table", db.connectM());
            db.openM();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "truncateStudent";
            cmd.ExecuteNonQuery();
            db.closeM();
        }
        public void staffClear()
        {
            SqlCommand cmd = new SqlCommand("select * from StudRG_Table", db.connectM());
            db.openM();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "truncateStaff";
            cmd.ExecuteNonQuery();
            db.closeM();
        }
        public void subjectClear()
        {
            SqlCommand cmd = new SqlCommand("select * from StudRG_Table", db.connectM());
            db.openM();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "truncateSubject";
            cmd.ExecuteNonQuery();
            db.closeM();
        }
        public void feeClear()
        {
            SqlCommand cmd = new SqlCommand("select * from StudRG_Table", db.connectM());
            db.openM();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "truncateFee";
            cmd.ExecuteNonQuery();
            db.closeM();
        }
       
        public void eventClear()
        {
            SqlCommand cmd = new SqlCommand("select * from event_Table", db.connectM());
            db.openM();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "truncate_Event";
            cmd.ExecuteNonQuery();
            db.closeM();
        }
       public void AddRemoveAcademicYear(string Academic_Year,string obj)
        {
            SqlCommand cmd = new SqlCommand("select * from Change_Table", db.connectM());
            db.openM();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = obj;
            cmd.Parameters.AddWithValue("Academic_Year", Academic_Year); 
            cmd.ExecuteNonQuery();
            db.closeM();
        }
       
    }
}
