
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using c__final_project.Data;
using c__final_project.Controllers; 

using c__final_project.Controlers;
using c__final_project.Models;


namespace c__final_project.View
{
    public partial class SubjectForm : Form
    {
        public SubjectForm()
        {
            InitializeComponent();
            LoadCourses();
            LoadSubject();
            add_combobox();
        }

        public static DataTable GetAllSubjects()
        {
            using (var conn = DBconnection.Getconnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Subjects", conn);
                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // optional
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            courseForm.ShowDialog();
            this.Hide();
        }

        private void LoadSubject()
            
        {

            using (var conn = DBconnection.Getconnection())
            {
                conn.Open(); // ✨ Always open it before using

                var cmd = new SQLiteCommand(@"
            SELECT s.SubjectId, s.SubjectName, c.CourseName
            FROM Subjects s
            JOIN Courses c ON s.CourseId = c.CourseId;", conn);

                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void LoadCourses()
        {
            // InitializeComponent();
            // LoadSubject();
            var courses = CourseController.GetAllCourses();
            couse_com.DataSource = courses;
            couse_com.DisplayMember = "CourseName";
            couse_com.ValueMember = "CourseId";
            couse_com.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (couse_com.SelectedValue == null || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please select a course and enter a subject name.");
                return;
            }

            int courseId = Convert.ToInt32(couse_com.SelectedValue);
            string subjectName = textBox1.Text.Trim();

            using (var conn = DBconnection.Getconnection())
            {
                var cmd = new SQLiteCommand("INSERT INTO Subjects (SubjectName, CourseId) VALUES (@name, @courseId)", conn);
                cmd.Parameters.AddWithValue("@name", subjectName);
                cmd.Parameters.AddWithValue("@courseId", courseId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Subject added successfully...");
            textBox1.Clear();
            LoadSubject();
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            
        }
        public void add_combobox()
        {

            List<Courses> course = CourseController.GetAllCourses();
            couse_com.DataSource = course;
            couse_com.DisplayMember = "CourseName";
            couse_com.ValueMember = "CourseId";
            couse_com.SelectedIndex = -1;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // couse_com.SelectedIndex = -1;
        }

        private void LoadSubject(int courseId)
        {
            var subjects = SubjectController.GetSubjectsByCourseID(courseId);

            couse_com.DataSource = null;
            couse_com.DataSource = subjects;
            couse_com.DisplayMember = "SubjectName";
            couse_com.ValueMember = "SubjectId";
            couse_com.SelectedIndex = -1; // Optional: don't preselect
        }

    }
}
