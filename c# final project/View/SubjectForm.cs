
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
             // add_combobox();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void LoadSubject()
        {
            using (var conn = DBconnection.Getconnection())
            {
                conn.Open();

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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                CourseForm courseForm = new CourseForm();
                var result = courseForm.ShowDialog();
                this.Hide();

                if (result == DialogResult.OK || result == DialogResult.Cancel) 
                {
                    LoadCourses(); 
                }
            }
        }

       
        private void LoadCourses()
        {
            List<Courses> course = CourseController.GetAllCourses();
            course.Insert(0, new Courses { CourseId = 0, CourseName = "-- Select Course --" }); // 💬 Add default option
            couse_com.DataSource = course;
            couse_com.DisplayMember = "CourseName";
            couse_com.ValueMember = "CourseId";
            couse_com.SelectedIndex = 0;
        }



    
       
        private void FilterSubjectsByCourse(int courseId)
        {
            using (var conn = DBconnection.Getconnection())
            {
                conn.Open();

                var cmd = new SQLiteCommand(@"
            SELECT s.SubjectId, s.SubjectName, c.CourseName
            FROM Subjects s
            JOIN Courses c ON s.CourseId = c.CourseId
            WHERE s.CourseId = @cid;", conn);

                cmd.Parameters.AddWithValue("@cid", courseId);
                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (couse_com.SelectedIndex == 0 || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please select a course and enter a subject name.");
                return;
            }

            int courseId = Convert.ToInt32(couse_com.SelectedValue);
            string subjectName = textBox1.Text.Trim();

            using (var conn = DBconnection.Getconnection())
             
            {
                conn.Open();
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
            if (couse_com.SelectedIndex > 0)
            {
                int courseId = Convert.ToInt32(couse_com.SelectedValue);
                FilterSubjectsByCourse(courseId);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select a subject to delete.");
                return;
            }

            int subjectId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SubjectId"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this subject?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var conn = DBconnection.Getconnection())
                {
                    conn.Open();
                    var cmd = new SQLiteCommand("DELETE FROM Subjects WHERE SubjectId = @id", conn);
                    cmd.Parameters.AddWithValue("@id", subjectId);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Subject deleted successfully");
                LoadSubject();
            }
        }
    }
}
