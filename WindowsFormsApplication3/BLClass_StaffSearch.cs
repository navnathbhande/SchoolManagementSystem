using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication3
{

    class BLClass_StaffSearch
    {
        DBClass db = new DBClass();
        public object searchM()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Staff_Table", db.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public object searchStaff(int RG_NO)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Staff_Table where REG_NO='"+RG_NO+"'", db.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public object searchStaffPossition(string position)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Staff_Table where POSITION='" + position + "'order by NAME asc", db.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
      
    }
}
