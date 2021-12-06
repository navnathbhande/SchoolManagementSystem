using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System .Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication3
{
    class BLClassFee_RPage
    {
        DBClass db = new DBClass();
       public  bool operationIU(int rgno,string Class,String Division,int Fee,string opr)
        {try
            {
                SqlCommand cm = new SqlCommand("select * From fee_Table", db.connectM());
                db.openM();
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = opr;
                cm.Parameters.AddWithValue("RG_NO", rgno);
                cm.Parameters.AddWithValue("Class", Class);
                cm.Parameters.AddWithValue("Division", Division);
                cm.Parameters.AddWithValue("Fee", Fee);
                cm.ExecuteNonQuery();
                db.closeM();
                return true;
            }
            catch(Exception)
            {
                return false;
            }

        }
        public bool single_Fee_Update(string Class, String Division, int Fee)
        {
            SqlCommand cm = new SqlCommand("select * From fee_Table", db.connectM());
            db.openM();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText ="single_Fee_Update";
            cm.Parameters.AddWithValue("Class", Class);
            cm.Parameters.AddWithValue("Division", Division);
            cm.Parameters.AddWithValue("Fee", Fee);
            cm.ExecuteNonQuery();
            db.closeM();
            return true;
        }
      public  bool deleteM(int regno)
        {
            SqlCommand cm = new SqlCommand("select * from fee_Table",db.connectM());
            db.openM();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "delete_Fee";
            cm.Parameters.AddWithValue("RG_NO", regno);
            cm.ExecuteNonQuery();
            db.closeM();
            return true;
        }
        public object showData()
        {
            object o;
            SqlDataAdapter da = new SqlDataAdapter("select * From fee_Table", db.connectM());
            DataSet d = new DataSet();
            da.Fill(d);
            o = d.Tables[0];
            return o;
        }
        public object searchShow(string searchClass)                                           //search record using regno only
        {
            SqlDataAdapter da = new SqlDataAdapter("select * From fee_Table where Class='" + searchClass + "'", db.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            object o = ds.Tables[0];
            return o;

        }
        public bool check_Class(string NewClass, string NewDivision)                                           //search record using regno only
        {

            SqlDataAdapter da = new SqlDataAdapter("select Class,Division From Fee_Table", db.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i, tmp = 0, r = 0;
            for (i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (NewClass == ds.Tables[0].Rows[r][0].ToString() && NewDivision == ds.Tables[0].Rows[r][1].ToString())
                {
                    tmp++;
                }
                r++;
            }
            if (tmp == 0)
                return true;
            else
                return false;
        }

    }
}
