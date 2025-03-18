using System.Data.SqlClient;

namespace ADO.NET_MVC_Practice.Models
{
    public class EmployeeRepository
    {
        private List<EmployeeModel> employees = new List<EmployeeModel>();
        public SqlConnection ConnectToMsSql()
        {
            string cs = "server=RAYA;integrated security=true;database=practice"; ;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            return con;
        }
        public EmployeeRepository()
        {
            string query = "select * from tblEmployees";
            SqlCommand cmd = new SqlCommand(query, ConnectToMsSql());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                EmployeeModel employee = new EmployeeModel();
                employee.Id = Convert.ToInt32(dr[0]);
                employee.EName = dr[1].ToString();
                employee.Job = dr[2].ToString();
                employee.Salary = Convert.ToInt32(dr[3]);
                employees.Add(employee);
            }
        }
        public List<EmployeeModel> GetAll() => employees;
    }
}
