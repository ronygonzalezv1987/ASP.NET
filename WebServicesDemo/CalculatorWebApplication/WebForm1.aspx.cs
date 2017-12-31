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

        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            CalculatorService.CalculatorWebServicesSoapClient client = new CalculatorService.CalculatorWebServicesSoapClient();
            int result = client.Add(Convert.ToInt32(txtFirstNumber.Text), Convert.ToInt32(txtSecondNumber.Text));
            lblResult.Text = result.ToString();
            gvCalculations.DataSource = client.GetCalculations();
            gvCalculations.DataBind();
            gvCalculations.HeaderRow.Cells[0].Text = "Recent Calculations";

        }
    }
}