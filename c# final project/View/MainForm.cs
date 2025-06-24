
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
            textBox1.Focus();

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
            var user = UserController.ValidateLogin(textBox1.Text, textBox2.Text);

            if (user != null)
            {
                DashbordForm dash = new DashbordForm(user.Role, user.Username); /
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login ❌");
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
