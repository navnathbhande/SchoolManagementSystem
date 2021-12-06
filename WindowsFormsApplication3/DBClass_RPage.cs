using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication3
{
    class DBClass
    {
        // "select * from StudRG_Table"
        SqlConnection con = new SqlConnection(@"User Id=sa;Password=123;Database=school_Database;Data Source=DESKTOP-MMDBSFL");

        public SqlConnection connectM()
        {
            return con;
        }
        //connection method method.
        public void openM()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        //connection method closed
        public void closeM()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }
}
