﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FYP
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SetImageUrl();
            }

        }

      
        private void SetImageUrl()
        {
            Random _rand = new Random();
            int i = _rand.Next(1, 4);
         
            Image1.ImageUrl = "~/Images/" + i.ToString() + ".jpg";
        }

        protected void Timer1_Tick1(object sender, EventArgs e)
        {
            SetImageUrl();
        }
    }
}