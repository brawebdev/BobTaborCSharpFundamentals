﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_015
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            // http://is.gd/timespan\
            //Days.Hours:Minutes:Seconds.Milliseconds

            TimeSpan myTimeSpan = TimeSpan.Parse("1.2:3:30.5");

            DateTime myBirthday = DateTime.Parse("02/12/1990");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

            resultLabel.Text = myAge.Hours.ToString();

            resultLabel.Text = myAge.TotalDays.ToString();
        }
    }
}