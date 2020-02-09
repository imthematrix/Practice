using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WCFWithAjax
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFWithAjaxService" in both code and config file together.
    public class WCFWithAjaxService : IWCFWithAjaxService
    {
        
        public Employee GetEmployeeByID(int ID)
        {
            return GetSingleEmployeeFromDB(ID);
        }

        public int SaveEmployee(Employee employee)
        {
            return SaveDataToDB(employee);
        }

        private int SaveDataToDB(Employee employee)
        {
            int done = 0;
            using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("sp_insertEmployee", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", employee.ID);
                sqlCommand.Parameters.AddWithValue("@salary", employee.Salary);
                sqlCommand.Parameters.AddWithValue("@name", employee.Name);
                sqlCommand.Parameters.AddWithValue("@address", employee.Address);
                sqlConnection.Open();
                done= sqlCommand.ExecuteNonQuery();
            }
            return done;
        }

        private Employee GetSingleEmployeeFromDB(int ID)
        {
            Employee employee = new Employee();
            using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("qs_getEmployeeByID", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", ID);
                
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                foreach( DataRow row in dataTable.Rows){
                    employee.ID = Convert.ToInt32(row["employee_id"].ToString());
                    employee.Name = row["employee_name"].ToString();
                    employee.Address = row["employee_address"].ToString();
                    employee.Salary =(float) Convert.ToDouble( row["employee_salary"].ToString());

                }

            }
            return employee;
        }

    }
}
