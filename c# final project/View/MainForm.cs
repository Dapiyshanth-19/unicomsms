
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using c__final_project.View;
using c__final_project.Models;
using c__final_project.Controllers;


namespace c__final_project
{
     
    public partial class MainForm : Form
    {
        UserController userController = new UserController();
        public MainForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Username = textBox1.Text.Trim();
            users. Password = textBox2.Text.Trim();

            Users users1 = userController.ValidateLogin(users);
            if (users1.Username == users.Username && users1.Password == users.Password)
            {
               if(users1.Role == "Admin") 
                {
                    Role.role = "Admin";
                }
               else if (users1.Role == "Student") 
                {
                    Role.role = "Student";
                }
               else if (users1.Role == "Staff")
                {
                    Role.role ="Staff";
                }
               else
                {
                    Role.role = "Lecturer";
                }
                 DashbordForm dashbord = new DashbordForm();
                 dashbord.Show();
                 this.Hide();
                //DashbordForm dashbord = new DashbordForm(users1.Role); // constructor with role
                //dashbord.Show();

            }
            else
            {
                MessageBox.Show("Invalid username or password ❌", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            {

            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lable4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.PasswordChar = '\0'; 
            else
                textBox2.PasswordChar = '*';  
        }



        private string _role;

        public MainForm(string role)
        {
            InitializeComponent();
            _role = role;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        //    // Hide everything first
            //  button1.Visible = false;
        //    btnSubjects.Visible = false;
        //    btnStudents.Visible = false;
        //    btnExams.Visible = false;
        //    btnMarks.Visible = false;
        //    btnTimetable.Visible = false;
        //    btnUsers.Visible = false;

        //    // Show based on role
        //    if (_role == "Admin")
        //    {
        //        btnCourses.Visible = true;
        //        btnSubjects.Visible = true;
        //        btnStudents.Visible = true;
        //        btnExams.Visible = true;
        //        btnMarks.Visible = true;
        //        btnTimetable.Visible = true;
        //        btnUsers.Visible = true;
        //    }
        //    else if (_role == "Staff")
        //    {
        //        btnStudents.Visible = true;
        //        btnExams.Visible = true;
        //        btnMarks.Visible = true;
        //        btnTimetable.Visible = true;
        //    }
        //    else if (_role == "Lecturer")
        //    {
        //        btnMarks.Visible = true;
        //        btnTimetable.Visible = true;
        //    }
        //    else if (_role == "Student")
        //    {
        //        btnMarks.Visible = true;
        //        btnTimetable.Visible = true;
          }
       }







    
}
