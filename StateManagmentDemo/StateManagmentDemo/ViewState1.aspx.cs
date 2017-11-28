using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagmentDemo
{
    public partial class ViewState1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(ViewState["Click"] == null)
                {
                    ViewState["Click"] = 0;
                }
                TextBox1.Text = ViewState["Click"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int clickCount = (int)ViewState["Click"] + 1;
            TextBox1.Text = clickCount.ToString();
            ViewState["Click"] = clickCount;
        }
    }
}