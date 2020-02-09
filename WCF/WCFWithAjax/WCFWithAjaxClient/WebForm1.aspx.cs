using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCFWithAjaxClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            reloadCheck.Text = DateTime.Now.ToString();
        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {
            GetData();//this will cause reposting of the page
        }

        private void GetData()
        {
            WCFWithAjaxDemoService.WCFWithAjaxServiceClient client
                = new WCFWithAjaxDemoService.WCFWithAjaxServiceClient("BasicHttpBinding_IWCFWithAjaxService");
            WCFWithAjaxDemoService.Employee employee = client.GetEmployeeByID(Convert.ToInt32(txtID.Text));
            txtAddress.Text = employee.Address;
            txtName.Text = employee.Name;
            txtSalary.Text = employee.Salary.ToString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            WCFWithAjaxDemoService.WCFWithAjaxServiceClient client
                = new WCFWithAjaxDemoService.WCFWithAjaxServiceClient("BasicHttpBinding_IWCFWithAjaxService");
            WCFWithAjaxDemoService.Employee employee = client.GetEmployeeByID(Convert.ToInt32(txtID.Text));
            employee.Address = txtAddress.Text;
            employee.Name = txtName.Text;
            employee.Salary = (float)Convert.ToDouble(txtSalary.Text);
            employee.ID = Convert.ToInt32(txtID.Text);
            int result =client.SaveEmployee(employee);
            lblResult.Text = result > 0 ? "Data Saved" : "Some Error happened";
        }
    }
}