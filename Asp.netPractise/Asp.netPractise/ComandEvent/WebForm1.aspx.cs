using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComandEvent
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Button1.Click += new EventHandler(Button1_Click);
            //Button1.Command += new CommandEventHandler(Button1_Command);
        }

        protected void CommandButton_Click(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Print":
                    OutputLabel1.Text = "You Click Print Button";
                    break;
                case "Delete":
                    OutputLabel1.Text = "You Click Delete Button";
                    break;
                case "Show":
                    if (e.CommandArgument.ToString() == "Top10")
                    {
                        OutputLabel1.Text = "You Click Show Top 10 Employee Button";
                    }
                    if (e.CommandArgument.ToString() == "Bottom10")
                    {
                        OutputLabel1.Text = "You Click Show Bottom Top 10 Employww Button";
                    }
                    break;
                default:
                    OutputLabel1.Text = "We don't know whick button click";
                    break;

            }
        }
    }
}