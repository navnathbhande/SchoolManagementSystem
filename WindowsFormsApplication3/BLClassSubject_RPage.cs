using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication3
{
    class BLClassSubject_RPage
    {
        static DBClass d = new DBClass();              //create object of dbclas 

        //operationIU method operation insert update  
        public bool operationIU(int RG_NO,string Subject_Code,string Subject_Name,string Teacher_Name,string Qualified, string Class,string Division,string oprIU)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from subject_Table", d.connectM());   // connection access in dbclass
                d.openM();                                                                        //connection open method in dbclass                                      
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = oprIU;  //oprIU inset update prosedure name pass by string
                cmd.Parameters.AddWithValue("@RG_NO", RG_NO);
                cmd.Parameters.AddWithValue("@Subject_Code", Subject_Code);
                cmd.Parameters.AddWithValue("@Subject_Name", Subject_Name);
                cmd.Parameters.AddWithValue("@Teacher_Name", Teacher_Name);
                cmd.Parameters.AddWithValue("@Qualified", Qualified);
                cmd.Parameters.AddWithValue("@Class", Class);
                cmd.Parameters.AddWithValue("@Division", Division);
                cmd.ExecuteNonQuery();
                d.closeM();                                                                     //close method of dbclass
                return true;
            }
            catch
            {
                return false;
            }
          }
        //delete record of selected one row at a time
        public bool deleteM(int Rgno)                                                          //delete method of selected one row or enter valid regno
        {
            SqlCommand cmd = new SqlCommand("select * from subject_Table", d.connectM());
            d.openM();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_Subject";
            cmd.Parameters.AddWithValue("@RG_NO", Rgno);
            cmd.ExecuteNonQuery();
            d.closeM();
            return true;
    }
        public object DataShow()                                                          //data show method in gridview 
        {
            SqlDataAdapter da = new SqlDataAdapter("select * From subject_Table", d.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            object o = ds.Tables[0];
            return o;
        }
        public object searchShow(string search)                                           //search record using regno only
        {
            SqlDataAdapter da = new SqlDataAdapter("select * From subject_Table where Class='"+search+"'",d.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            object o = ds.Tables[0];
            return o;

        }

    }
}
