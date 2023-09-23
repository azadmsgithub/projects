using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class login : System.Web.UI.Page
    {
        string sql;
        connect1 obj = new connect1();
        SqlDataReader rdr;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("registration.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                sql = "select usertype from LOGIN where USERNAME='" + TextBox1.Text + "' and PASSWORD='" + TextBox2.Text + "'";
                string t = obj.select(sql);
                rdr = obj.Readerrtn(sql);
                rdr.Read();

                if (t == "admin")
                {
                    Response.Redirect("user.aspx");
                }
                else 

                {

                    Response.Redirect("admin.aspx");

                }













            }
            catch(Exception) 
            {





            }

        }
    }

}



