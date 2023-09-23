using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;




namespace WebApplication5
{
    public partial class home : System.Web.UI.Page
    {
        string sql;
        connect1 obj=new connect1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sql = "insert into REGIS values('"+TextBox1.Text+"','"+TextBox2.Text+"',"+TextBox3.Text+",'"+TextBox4.Text+"')";
            obj.insupdel(sql);
            sql = "insert into LOGIN values('"+TextBox5.Text+"','"+TextBox6.Text+ "','user')";
            obj.insupdel(sql);
            Label.Text = "data inserted sucessfully";
            Response.Redirect("login.aspx");

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {





        }
    }
}