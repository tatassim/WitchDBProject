using DataBaseProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataBaseProject.DataAccess
{
    public class WitchDataAccess : BaseDataAccess
    {
        public WitchDataAccess(string connectionString)
            : base(connectionString)
        {
        }

        public List<Witch> GetWitches()
        {
            List<Witch> witches = new List<Witch>();
           
            string sql = @"select w.Id_witch, w.Name, w.Birth, w.DateDeath, w.id_habitats, h.name as HabitatName, w.id_coven, c.Name as CovenName from Witch_2 W left join Coven_9 C on c.Id_coven = w.id_coven 
                                                                                                            join Habitats_3 h on W.id_habitats = h.id_habitats";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            witches.Add(new Witch()
                            {
                                Id = (int)reader["Id_witch"],
                                Name = reader["Name"].ToString(),
                                Birth = (DateTime)reader["Birth"],
                               
                                DateDeath = reader["DateDeath"] != DBNull.Value ? Convert.ToDateTime(reader["DateDeath"]) : default(DateTime),


                                Habitat = reader["id_habitats"] != DBNull.Value ?
                                    new Habitat()
                                    {
                                        Id = (int)reader["id_habitats"],
                                        Name = reader["HabitatName"].ToString()
                                    } : null,
                               
                                Coven = reader["id_coven"] != DBNull.Value ?
                                    new Coven()
                                    {
                                        Id = (int)reader["id_coven"],
                                        Name = reader["CovenName"].ToString()
                                    } : null
                            });
                        }
                        reader.Close();
                    }
                }
                connection.Close();
            }
            return witches;
        }


        public void InsertWitch(Witch witch)
        {
            List<Witch> witches = new List<Witch>();
          
            string sql = @"insert into Witch_2 (Name, Birth, DateDeath, id_coven, id_habitats) values (@name, @birth, @datedeath,  @id_coven, @id_habitats)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                   
                    command.Parameters.Add(new SqlParameter("@name", witch.Name));
                    command.Parameters.Add(new SqlParameter("@Birth", witch.Birth));
                    


                    if (witch.Habitat != null)
                        command.Parameters.Add(new SqlParameter("@id_habitats", witch.Habitat.Id));
                    else
                        command.Parameters.Add(new SqlParameter("@id_habitats", DBNull.Value));

                    if (witch.DateDeath != null)
                        command.Parameters.Add(new SqlParameter("@DateDeath", witch.DateDeath));
                    else
                        command.Parameters.Add(new SqlParameter("@DateDeath", DBNull.Value));

                    if (witch.Coven != null)
                        command.Parameters.Add(new SqlParameter("@id_coven", witch.Coven.Id));
                    else
                        command.Parameters.Add(new SqlParameter("@id_coven", DBNull.Value));
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }

        }


        public void UpdateWitch(Witch witch)
        {
            List<Witch> witches = new List<Witch>();
          
            string sql = @"update Witch_2 set  Name =@name, Birth = @birth, DateDeath = @datedeath,  id_habitats =@id_habitats, id_coven= @id_coven where id_witch=@id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    command.Parameters.Add(new SqlParameter("@name", witch.Name));
                    command.Parameters.Add(new SqlParameter("@Birth", witch.Birth));
              

                    if (witch.Habitat != null)
                        command.Parameters.Add(new SqlParameter("@id_habitats", witch.Habitat.Id));
                    else
                        command.Parameters.Add(new SqlParameter("@id_coven", DBNull.Value));

                    if (witch.DateDeath != null)
                        command.Parameters.Add(new SqlParameter("@DateDeath", witch.DateDeath));
                    else
                        command.Parameters.Add(new SqlParameter("@DateDeath", DBNull.Value));

                    if (witch.Coven != null)
                        command.Parameters.Add(new SqlParameter("@id_coven", witch.Coven.Id));
                    else
                        command.Parameters.Add(new SqlParameter("@id_coven", DBNull.Value));

                    command.Parameters.Add(new SqlParameter("@id",witch.Id));
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }

        }


         public void DeleteWitch(int id)
         {
             List<Witch> witches = new List<Witch>();
            
             string sql = @"delete from Witch_2 where id_witch=@id";
             using (SqlConnection connection = new SqlConnection(connectionString))
             {
                 connection.Open();
                 using (SqlCommand command = new SqlCommand(sql, connection))
                 {
                     command.Parameters.Add(new SqlParameter("@id", id));
                     command.ExecuteNonQuery();
                 }
                 connection.Close();
             }

         }
    }
}


