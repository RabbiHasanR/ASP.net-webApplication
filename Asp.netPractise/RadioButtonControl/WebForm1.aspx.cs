using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RadioButtonControl
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (MaleRadioButton.Checked)
            {
                Response.Write("Your gender is "+MaleRadioButton.Text+"</br>");
            }
            else if (FemaleRadioButton.Checked)
            {
                Response.Write("Your gender is "+FemaleRadioButton.Text+"</br>");
            }
            else
            {
                Response.Write("Your gender is "+UnknownRadioButton.Text+"</br>");
            }
        }

        protected void MaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("Male Radio Button changed"+"</br>");
        }
    }
}