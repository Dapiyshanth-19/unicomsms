
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using c__final_project.Data;
using c__final_project.Controllers;  // ✅ Correct namespace

using c__final_project.Controlers;
using c__final_project.Models;


namespace c__final_project.View
{
    public partial class SubjectForm : Form
    {
        public SubjectForm()
        {
            InitializeComponent();
            LoadSubject(); // ✅ Call method after it's defined
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
            DataTable dt = SubjectController.GetAllSubjects(); // ✅ Correct class name
            dataGridView1.AutoGenerateColumns = true;  // <--- very important!
            dataGridView1.DataSource = dt;
        }

        private void LoadCourses()
        {
            InitializeComponent();
            LoadSubject();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SubjectName = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(SubjectName))
            {
                MessageBox.Show("Subject name cannot be empty ❗");
                return;
            }

            SubjectController.AddCourse(SubjectName); // ✅ Correct class and method
            MessageBox.Show("Subject added successfully ");
            textBox1.Text = "";
            LoadSubject();
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            // optional
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
    }
}
