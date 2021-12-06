using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication3
{
    class BLClassStaff_RPage
    {
        static DBClass d = new DBClass();
                                                 //insert and update method
        public bool operationIU(int rgno, string name, string LOCATION, string mobile, DateTime date, string QUALIFIED, string gender, string EXPIRANCE, String POSITION, byte[] photo, string oprIU, String SALLARY)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("select * from Staff_Table", d.connectM());
                d.openM();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = oprIU;
                cmd.Parameters.AddWithValue("@REG_NO", rgno);
                cmd.Parameters.AddWithValue("@NAME", name);
                cmd.Parameters.AddWithValue("@LOCATION", LOCATION);
                cmd.Parameters.AddWithValue("@MOBILE", mobile);
                cmd.Parameters.AddWithValue("@QUALIFIED", QUALIFIED);
                cmd.Parameters.AddWithValue("@EXPIRANCE", EXPIRANCE);
                cmd.Parameters.AddWithValue("@POSITION", POSITION);
                cmd.Parameters.AddWithValue("@GENDER", gender);
                cmd.Parameters.AddWithValue("@BIRTH_DATE", date);
                cmd.Parameters.AddWithValue("@SALLARY", SALLARY);
                cmd.Parameters.AddWithValue("@Photo", photo);
                cmd.ExecuteNonQuery();
                d.closeM();
                return true;
            }
            catch (Exception e)
            { return false; }

        }
             public bool deleteM(int rgno)           //delete one record at a time
        {

            SqlCommand cmd = new SqlCommand("select * from Staff_Table", d.connectM());
            d.openM();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_Staff";
            cmd.Parameters.AddWithValue("@REG_NO", rgno);
            cmd.ExecuteNonQuery();
            d.closeM();
            return true;
        }
        public object DataShow()                // display record on gridview control
        {
            SqlDataAdapter da = new SqlDataAdapter("select * From Staff_Table", d.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            object o = ds.Tables[0];
            return o;
        }
        public object searchShow(int regno)         //search regno record search
        {
            SqlDataAdapter da = new SqlDataAdapter("select * From Staff_Table where REG_NO=" + regno, d.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            object o = ds.Tables[0];
            return o;

        }


    }
}
