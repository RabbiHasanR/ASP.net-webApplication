using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IsPostBackProperty
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlCity.Items.Clear();
            /*if (!IsPostBack)
            {
                LoadCityDropDownList();
            }*/
            LoadCityDropDownList();
            
        }
        public void LoadCityDropDownList()
        {
            ListItem li1 = new ListItem("London");
            ddlCity.Items.Add(li1);
            ListItem li2 = new ListItem("Sydne");
            ddlCity.Items.Add(li2);
            ListItem li3 = new ListItem("Mumbai");
            ddlCity.Items.Add(li3);
        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write("Drop down list");
        }
    }
}
 