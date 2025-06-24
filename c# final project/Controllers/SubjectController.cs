using c__final_project.Data;
using c__final_project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace c__final_project.Controllers
{
    public static class SubjectController
    {
        public static DataTable GetAllSubjects()
        {
            using (var conn = DBconnection.Getconnection())
            {
                conn.Open();
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
                conn.Open();
                var cmd = new SQLiteCommand("SELECT CourseId, CourseName FROM Courses", conn);
                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

       
        
        public static List<Subject> GetSubjectsByCourseID(int courseId)
        {
            var subjects = new List<Subject>();

            using (var conn = DBconnection.Getconnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("SELECT SubjectId, SubjectName FROM Subjects WHERE CourseId = @courseId", conn))
                {
                    cmd.Parameters.AddWithValue("@courseId", courseId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            subjects.Add(new Subject
                            {
                                SubjectId = Convert.ToInt32(reader["SubjectId"]),
                                SubjectName = reader["SubjectName"].ToString()
                            });
                        }
                    }
                }
            }

            return subjects;
        }

       
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
    }
}
