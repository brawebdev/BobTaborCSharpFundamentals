using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeFirstPapaBobsWebsite
{
    public partial class Defualt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            double total = 0;

            if (babyRadioButton.Checked)
                total = 10;
            else if (mamaRadioButton.Checked)
                total = 13;
            else if (papaRadioButton.Checked)
                total = 16;
            else
                totalLabel.Text = "Please select a option";

            total = (deepRadioButton.Checked) ? total + 2 : total;
            total = (pepperoniCheckBox.Checked) ? total + 1.5 : total;
            total = (onionsCheckBox.Checked) ? total + .75 : total;
            total = (greenPeppersCheckBox.Checked) ? total + .50 : total;
            total = (redPeppersCheckBox.Checked) ? total + .75 : total;
            total = (anchoviesCheckBox.Checked) ? total + 2 : total;

            if (pepperoniCheckBox.Checked && greenPeppersCheckBox.Checked && anchoviesCheckBox.Checked 
                || pepperoniCheckBox.Checked && redPeppersCheckBox.Checked && onionsCheckBox.Checked)
            {
                total -= 2;
            }

            totalLabel.Text = total.ToString();
        }
    }
}