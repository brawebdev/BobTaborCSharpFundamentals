using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void additionButton_Click(object sender, EventArgs e)
        {
            double first = double.Parse(firstTextBox.Text);
            double second = double.Parse(secondTextBox.Text);

            resultLabel.Text = (first + second).ToString();
        }

        protected void subtractButton_Click(object sender, EventArgs e)
        {
            double first = double.Parse(firstTextBox.Text);
            double second = double.Parse(secondTextBox.Text);

            resultLabel.Text = (first - second).ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            double first = double.Parse(firstTextBox.Text);
            double second = double.Parse(secondTextBox.Text);

            resultLabel.Text = (first * second).ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            double first = double.Parse(firstTextBox.Text);
            double second = double.Parse(secondTextBox.Text);

            resultLabel.Text = (first / second).ToString();
        }
    }
}