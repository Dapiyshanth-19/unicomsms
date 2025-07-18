﻿using c__final_project.Controlers;
using c__final_project.Controllers;
using c__final_project.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using c__final_project.View;
using System.Data.SQLite;
using c__final_project.Data; 

using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace c__final_project.View
{
    public partial class UserForm : Form
    {
        private int selectedUserId = -1;//

        public UserForm()


        {
            InitializeComponent();
            LoadUsers();

            List<string> roles = new List<string> { "Admin", "Staff", "Student", "Lecturer" };
            cmbRole.DataSource = roles;
            cmbRole.SelectedIndex = -1;
            LoadCoursesToComboBox();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadCoursesToComboBox();
        }
        private void LoadUsers()
        {
            var usersTable = UserController.GetAllUsers();
            Console.WriteLine($"Number of users: {usersTable.Rows.Count}");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usersTable;
        }
      
        private void LoadCourses()
        {
            var courses = CourseController.GetAllCourses();
            comboBox1.DataSource = courses;
            comboBox1.DisplayMember = "CourseName";
            comboBox1.ValueMember = "CourseId";
            comboBox1.SelectedIndex = -1;
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        // 
        //    LoadUsers();


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please enter username and name ");
                return;
            }

            string gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;

            Users user = new Users
            {
                Username = textBox2.Text,
                Name = textBox2.Text + " " + textBox3.Text,
                Password = "123456",
                Role = cmbRole.Text.Trim(),
                Gender = gender,
                Phonenumber = textBox5.Text.Trim(),
                Email = textBox4.Text.Trim(),
                Address = textBox16.Text.Trim(),
                DOB = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                Course = comboBox1.Text?.ToString(),
                Subject = comboBox2.Text?.ToString()
            };

            try
            {
                MessageBox.Show(user.Role);
                cmbRole.SelectedIndex = -1;
                UserController userController = new UserController();

                UserController.AddUser(user);



                MessageBox.Show("User Added Successfully!");
                LoadUsers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}");
            }




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null && int.TryParse(comboBox1.SelectedValue.ToString(), out int courseId))
            {
                var subjectList = SubjectController.GetSubjectsByCourseID(courseId);
                comboBox2.DataSource = subjectList;
                comboBox2.DisplayMember = "SubjectName";
                comboBox2.ValueMember = "SubjectId";
                comboBox2.SelectedIndex = -1;
            }
        }


        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            List<string> roles = new List<string> { "Admin", "Staff", "Student", "Lecturer" };//
            cmbRole.DataSource = roles;//
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        private void LoadCoursesToComboBox()
        {
            var courseList = CourseController.GetAllCourses();
            comboBox1.DataSource = courseList;
            comboBox1.DisplayMember = "CourseName";
            comboBox1.ValueMember = "CourseId";
            comboBox1.SelectedIndex = -1;
        }




        private void ClearForm()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox16.Clear();
            textBox17.Clear();
            comboBox1.SelectedIndex = -1;
            cmbRole.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Today;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashbordForm dashbordForm = new DashbordForm();
            dashbordForm.ShowDialog();
            this.Hide(); //

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserForm_Load_1(object sender, EventArgs e)
        {
            LoadUsers();//
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)

        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                selectedUserId = Convert.ToInt32(row.Cells["Id"].Value);

                textBox2.Text = row.Cells["Username"].Value.ToString();
                textBox3.Text = row.Cells["Name"].Value.ToString();
                textBox4.Text = row.Cells["Email"].Value.ToString();
                textBox5.Text = row.Cells["Phonenumber"].Value.ToString();
                textBox16.Text = row.Cells["Address"].Value.ToString();
                comboBox2.Text = row.Cells["Subject"].Value.ToString();
                comboBox1.Text = row.Cells["Course"].Value.ToString();
                cmbRole.Text = row.Cells["Role"].Value.ToString();

                string gender = row.Cells["Gender"].Value.ToString();
                radioButton1.Checked = gender == radioButton1.Text;
                radioButton2.Checked = gender == radioButton2.Text;

                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["DOB"].Value);

                MessageBox.Show("Selected User ID: " + selectedUserId);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user from the list to update!");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox16.Text) || string.IsNullOrWhiteSpace(textBox17.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(dateTimePicker1.Text))
            {
                MessageBox.Show("Please fill FORM Fully...");
                return;
            }
            string gender;
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }



            Users user = new Users
            {
                Id = selectedUserId,
                Username = textBox2.Text.Trim(),
                Name = textBox3.Text.Trim(),
                Email = textBox4.Text.Trim(),
                Phonenumber = textBox5.Text.Trim(),
                Address = textBox16.Text.Trim(),

                Course = comboBox1.SelectedItem?.ToString(),
                Subject = comboBox2.SelectedItem?.ToString(),

                Role = cmbRole.SelectedItem?.ToString(),
                DOB = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                Gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text,
                Password = "123456"
            };

            UserController.UpdateUser(user);


            LoadUsers();
            ClearForm();
            selectedUserId = -1;
            MessageBox.Show("User updated successfully...");
        }


        private void btnCheckColumns_Click(object sender, EventArgs e)
        {
            using (var conn = DBconnection.Getconnection())
            {
                var cmd = new SQLiteCommand("PRAGMA table_info(Users_1);", conn);
                var reader = cmd.ExecuteReader();
                string columns = "";

                while (reader.Read())
                {
                    string columnName = reader["name"].ToString();
                    columns += columnName + "\n";
                }

                MessageBox.Show(columns, " Columns in Users_1 Table");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a User to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this User?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    UserController.DeleteUser(selectedUserId);
                    MessageBox.Show("User deleted successfully.");
                    LoadUsers();
                    ClearForm();
                    selectedUserId = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user: " + ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null && int.TryParse(comboBox1.SelectedValue.ToString(), out int courseId))
            {
                var subjectList = SubjectController.GetSubjectsByCourseID(courseId);
                //comboBox2.DataSource = subjectList;
                //comboBox2.DisplayMember = "SubjectName";
                //comboBox2.ValueMember = "SubjectId";
                //comboBox2.SelectedIndex = -1;

                {
                    var subjectLis = SubjectController.GetSubjectsByCourseID(courseId);
                    comboBox2.DataSource = subjectLis;
                    comboBox2.DisplayMember = "SubjectName";
                    comboBox2.ValueMember = "SubjectId";
                    comboBox2.SelectedIndex = -1;
                }
            }
        }

        private void btnRefreshCourses_Click_1(object sender, EventArgs e)
        {
            LoadCoursesToComboBox();
        }
        private void btnRefreshCourses_Click(object sender, EventArgs e)
        {
           
        }
    }
}


