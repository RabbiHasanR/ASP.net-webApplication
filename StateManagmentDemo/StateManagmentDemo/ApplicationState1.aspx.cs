using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagmentDemo
{
    public partial class ApplicationState1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Application["Click"] == null)
                {
                   Application["Click"] = 0;
                }
                TextBox1.Text = Application["Click"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int clickCount = (int)Application["Click"] + 1;
            TextBox1.Text = clickCount.ToString();
            Application["Click"] = clickCount;
        }
    }
}