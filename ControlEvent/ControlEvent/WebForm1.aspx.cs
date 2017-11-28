using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlEvent
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page PreInit" + "</br>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page Init" + "</br>");
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Page InitComplete" + "</br>");
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Page PreLoad" + "</br>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page load"+"</br>");
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("Page loadComplete" + "</br>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page PreRender" + "</br>");
        }
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write("Page PreRenderComplete" + "</br>");
        }
        //postBack Event
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Button click" + "</br>");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("textbox change"+"</br>");
        }
    }
}