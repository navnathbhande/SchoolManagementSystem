using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication3
{
   public class BLClassStudent_RPage
    {
        static  DBClass d = new DBClass();              //create object of dbclas 
        
      //operationIU method operation insert and update both
        public bool operationIU(int rgno, string name, string address, string prevcollage, string mobile, DateTime date, string Class, string gender, string gap, int fees, byte[] photo, string division, string transport, string academic_year, string oprIU,string medium,string Mother)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from StudentRG_Table", d.connectM());   // connection access in dbclass
                d.openM();                                                                        //connection open method in dbclass                                      
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = oprIU;                                                         //oprIU inset update prosedure name pass by string
                cmd.Parameters.AddWithValue("@REG_NO", rgno);
                cmd.Parameters.AddWithValue("@NAME", name);
                cmd.Parameters.AddWithValue("@LOCATION", address);
                cmd.Parameters.AddWithValue("@PREV_COLLAGE", prevcollage);
                cmd.Parameters.AddWithValue("@MOBILE", mobile);
                cmd.Parameters.AddWithValue("@BIRTH_DATE", date);
                cmd.Parameters.AddWithValue("@GENDER", gender);
                cmd.Parameters.AddWithValue("@GAP", gap);
                cmd.Parameters.AddWithValue("@CLASS", Class);
                cmd.Parameters.AddWithValue("@Division", division);
                cmd.Parameters.AddWithValue("@Transport", transport);
                cmd.Parameters.AddWithValue("@Academic_Year", academic_year);
                cmd.Parameters.AddWithValue("@Medium", medium);
                cmd.Parameters.AddWithValue("@PaidFee", fees);
                cmd.Parameters.AddWithValue("@Photo", photo);
                cmd.Parameters.AddWithValue("@MOTHER", Mother);
                cmd.ExecuteNonQuery();
                d.closeM();                                                                     //close method of dbclass
                return true;
            }
            catch (Exception)                                                                  //exception return regno of primary key
            { return false; }
        } 
        public bool deleteM(int rgno)                                                          //delete method of selected one row or enter valid regno
        {

            SqlCommand cmd = new SqlCommand("select * from StudentRG_Table", d.connectM());
            d.openM();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_StudReg";
            cmd.Parameters.AddWithValue("@REG_NO", rgno);
            cmd.ExecuteNonQuery();
            d.closeM();
            return true;


        }
        public object DataShow()                                                          //data show method in gridview 
        {
            SqlDataAdapter da = new SqlDataAdapter("select REG_NO,NAME,MOTHER,LOCATION,PREV_COLLAGE,MOBILE, BIRTH_DATE,GENDER,GAP,CLASS,Division,Transport,Academic_Year,Medium,PaidFee,Photo  From StudRG_Table", d.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            object o = ds.Tables[0];
            return o;
        }
        public object searchShow( int rollno)                                           //search record using regno only
        {
            SqlDataAdapter da = new SqlDataAdapter("select * From StudRG_Table where REG_NO="+rollno, d.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            object o = ds.Tables[0];
            return o;
            
        }
        public bool check_Class(string NewClass,string NewDivision)                                           //search record using regno only
        {
           
            SqlDataAdapter da = new SqlDataAdapter("select Class,Division From Fee_Table", d.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i,tmp=0,r=0;
            for(i=0;i<ds.Tables[0].Rows.Count;i++)
            {
                if(NewClass==ds.Tables[0].Rows[r][0].ToString()&&NewDivision==ds.Tables[0].Rows[r][1].ToString())
                {
                    tmp++;
                }
                r++;
            }
            if (tmp == 0)
                return false;
            else
                return true;
         }
        public bool check_Fee(string NewClass, string NewDivision,int fee)                                           //search record using regno only
        {

            SqlDataAdapter da = new SqlDataAdapter("select Fee From Fee_Table where Class='"+NewClass+"'and division='"+NewDivision+"'" , d.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            string s = ds.Tables[0].Rows[0][0].ToString();
            int feeTable = Convert.ToInt32(s);
            if (fee<=feeTable)
                return true;
            else
                return false;
        }
    }
    }

          


      
    
    
