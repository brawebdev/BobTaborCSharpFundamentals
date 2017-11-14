using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                previousAssignmentCalendar.SelectedDate = DateTime.Now.Date;
                endOfNewAssignmentCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
                newAssignmentCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
            }
        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            double rangeBetweenDates = newAssignmentCalendar.SelectedDate.Subtract(previousAssignmentCalendar.SelectedDate).TotalDays; 
            double assignmentLength = endOfNewAssignmentCalendar.SelectedDate.Subtract(newAssignmentCalendar.SelectedDate).TotalDays;
            double budgetTotal = assignmentLength * 500;

            if (rangeBetweenDates < 14)
            {
                resultLabel.Text = "Error: Must allow at least two weeks between previous assignment and new assignment";
                newAssignmentCalendar.SelectedDate = previousAssignmentCalendar.SelectedDate.AddDays(14);
                return;
            }
            
            if (assignmentLength >= 21)
            {
                budgetTotal += 1000;
            }
           
            resultLabel.Text = "Assignment of " + CodeNameTextBox.Text + " to assignment project: " + assignmentNameTextBox.Text + ". Budget total: " + budgetTotal;
        }
    }
}