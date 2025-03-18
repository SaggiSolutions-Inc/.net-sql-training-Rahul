using System.Data.SqlClient;
namespace AdoConApp01
{
    class Program
    {
        static void Main()
        {
            //string cs = "server=KIRAN\\SQLEXPRESS;user id=sa;password=welcome;database=EmployeeDB";

            string cs = "server=RAYA;integrated security=true;database=practice";

            SqlConnection con = new SqlConnection(cs);
            con.Open();
            Console.WriteLine("Connection established successfully...");


            string query = "select * from tblEmployees";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())  //read  row after, move cursor to next row till reaches to last row
                Console.WriteLine($"{dr[0].ToString()} {dr[1].ToString()} {dr[2].ToString()} {dr[3].ToString()} ");
        

    }
    }
}
