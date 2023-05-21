using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _65_Indexers
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company company = new Company();

            Response.Write("Name of employee with id = 2 " + company[2]);
            Response.Write("<br />");
            Response.Write("Changing name of employee with id = 2");
            company[2] = "Pinna";
            Response.Write("<br />");
            Response.Write("Name of employee with id = 2 " + company[2]);
        }
    }
}