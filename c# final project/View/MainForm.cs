
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
             ClearFields();
           // textBox1.Focus();

        }

        public void ClearFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text)
             || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter both username and password",
                                "Login Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 2) Build the Users object and validate
            Users inputUser = new Users
            {
                Username = textBox1.Text.Trim(),
                Password = textBox2.Text.Trim()
            };
            Users user = userController.ValidateLogin(inputUser);

            // 3) Check result
            if (user != null)
            {
                // 4) Store the role
                Role.Currentrole = user.Role;

                // 5) Show dashboard
                var dash = new DashbordForm();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password ❌",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            
        
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }








}
