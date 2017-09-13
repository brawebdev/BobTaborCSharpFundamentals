using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //if (firstCalendar.SelectedDate > secondCalendar.SelectedDate)
            //{
            //    TimeSpan result = firstCalendar.SelectedDate - secondCalendar.SelectedDate;
            //    resultLabel.Text = result.TotalDays.ToString();
            //}
            //else if (firstCalendar.SelectedDate < secondCalendar.SelectedDate)
            //{
            //    TimeSpan result = secondCalendar.SelectedDate - firstCalendar.SelectedDate;
            //    resultLabel.Text = result.TotalDays.ToString();
            //}

            //This is another way to complete the challenge
            if (firstCalendar.SelectedDate > secondCalendar.SelectedDate)
            {
                resultLabel.Text = firstCalendar.SelectedDate
                    .Subtract(secondCalendar.SelectedDate)
                    .TotalDays.ToString();
            }
            else
            {
                resultLabel.Text = secondCalendar.SelectedDate
                    .Subtract(firstCalendar.SelectedDate)
                    .TotalDays.ToString();
            }
        }
    }
}