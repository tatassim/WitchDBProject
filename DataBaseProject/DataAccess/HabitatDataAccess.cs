using DataBaseProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProject.DataAccess
{
    public class HabitatDataAccess : BaseDataAccess
    {
        public HabitatDataAccess(string connectionString)
            : base(connectionString)
        {
        }

        public Habitat GetHabitatById(int id)
        {
            string sql = @"select Id_habitats, Name from Habitats_3 where id_habitats = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add(new SqlParameter("@id", id));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Habitat()
                            {
                                Id = (int)reader["Id_habitats"],
                                Name = reader["Name"].ToString()
                            };
                        }
                        reader.Close();
                    }
                }
                connection.Close();
            }
            return null;
        }

        public List<Habitat> GetHabitats()
        {
            List<Habitat> result = new List<Habitat>();
            string sql = @"select id_habitats, Name from Habitats_3";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new Habitat()
                            {
                                Id = (int)reader["id_habitats"],
                                Name = reader["Name"].ToString()
                            });
                        }
                        reader.Close();
                    }
                }
                connection.Close();
            }
            return result;
        }
    }
}

