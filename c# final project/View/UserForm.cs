using c__final_project.Controlers;
using c__final_project.Controllers;
using c__final_project.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c__final_project.View
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            LoadUsers();
            // Form Load or Constructor
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Items.AddRange(new string[] { "Admin", "Lecturer", "Staff", "Student" });
            //List<string> roles = new List<string> { "Admin", "Staff", "Student", "Lecturer" };
            //cmbRole.DataSource = roles;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
           
        }
        private void LoadUsers()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = UserController.GetAllUsers();

        }
        //private void button2_Click(object sender, EventArgs e)
        //{
        //  //// After adding user, refresh list
        //    LoadUsers();


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         

            // On Add Button Click
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
                Username = textBox2.Text,
                Name = textBox2.Text + " " + textBox3.Text,
                Password = "123456",
                Role = cmbRole.Text.Trim(),
                Gender = gender
            };
            MessageBox.Show(user.Role);

            UserController.AddUser(user);

            MessageBox.Show("User Added Successfully!");
            LoadUsers();





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        //private void btnAddUser_Click(object sender, EventArgs e)
        //{
        //    List<string> roles = new List<string> { "Admin", "Staff", "Student", "Lecturer" };
        //    cmbRole.DataSource = roles;
        //}

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

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

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }


}
