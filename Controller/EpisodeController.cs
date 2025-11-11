using System.Data;
using Microsoft.Data.SqlClient;
using MVC_Update.Model;

namespace MVC_Update.Controller
{
    public class EpisodeController
    {
        private string connectionString = @"Data Source=.;Initial Catalog=DoctorWho;Integrated Security=True;Persist Security Info=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True";

        public List<EpisodeModel> ReadAll()
        {
            List<EpisodeModel> items = new List<EpisodeModel>();

            string sqlQuery = "SELECT * FROM tblEpisode";

            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            using SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                EpisodeModel model = new EpisodeModel(
                    (int)       reader["EpisodeId"],
                    (string)    reader["Title"],
                    DateOnly.FromDateTime(reader.GetDateTime("EpisodeDate")),
                    (int)       reader["AuthorId"]
                );

                items.Add(model);
            }

            return items;
        }


        public void Update() {
            // Implementeer de Update Method
            // Welk return type heeft deze methode nodig?
            // Welke parameters heeft de methode nodig?
        }
    }
}

