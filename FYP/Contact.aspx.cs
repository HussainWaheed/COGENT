using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FYP
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"]==null)
                Response.Redirect("log.aspx");
       } 

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            
            suggestion su = new suggestion();

           su.message_box = TextBoxmessage.Text;
            su.Full_name = TextBoxCont_Name.Text;
           su.Email = TextBoxContEmail.Text;
            su.user_id = db.user_datas.FirstOrDefault(a => a.id == Int32.Parse(Session["User"].ToString())).id;
            var user= db.user_datas.FirstOrDefault(a => a.id == Int32.Parse(Session["User"].ToString())).first_name;

            db.suggestions.InsertOnSubmit(su);
           db.SubmitChanges();

        }
    }
}