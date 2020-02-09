using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //here we will make an instance of the 
            //proxy class that is provided to us when we
            //Added the webservice to this project.
            //to find the name of that proxy class
            //click on the project-> show all files button
            /*
             * then go to Connected Services
             * CalculatorService
             * Expand the Reference.svcmap
             * Click on Reference.cs
             * You will see on partial public class
             * CalculatorWebServiceSoapClient
             */
            //make sure to check the Namespace of the webservice
            //partial / proxy class, you might need to import the namespace first.
            //for this example we are already in namespace: CalculatorWebApplication.CalculatorService
            CalculatorService.CalculatorWebServiceSoapClient client =
                new CalculatorService.CalculatorWebServiceSoapClient();
            int result = client.Add(Convert.ToInt32(txtFirstNum.Text), Convert.ToInt32(txtSecondNum.Text));
            lblResult.Text = result.ToString();

        }
    }
}