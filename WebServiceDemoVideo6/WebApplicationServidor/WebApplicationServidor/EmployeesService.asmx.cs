using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplicationServidor
{
    /// <summary>
    /// Summary description for EmployeesService
    /// </summary>
    [WebService(Namespace = "http://WebFull.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class EmployeesService : System.Web.Services.WebService
    {

        [WebMethod]
        public Employees GetEmployeeById(string ID)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con= new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spGetEmployeeById", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameter = new SqlParameter("@ID",ID);
                cmd.Parameters.Add(parameter);
                con.Open();
                Employees employee = new Employees();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    employee.ID = reader["ID"].ToString();
                    employee.FirstName = reader["FirstName"].ToString();
                    employee.LastName = reader["LastName"].ToString();
                    employee.Mail = reader["Mail"].ToString();
                    employee.Phone = reader["Phone"].ToString();
                    employee.Salary = Convert.ToInt32(reader["Salary"]);
                }
                con.Close();
                return employee;
            }      

        }
    }
}
