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

        public void AddUser(Users user)
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

                // cmd.ExecuteNonQuery(); // 🔥 Actual insert into DB happens here!
                try
                {
                    cmd.ExecuteNonQuery(); // Actual insert into DB happens here!
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine($"SQLite error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"General error: {ex.Message}");
                }
            }
        }




        public static DataTable GetAllUsers()
        {
            using (var conn = DBconnection.Getconnection())
            {
                conn.Open();
                //    conn.Open();

                //                var cmd = new SQLiteCommand(@"SELECT * FROM Users_1 
                //(Username, Phonenumber, Name, Gender, Password, Email, Address, DOB, Course, Subject, Role) 
                //VALUES 
                //(@Username, @Phonenumber, @Name, @Gender, @Password, @Email, @Address, @DOB, @Course, @Subject, @Role)", conn);


                //                var adapter = new SQLiteDataAdapter(cmd);
                //                var dt = new DataTable();
                //                adapter.Fill(dt);
                //                return dt;
                var cmd = new SQLiteCommand("SELECT * FROM Users_1", conn); // Use SELECT instead of INSERT
                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }

        }


        public Users ValidateLogin(Users user)
        {
            Users users1 = new Users();
            using (var conn = DBconnection.Getconnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT * FROM Users_1 WHERE Username = @username", conn);
                cmd.Parameters.AddWithValue("@username", user.Username);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                   

                    users1.Id = reader.GetInt32(0);
                users1.Username = reader.GetString(1);
            //    users1.Phonenumber = reader.IsDBNull(2) ? null : reader.GetString(2); // Check for NULL
                users1.Name = reader.GetString(3);
                users1.Gender = reader.GetString(4);
                users1.Password = reader.GetString(5);
                users1.Email = reader.IsDBNull(6) ? null : reader.GetString(6); // Check for NULL
                users1.Address = reader.IsDBNull(7) ? null : reader.GetString(7); // Check for NULL
          //      users1.DOB = reader.IsDBNull(8) ? DateTime.MinValue : Convert.ToDateTime(reader.GetString(8));
                users1.Course = reader.IsDBNull(9) ? null : reader.GetString(9); // Check for NULL
                users1.Subject = reader.IsDBNull(10) ? null : reader.GetString(10); // Check for NULL
                users1.Role = reader.GetString(11);

            }
            return users1;
        

           
        }

        //public static void UpdateUser(Users user)
        //{
        //    using (var conn = DBconnection.Getconnection())
        //    {
        //    var cmd = new SQLiteCommand("UPDATE Users_1 SET Username = @Username, Name = @Name, Password = @Password, Role = @Role, Gender = @Gender WHERE Id = @Id", conn);
        //    cmd.Parameters.AddWithValue("@Username", user.Username);
        //    cmd.Parameters.AddWithValue("@Name", user.Name);
        //    cmd.Parameters.AddWithValue("@Password", user.Password);
        //    cmd.Parameters.AddWithValue("@Role", user.Role);
        //    cmd.Parameters.AddWithValue("@Gender", user.Gender);
        //    cmd.Parameters.AddWithValue("@Id", user.Id);
        //    cmd.ExecuteNonQuery();


        public static void UpdateUser(Users user)
        {
            using (var conn = DBconnection.Getconnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand(@"
            UPDATE Users_1 SET 
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
              // cmd.Parameters.AddWithValue("@Phonenumber", user.PhoneNumber);
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

                //cmd.ExecuteNonQuery();
                try
                {
                    cmd.ExecuteNonQuery(); // Actual insert into DB happens here!
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine($"SQLite error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"General error: {ex.Message}");
                }

            }
        }



    }
}
