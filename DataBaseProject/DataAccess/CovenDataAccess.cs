using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseProject.Models;

namespace DataBaseProject.DataAccess
{
    public class CovenDataAccess : BaseDataAccess
    {
        public CovenDataAccess(string connectionString)
            : base(connectionString)
        {
        }

        public Coven GetCovenById(int id)
        {
            string sql = @"select Id_coven, Name from Coven_9 where id_coven = @id";
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
                            return new Coven()
                            {
                                Id = (int)reader["Id_coven"],
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

        public List<Coven> GetCovens()
        {
            List<Coven> result = new List<Coven>();
            string sql = @"select Id_coven, Name from Coven_9";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new Coven()
                            {
                                Id = (int)reader["Id_coven"],
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
