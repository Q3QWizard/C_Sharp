using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PartialClasses
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Customer c1 = new Customer();
            //c1.FirstName = "Wasindu";
            //c1.LastName = "Desitha";
            //string FullName1 = c1.GetFullName();
            //Response.Write("Full Name =" + FullName1 + "<br/>");

            PartialCustomer c2 = new PartialCustomer();
            c2.FirstName = "Vidura";
            c2.LastName = "Bhashana";
            string FullName2 = c2.GetFullName();
            Response.Write(FullName2 + "<br/>");
        }
    }
}