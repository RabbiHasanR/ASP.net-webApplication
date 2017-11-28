using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagmentDemo
{
    public partial class SessionState1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Click"] == null)
                {
                    Session["Click"] = 0;
                }
                TextBox1.Text = Session["Click"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int clickCount = (int)Session["Click"] + 1;
            TextBox1.Text = clickCount.ToString();
            Session["Click"] = clickCount;
        }
    }
}