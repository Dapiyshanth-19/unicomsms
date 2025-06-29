using c__final_project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c__final_project.View
{
   

    public partial class DashbordForm : Form
    {
        public DashbordForm()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       

        private void DashbordForm_Load(object sender, EventArgs e)
        {
            string role = Role.Currentrole; 

            //  First hide everything
            // Role_Cbox.Visible = false;
            Students_Btn.Visible = false; // Students
            UserDeatails_Btn.Visible = false; // UserDetails
            Exams_Btn.Visible = false; // Exams
            Marks_Btn.Visible = false; // Marks
            Course_Btn.Visible = false; // Courses
            Timetable_Btn.Visible = false; 

            //  Show based on role vice dashbord
            if (role == "Admin")
            {
                Students_Btn.Visible = true;
                //  Role_Cbox.Visible = true;

                UserDeatails_Btn.Visible = true;
                Exams_Btn.Visible = true;
                Marks_Btn.Visible = true;
                Course_Btn.Visible = true;
                Timetable_Btn.Visible = true;
            }
            else if (role == "Staff")
            {
                Students_Btn.Visible = true;
                Exams_Btn.Visible = true;
                Marks_Btn.Visible = true;
                Timetable_Btn.Visible = true;
            }
            else if (role == "Lecturer")
            {
                Marks_Btn.Visible = true;
                Timetable_Btn.Visible = true;
                Exams_Btn.Visible = true;
            }
            else if (role == "Student")
            {
                Marks_Btn.Visible = true;
                Timetable_Btn.Visible = true;
                Exams_Btn.Visible = true;
            }


            label2.Text = "Role: " + role;
        }





        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                MainForm login = new MainForm();
                login.Show();


                this.Close();
            }

        }

        private void Course_Btn_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            courseForm.Show();
            this.Hide();
        }
    }
}










