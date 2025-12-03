using Microsoft.Data.SqlClient;
using MVC_Update.Model;

namespace MVC_Update.Controller
{
    internal class AuthorController
    {
        private string connectionString = @"Data Source=.;Initial Catalog=DoctorWho;Integrated Security=True;Persist Security Info=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True";

        public List<AuthorModel> ReadAll()
        {
            List<AuthorModel> items = new List<AuthorModel>();

            string sqlQuery = "SELECT * " +
                "FROM tblAuthor";

            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            using SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                AuthorModel model = new AuthorModel(
                    (int)reader["AuthorId"],
                    (string)reader["AuthorName"]
                );


                items.Add(model);
            }

            return items;
        }
    }
}
