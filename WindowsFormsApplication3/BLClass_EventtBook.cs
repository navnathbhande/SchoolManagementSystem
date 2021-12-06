using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication3
{
    class BLClass_EventtBook
    {
        DBClass db = new DBClass();


        public bool operationIU(int event_no, string event_name, DateTime date, string money, string opr)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from event_Table", db.connectM());
                db.openM();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = opr;
                cmd.Parameters.AddWithValue("Event_No", event_no);
                cmd.Parameters.AddWithValue("Event_Name", event_name);
                cmd.Parameters.AddWithValue("Event_Date", date);
                cmd.Parameters.AddWithValue("Event_Money", money);
                cmd.ExecuteNonQuery();
                db.closeM();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool deleteM(int event_No)
        {
           
            {
                SqlCommand cmd = new SqlCommand("select * from event_Table", db.connectM());
                db.openM();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText ="delete_Event";
                cmd.Parameters.AddWithValue("Event_No", event_No);
                cmd.ExecuteNonQuery();
                db.closeM();
                return true;
            }
           
        }
        public object showData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from event_Table", db.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public object showEvent(string Event_name)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from event_Table where Event_Name='"+Event_name+"'", db.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
   


