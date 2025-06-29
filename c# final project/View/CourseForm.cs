using System;
using c__final_project.Controllers;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using c__final_project.Controlers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace c__final_project.View
{
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;//
            LoadCourses();




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string courseName = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(courseName))
            {
                MessageBox.Show("Course name cannot be empty ");
                return;
            }

            CourseController.AddCourse(courseName);
            MessageBox.Show("Course added sucsessfully... ");
            textBox1.Text = "";
            LoadCourses();
        }
        private void LoadCourses()
        {
            var courses = CourseController.GetAllCourses();


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = courses;


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a course to delete");
                return;
            }

            int courseId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CourseId"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this course?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                CourseController.DeleteCourse(courseId);
                MessageBox.Show("Course deleted sucsessfully...");
                LoadCourses(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DashbordForm dashbordForm = new DashbordForm();
            dashbordForm.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SubjectForm subjectForm = new SubjectForm();
            subjectForm.Show();
            this.Hide();
        }
    }
}

