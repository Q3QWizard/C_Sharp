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

            Response.Write("Total Male Employees = " + company["Male"]);
            Response.Write("Total Female Employees = " + company["Female"]);

            Response.Write("<br />");
            Response.Write("Changing details");
            Response.Write("<br />");
            company["Male"] = "Female";
            company["Female"] = "Male";

            Response.Write("Total Male Employees = " + company["Male"]);
            Response.Write("<br />");
            Response.Write("Total Female Employees = " + company["Female"]);
            Response.Write("<br />");
            Response.Write(company[2]);
        }
    }
}