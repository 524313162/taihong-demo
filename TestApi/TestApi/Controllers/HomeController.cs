using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        /// <summary>
        /// 计算参数结果
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public double Division(int num1, int num2)
        {
            var result = (num1 * 1d) / num2;

            return result;
        }

        public List<User> GetList()
        {
            List<User> result = new List<User>();
            var connectionString = "Data Source=.;Initial Catalog=TestDb;User ID=sa;Password=sa4d65as7d125dasd;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM [User]", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var user = new User();
                user.Name = reader["Name"].ToString();
                user.Age = Convert.ToInt32(reader["Age"]);
                user.Password = reader["Password"].ToString();

                result.Add(user);
            }
            reader.Close();
            connection.Close();
            return result;
        }

        public class User
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public string Password { get; set; }
        }
    }
}
