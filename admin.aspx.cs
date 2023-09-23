using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class adamin : System.Web.UI.Page
    {
        connect1 obj=new connect1();
        string sql;//sql1;
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sql = "select *from LOGIN";
            DataSet ds = obj.displayall(sql);
            GridView2.DataSource = ds;
            GridView2.DataBind();


        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HOME.aspx");
        }
    }
}