using System.Collections.Generic;
using System.Data.SQLite;
using c__final_project.Data;
using c__final_project.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace c__final_project.Controllers
{
    public class UserController
    {
        // ✅ Add a user
        public static void AddUser(Users user)
        {
            using (var conn = DBconnection.Getconnection())
            {
           
                var cmd = new SQLiteCommand("INSERT INTO Users_1 (Username, Name, Password, Role,Gender) VALUES (@Username, @Name, @Password, @Role,@gender)", conn);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@gender", user.Gender);
                cmd.Parameters.AddWithValue("@Role", user.Role);
                cmd.ExecuteNonQuery();


                //var cmd = new SQLiteCommand("SELECT * FROM Users_1 WHERE Username = @username AND Password = @password", conn);
                //cmd.Parameters.AddWithValue("@username", user.Username);
                //cmd.Parameters.AddWithValue("@password", user.Password);

            }
        }

        // ✅ Get all users (for listing)
        public static List<Users> GetAllUsers()
        {
            var list = new List<Users>();
            using (var conn = DBconnection.Getconnection())
            {
               // conn.Open();
                var cmd = new SQLiteCommand("SELECT * FROM Users_1", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Users
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Username = reader["Username"].ToString(),
                        Name = reader["Name"].ToString(),
                        Password = reader["Password"].ToString(),
                        Gender = reader["Gender"].ToString(),
                        Role = reader["Role"].ToString()
                    });
                }
            }
            return list;
        }

        // ✅ Login check method
        public  Users ValidateLogin(Users user)
        {
            Users users1 = new Users();
            using (var conn = DBconnection.Getconnection())
            {
                //  var cmd = new SQLiteCommand("SELECT * FROM Users WHERE Username = @username", conn);
                var cmd = new SQLiteCommand("SELECT * FROM Users_1 WHERE Username = @username", conn);


                cmd.Parameters.AddWithValue("@username", user.Username);              
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    users1.Id = reader.GetInt32(0);
                    users1.Username = reader.GetString(1);
                    users1.Name = reader.GetString(2);
                    users1.Password = reader.GetString(4);
                    users1.Gender = reader["Gender"].ToString();
                    users1.Role = reader.GetString(5);

                }
            }
            return users1;
        }
    }
}
