using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FYP
{
    public partial class Afterlog : System.Web.UI.MasterPage
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            var user = db.user_datas.FirstOrDefault(a => a.id == Int32.Parse(Session["User"].ToString()));

            if (user != null)
            {
                Name.Text = user.first_name + " " + user.last_name;
                Label1.Text = Session["ApplicationName"].ToString();
                //Name.Text = Session["a"].ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Default.aspx");

        }
    }
}