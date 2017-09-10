using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeConditionalRadioButton
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
           if (pencilRadioButton.Checked)
            {
                resultImage.ImageUrl = "Images/pencil.png";
                resultLabel.Text = "You selected pencil!";
            }
           else if (penRadioButton.Checked)
            {
                resultImage.ImageUrl = "Images/pen.png";
                resultLabel.Text = "You selected pen!";
            }
           else if (phoneRadioButton.Checked)
            {
                resultImage.ImageUrl = "Images/phone.png";
                resultLabel.Text = "You selected phone!";
            }
           else if (tabletRadioButton.Checked)
            {
                resultImage.ImageUrl = "Images/tablet.png";
                resultLabel.Text = "You selected tablet!";
            }
            else
            {
                resultLabel.Text = "Please select an option!";
            }
        }
    }
}