using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using NPoco.Expressions;
using System.Web.UI.WebControls;


namespace WebApplication5
{
    public class connect1
    {
        SqlCommand cmd;
        SqlDataReader rdr;
        SqlDataAdapter adp;
        public SqlConnection connect()
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PRO\\source\\repos\\WebApplication5\\WebApplication5\\App_Data\\Database1.mdf;Integrated Security=True");
            conn.Open();
            return conn;



        }
        public void insupdel (string str)
        {

            cmd=new SqlCommand(str,connect());
            cmd.ExecuteNonQuery();
        }
        public DataSet displayall(string str)
        {
            adp = new SqlDataAdapter(str, connect());
            DataSet ds=new DataSet();
            adp.Fill(ds);
            return ds;



        }
        public SqlDataReader Readerrtn(string str) 
        { 
            cmd=new SqlCommand (str,connect());
            rdr = cmd.ExecuteReader();
            return rdr;
        
        
        
        }
        public string select(string str) 
        {
            string t;
            cmd= new SqlCommand(str,connect()); 
            rdr=cmd.ExecuteReader();
            rdr.Read();
            t=rdr.GetSqlValue(0).ToString();
            rdr.Close();
            return t;
        
        
        
        
        }
            
          
       
    }
}
 