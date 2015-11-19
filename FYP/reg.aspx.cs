using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FYP
{
    public partial class reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            user_data us = new user_data();
            var ug = new user_game();


                us.first_name = TextBoxName.Text;
            us.last_name = TextBoxLast_N.Text;
            us.user_email = TextBoxEmail.Text;
            us.user_password = TextBoxPassword.Text;
            us.user_c_password = TextBoxconfirmpass.Text;
            us.user_application = TextBoxApp_Name.Text;
            //ug.game_id = db.games.Where(x => x.Name == TextBoxApp_Name.Text).FirstOrDefault();

            db.user_datas.InsertOnSubmit(us);
            db.SubmitChanges();
            Session["User"] = us.id;
            Response.Redirect("Log.aspx");
            
        }
        
    }
}