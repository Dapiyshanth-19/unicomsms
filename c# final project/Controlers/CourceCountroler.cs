using c__final_project.Models;
using System;
using System.Data;
using System.Data.Common;
using c__final_project.Data;
using System.Data.SQLite;

public class CourseController
{
    public static void AddCourse(string name)
    {
        using (var conn = DBconnection.Getconnection())
        {
            
            var cmd = new SQLiteCommand("INSERT INTO Courses (CourseName) VALUES (@name)", conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.ExecuteNonQuery();
        }
    }

    public static List<Courses> GetAllCourses()
    {
        var list = new List<Courses>();
        using (var conn = DBconnection.Getconnection())

        {
           
            var cmd = new SQLiteCommand("SELECT * FROM Courses", conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Courses
                {
                    CourseID = Convert.ToInt32(reader["CourseID"]),
                    CourseName = reader["CourseName"].ToString() ?? ""//
                });
            }
        }
        return list;
    }

}
