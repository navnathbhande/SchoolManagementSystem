using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication3
{
    class BLClass_StudSearch
    {
        DBClass db = new DBClass();
       
        public object searchS(string Class,string Division,string Academic_Year)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select REG_NO,NAME,CLASS,Division,MOBILE,MOTHER,LOCATION,PREV_COLLAGE, BIRTH_DATE,GENDER,GAP,Transport,Academic_Year,Medium,PaidFee,PendingFee,Your_Fee,Photo From StudRG_Table where CLASS='" + Class + "'and Division='"+Division+"'and Academic_Year='" + Academic_Year + "'order by NAME asc", db.connectM());
    DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public object searchPendingFee(string Class, string Division, string Academic_Year)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select REG_NO,NAME,CLASS,Division,MOBILE,MOTHER,LOCATION,PREV_COLLAGE, BIRTH_DATE,GENDER,GAP,Transport,Academic_Year,Medium,PaidFee,PendingFee,Your_Fee,Photo From StudRG_Table where CLASS='" + Class + "'and Division='" + Division + "'and Academic_Year='" + Academic_Year + "'and PendingFee>0 order by NAME asc", db.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public object searchS1(string transport,string academic_year)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select REG_NO,NAME,CLASS,Division,MOBILE,MOTHER,LOCATION,PREV_COLLAGE, BIRTH_DATE,GENDER,GAP,Transport,Academic_Year,Medium,PaidFee,PendingFee,Your_Fee,Photo From StudRG_Table where Transport='" + transport + "'and Academic_Year='" + academic_year + "'order by NAME asc", db.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public object searchS2(string academic_year)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select REG_NO,NAME,CLASS,Division,MOBILE,MOTHER,LOCATION,PREV_COLLAGE, BIRTH_DATE,GENDER,GAP,Transport,Academic_Year,Medium,PaidFee,PendingFee,Your_Fee,Photo From StudRG_Table  where Academic_Year='" + academic_year+ "'order by NAME asc", db.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public object searchSLoadTime()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select REG_NO,NAME,CLASS,Division,MOBILE,MOTHER,LOCATION,PREV_COLLAGE, BIRTH_DATE,GENDER,GAP,Transport,Academic_Year,Medium,PaidFee,PendingFee,Your_Fee,Photo  From StudRG_Table order by NAME asc", db.connectM());
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

    }
}
