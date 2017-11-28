using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
namespace CheckedBoxControl
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GraduateCheckBox.Focus();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder sbUserChoice = new StringBuilder();
            if (GraduateCheckBox.Checked)
            {
                sbUserChoice.Append(GraduateCheckBox.Text);
            }
             if (PostGraduateCheckBox.Checked)
            {
                sbUserChoice.Append(" ,"+PostGraduateCheckBox.Text);
            }
            if(DoctorateCheckBox.Checked)
            {
                sbUserChoice.Append(" ," + DoctorateCheckBox.Text);
            }

            Response.Write("Youe choice is "+sbUserChoice.ToString());
        }

        protected void GraduateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("Graduate chack box change");
        }
    }
}