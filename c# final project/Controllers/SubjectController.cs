using c__final_project.Data;

using c__final_project.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;


namespace c__final_project.Controlers
{
    public class SubjectController
    {
        public static void AddCourse(string subjectName) { }

      //  public static DataTable GetAllSubjects() {}
        public static void AddSubject(string subjectName, int courseId)
        {
            using (var conn = DBconnection.Getconnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Subjects (SubjectName, CourseId) VALUES (@name, @courseId)", conn);
                cmd.Parameters.AddWithValue("@name", subjectName);
                cmd.Parameters.AddWithValue("@courseId", courseId);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetAllSubjects()
        {
            using (var conn = DBconnection.Getconnection())
            {
               // conn.Open();
                //var cmd = new SQLiteCommand(
                //    @"SELECT s.SubjectId, s.SubjectName, c.CourseName 
                //      FROM Subjects s 
                //      JOIN Courses c ON s.CourseId = c.CourseId", conn);
                //var adapter = new SQLiteDataAdapter(cmd);

                var cmd = new SQLiteCommand("SELECT * FROM Subjects", conn);
                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                



                adapter.Fill(dt);
                return dt;
            }
        }

        public static DataTable GetCourses()
        {
            using (var conn = DBconnection.Getconnection())
            {
             //   conn.Open();
                var cmd = new SQLiteCommand("SELECT CourseId, CourseName FROM Courses", conn);
                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
