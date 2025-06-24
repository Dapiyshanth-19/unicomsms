using System;
using System.Data.SQLite;
using System.Windows.Forms; 
using c__final_project.Models;

namespace c__final_project.Data
{
    public static class Migration
    {
        public static void Createtables()
        {
            using (var getconn = DBconnection.Getconnection())
            {
                try
                {
                    getconn.Open(); 

                    string fullMigrationQuery = @"
                    -- Create Users_1 Table
                    CREATE TABLE IF NOT EXISTS Users_1 (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL,
                        Phonenumber TEXT NOT NULL,
                        Name TEXT NOT NULL,
                        Gender TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        Email TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        DOB TEXT NOT NULL,
                        Course TEXT NOT NULL,
                        Subject TEXT NOT NULL,
                        Role TEXT NOT NULL
                    );

                    -- Create Courses Table
                    CREATE TABLE IF NOT EXISTS Courses (
                        CourseId INTEGER PRIMARY KEY AUTOINCREMENT,
                        CourseName TEXT NOT NULL
                    );

                    -- Create Subjects Table
                    CREATE TABLE IF NOT EXISTS Subjects (
                        SubjectId INTEGER PRIMARY KEY AUTOINCREMENT,
                        SubjectName TEXT NOT NULL,
                        CourseId INTEGER NOT NULL,
                        FOREIGN KEY (CourseId) REFERENCES Courses(CourseId) ON DELETE CASCADE
                    );

                    -- Create Students Table
                    CREATE TABLE IF NOT EXISTS Students (
                        StudentId INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Gender TEXT NOT NULL,
                        CourseId INTEGER,
                        FOREIGN KEY (CourseId) REFERENCES Courses(CourseId)
                    );

                    -- Create Exams Table
                    CREATE TABLE IF NOT EXISTS Exams (
                        ExamId INTEGER PRIMARY KEY AUTOINCREMENT,
                        ExamName TEXT NOT NULL,
                        CourseId INTEGER,
                        FOREIGN KEY (CourseId) REFERENCES Courses(CourseId)
                    );

                    -- Create Marks Table
                    CREATE TABLE IF NOT EXISTS Marks (
                        MarkId INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentId INTEGER,
                        SubjectId INTEGER,
                        ExamId INTEGER,
                        Mark INTEGER,
                        FOREIGN KEY (StudentId) REFERENCES Students(StudentId),
                        FOREIGN KEY (SubjectId) REFERENCES Subjects(SubjectId),
                        FOREIGN KEY (ExamId) REFERENCES Exams(ExamId)
                    );

                    -- Create Timetable Table
                    CREATE TABLE IF NOT EXISTS Timetable (
                        TimetableId INTEGER PRIMARY KEY AUTOINCREMENT,
                        CourseId INTEGER,
                        SubjectId INTEGER,
                        Day TEXT NOT NULL,
                        Time TEXT NOT NULL,
                        FOREIGN KEY (CourseId) REFERENCES Courses(CourseId),
                        FOREIGN KEY (SubjectId) REFERENCES Subjects(SubjectId)
                    );

                    -- Insert default admin user if not exists
                    INSERT INTO Users_1 
                        (Username, Phonenumber, Name, Gender, Password, Email, Address, DOB, Course, Subject, Role)
                    SELECT 
                        'dabi', 
                        '0750416935',       
                        'Dabi', 
                        'Male', 
                        '12345', 
                        'dabishanth@gmail.com',  
                        'jaffna', 
                        '2004-08-19', 
                        'None', 
                        'None', 
                        'Admin'
                    WHERE NOT EXISTS (
                        SELECT 1 FROM Users_1 
                        WHERE Username = 'dabi' AND Name = 'Dabi' 
                        AND Password = '12345' AND Role = 'Admin'
                    );
                    ";

                    using (var cmd = new SQLiteCommand(fullMigrationQuery, getconn))
                    {
                        int result = cmd.ExecuteNonQuery();
                        Console.WriteLine($"✅ Migration executed. Rows affected: {result}");
                        MessageBox.Show(" Database tables created successfully!", "Migration Complete");
                    }
                }
                catch (SQLiteException sqlEx)
                {
                    MessageBox.Show($"SQLite Error: {sqlEx.Message}", "DB Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"General Error: {ex.Message}", "Error");
                }
                finally
                {
                    Console.WriteLine("Migration completed.");
                }
            }
        }
    }
}
