using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using c__final_project.Data;
using c__final_project.Models;

namespace c__final_project.Controllers
{
    public class UserController
    {
        //  Add a new user to the database
        public static void AddUser(Users user)
        {
            using (var conn = DBconnection.Getconnection())
            {
                conn.Open();

                var cmd = new SQLiteCommand(@"INSERT INTO Users_1 
                (Username, Phonenumber, Name, Gender, Password, Email, Address, DOB, Course, Subject, Role) 
                VALUES 
                (@Username, @Phonenumber, @Name, @Gender, @Password, @Email, @Address, @DOB, @Course, @Subject, @Role)", conn);

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

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine($"SQLite error: {ex.Message}");
                    throw; // rethrow so UI can show message
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"General error: {ex.Message}");
                    throw;
                }
            }
        }

        // ✅ Get all users from the database
        public static DataTable GetAllUsers()
        {
            using (var conn = DBconnection.Getconnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT * FROM Users_1", conn);
                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }


        public Users ValidateLogin(Users user)
        {
            Users foundUser = null;

            using (var conn = DBconnection.Getconnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT * FROM Users_1 WHERE Username = @username AND Password = @password", conn);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        foundUser = new Users
                        {
                            Id = reader.GetInt32(0),
                            Username = reader.GetString(1),
                            Phonenumber = reader.IsDBNull(2) ? null : reader.GetString(2),
                            Name = reader.GetString(3),
                            Gender = reader.GetString(4),
                            Password = reader.GetString(5),
                            Email = reader.IsDBNull(6) ? null : reader.GetString(6),
                            Address = reader.IsDBNull(7) ? null : reader.GetString(7),
                            DOB = reader.IsDBNull(8) ? null : reader.GetString(8),
                            Course = reader.IsDBNull(9) ? null : reader.GetString(9),
                            Subject = reader.IsDBNull(10) ? null : reader.GetString(10),
                            Role = reader.GetString(11)
                        };
                    }
                }
            }

            return foundUser;
        }



        public static void UpdateUser(Users user)
        {
            using (var conn = DBconnection.Getconnection())
            {
                conn.Open();

                var cmd = new SQLiteCommand(@"UPDATE Users_1 SET 
                    Username = @Username,
                    Phonenumber = @Phonenumber,
                    Name = @Name,
                    Gender = @Gender,
                    Password = @Password,
                    Email = @Email,
                    Address = @Address,
                    DOB = @DOB,
                    Course = @Course,
                    Subject = @Subject,
                    Role = @Role
                    WHERE Id = @Id", conn);

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
                cmd.Parameters.AddWithValue("@Id", user.Id);

               
                {
                    cmd.ExecuteNonQuery();
                }
                
               
            }
        }
    }
}
