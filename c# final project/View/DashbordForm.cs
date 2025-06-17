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
            //// Example role-based access code:
            //string role = comboBox1.SelectedItem?.ToString();

            //button1.Visible = false; // Students
            //button2.Visible = false; // UserDetails
            //button3.Visible = false; // Exams
            //button4.Visible = false; // Marks
            //button5.Visible = false; // Courses
            //button7.Visible = false; // Timetable

            //if (role == "Admin")
            //{
            //    button1.Visible = true;
            //    button2.Visible = true;
            //    button3.Visible = true;
            //    button4.Visible = true;
            //    button5.Visible = true;
            //    button7.Visible = true;
            //}
            //else if (role == "Staff")
            //{
            //    button1.Visible = true;
            //    button3.Visible = true;
            //    button4.Visible = true;
            //    button7.Visible = true;
            //}
            //else if (role == "Lecturer" || role == "Student")
            //{
            //    button4.Visible = true;
            //    button7.Visible = true;
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to exit the program?",
        "Exit Confirmation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // 💥 Exits the entire application
            }



        }


    


    }
}










