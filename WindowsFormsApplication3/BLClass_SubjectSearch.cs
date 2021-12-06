using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication3
{
    class BLClass_SubjectSearch
    {
        DBClass db = new DBClass();
        public object searchMLoad()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from subject_Table",db.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public object searchM(string Class, string division)
        {
            SqlDataAdapter da = new SqlDataAdapter("select RG_NO,subject_Code,Subject_Name,Teacher_Name,Qualified from subject_Table where Class='" + Class+"'and Division='"+division+"'", db.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
