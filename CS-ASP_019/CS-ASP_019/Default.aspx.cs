using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_019
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            int socialSecurityNumber = int.Parse(ssTextBox.Text);
            double phone = double.Parse(phoneTextBox.Text);
            double salary = double.Parse(salaryTextBox.Text);
            resultLabel.Text = $"Thank you, {nameTextBox.Text}, for your business." +
                $"<br /> Your social security number is: {socialSecurityNumber:000-00-0000}" +
                $"<br /> Phone: {phone:(000) 000-0000}" +
                $"<br />Loan Date: {loanDateCalendar.SelectedDate:ddd -- d, M, yy}" +
                $"br />Salary: {salary:C}";
        }
    }
}