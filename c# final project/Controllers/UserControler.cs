using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using c__final_project.Data;
using c__final_project.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace c__final_project.Controllers
{
    public class UserController
    {

        public static void AddUser(Users user)
        {
            using (var conn = DBconnection.Getconnection())
            {
                var cmd = new SQLiteCommand(@"INSERT INTO Users_1 
        (Username, Phonenumber, Name, Gender, Password, Email, Address, DOB, Course, Subject, Role) 
        VALUES 
        (@Username, @Phonenumber, @Name, @Gender, @Password, @Email, @Address, @DOB, @Course, @Subject, @Role)", conn);
          //       conn.Open();
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Phonenumber", user.Phonenumber);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Address", user.Address);
                cmd.Parameters.AddWithValue("@DOB", user.DOB);

                cmd.Parameters.AddWithValue("@Course", user.Course);
                cmd.Parameters.AddWithValue("@Subject", user.Subject);
                cmd.Parameters.AddWithValue("@Role", user.Role);

                cmd.ExecuteNonQuery(); // 🔥 Actual insert into DB happens here!
            }
        }




        public static DataTable GetAllUsers()
        {
            using (var conn = DBconnection.Getconnection())
            {
                //    conn.Open();

                var cmd = new SQLiteCommand(@"INSERT INTO Users_1 
(Username, Phonenumber, Name, Gender, Password, Email, Address, DOB, Course, Subject, Role) 
VALUES 
(@Username, @Phonenumber, @Name, @Gender, @Password, @Email, @Address, @DOB, @Course, @Subject, @Role)", conn);


                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
           //     adapter.Fill(dt);
                return dt;
            }
        }


        public Users ValidateLogin(Users user)
        {
            Users users1 = new Users();
            using (var conn = DBconnection.Getconnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Users_1 WHERE Username = @username", conn);
                cmd.Parameters.AddWithValue("@username", user.Username);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    users1.Id = reader.GetInt32(0);
                    users1.Username = reader.GetString(1);
                //    users1.Phonenumber = reader.GetString(2);
                    users1.Name = reader.GetString(3);
                    users1.Gender = reader.GetString(4);
                    users1.Password = reader.GetString(5);
            //        users1.Email = reader.GetString(6);
               //     users1.Address = reader.GetString(7);
                    users1.DOB = reader.IsDBNull(8) ? DateTime.MinValue : Convert.ToDateTime(reader.GetString(8));

            //        users1.Course = reader.GetString(9);
             //       users1.Subject = reader.GetString(10);
                    users1.Role = reader.GetString(11);
                }
            }
            return users1;
        

           
        }

            public static void UpdateUser(Users user)
            {
                using (var conn = DBconnection.Getconnection())
                {
                var cmd = new SQLiteCommand("UPDATE Users_1 SET Username = @Username, Name = @Name, Password = @Password, Role = @Role, Gender = @Gender WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Role", user.Role);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
                cmd.Parameters.AddWithValue("@Id", user.Id);
                cmd.ExecuteNonQuery();

            }
            }
        }
    }
