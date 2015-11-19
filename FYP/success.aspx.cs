using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FYP
{
    public partial class success : System.Web.UI.Page
    {
        public List<game> Games { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            //var query = (from u in db.user_datas
            //             where u.id ==Int32.Parse(Session["User"].ToString())
            //             select new
            //             {
            //                 u.first_name,
            //                 u.last_name,
            //             }).First();
            var user = db.user_datas.FirstOrDefault(a => a.id == Int32.Parse(Session["User"].ToString()));

            if (user != null)
            {
                //        Name.Text = user.first_name + " " + user.last_name;
                // Label1.Text = Session["ApplicationName"].ToString();
                //Name.Text = Session["a"].ToString();
            }
            //    //Session.Clear();
            //}
        }

        protected void Appbutton_Click(object sender, EventArgs e)
        {
            Label1.Text = Session["ApplicationName"].ToString();
            DataClasses1DataContext db = new DataClasses1DataContext();

            Games = db.games.Where(game => game.UserID == (int)Session["User"]).ToList();
        }

        protected void newapplications_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var user = db.user_datas.FirstOrDefault(a => a.id == Int32.Parse(Session["User"].ToString()));

            game g = new game();
            g.Api_path = "";
            g.Name = TxtNewGme.Text;
            db.games.InsertOnSubmit(g);

            g.UserID = user.id;
            db.SubmitChanges();




        }
        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    Session.Clear();
        //    Response.Redirect("Default.aspx");

        //}
    }
}