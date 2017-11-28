using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TextBoxControl
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Hello"+TextBox1.Text);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("Textbox changed");
        }
    }
}