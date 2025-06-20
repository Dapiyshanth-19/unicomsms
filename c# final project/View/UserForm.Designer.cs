namespace c__final_project.View
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label11 = new Label();
            cmbRole = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox16 = new TextBox();
            textBox17 = new TextBox();
            label14 = new Label();
            label12 = new Label();
            label13 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label15 = new Label();
            button1 = new Button();
            button2 = new Button();
            label10 = new Label();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            btnCheckColumns = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(351, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 138F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 71F));
            tableLayoutPanel1.Controls.Add(label11, 0, 9);
            tableLayoutPanel1.Controls.Add(cmbRole, 1, 9);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 7);
            tableLayoutPanel1.Controls.Add(textBox5, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label9, 0, 8);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(label8, 0, 7);
            tableLayoutPanel1.Controls.Add(textBox16, 1, 4);
            tableLayoutPanel1.Controls.Add(textBox17, 1, 5);
            tableLayoutPanel1.Controls.Add(label14, 2, 0);
            tableLayoutPanel1.Controls.Add(label12, 2, 1);
            tableLayoutPanel1.Controls.Add(label13, 2, 5);
            tableLayoutPanel1.Controls.Add(radioButton1, 3, 0);
            tableLayoutPanel1.Controls.Add(radioButton2, 4, 0);
            tableLayoutPanel1.Controls.Add(comboBox1, 3, 1);
            tableLayoutPanel1.Controls.Add(comboBox2, 3, 2);
            tableLayoutPanel1.Controls.Add(label15, 2, 2);
            tableLayoutPanel1.Location = new Point(27, 44);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.5555553F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.11111F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.38898F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.Size = new Size(642, 361);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 322);
            label11.Name = "label11";
            label11.Size = new Size(30, 15);
            label11.TabIndex = 16;
            label11.Text = "Role";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Staff", "Lecturer", "Student" });
            cmbRole.Location = new Point(125, 325);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(121, 23);
            cmbRole.TabIndex = 4;
            cmbRole.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(125, 250);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(125, 120);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(125, 75);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 72);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 4;
            label3.Text = "Phonenumber";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Firstname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 33);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Lastname";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(125, 36);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 117);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 153);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 8;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 186);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 9;
            label6.Text = "NIC number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 289);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 212);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 247);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 11;
            label8.Text = "Date of birth";
            // 
            // textBox16
            // 
            textBox16.Location = new Point(125, 156);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(100, 23);
            textBox16.TabIndex = 16;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(125, 189);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(100, 23);
            textBox17.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(369, 0);
            label14.Name = "label14";
            label14.Size = new Size(45, 15);
            label14.TabIndex = 20;
            label14.Text = "Gender";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(369, 33);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 18;
            label12.Text = "Course";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(369, 186);
            label13.Name = "label13";
            label13.Size = new Size(0, 15);
            label13.TabIndex = 19;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(436, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 30;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(574, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 23;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Diploma in Software Development", "English and Communication", "Diploma in Management System", "AI and Data Science" });
            comboBox1.Location = new Point(436, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(126, 23);
            comboBox1.TabIndex = 21;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(436, 75);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 31;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(369, 72);
            label15.Name = "label15";
            label15.Size = new Size(51, 15);
            label15.TabIndex = 23;
            label15.Text = "Subjects";
            label15.Click += label15_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 9);
            button1.Name = "button1";
            button1.Size = new Size(65, 26);
            button1.TabIndex = 2;
            button1.Text = "<<<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(365, 478);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Add User";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(351, 9);
            label10.Name = "label10";
            label10.Size = new Size(117, 32);
            label10.TabIndex = 15;
            label10.Text = "User add";
            // 
            // button3
            // 
            button3.Location = new Point(482, 478);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 16;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(606, 478);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 17;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(675, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(626, 361);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnCheckColumns
            // 
            btnCheckColumns.Location = new Point(814, 469);
            btnCheckColumns.Name = "btnCheckColumns";
            btnCheckColumns.Size = new Size(75, 23);
            btnCheckColumns.TabIndex = 19;
            btnCheckColumns.Text = "button5";
            btnCheckColumns.UseVisualStyleBackColor = true;
            btnCheckColumns.Click += btnCheckColumns_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 531);
            Controls.Add(btnCheckColumns);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label10);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(textBox1);
            Name = "UserForm";
            Text = "Addusers";
            Load += UserForm_Load_1;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private Label label9;
        private Label label7;
        private Label label8;
        private TextBox textBox16;
        private TextBox textBox17;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbRole;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private ComboBox comboBox1;
        private Label label15;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox2;
        private Button btnCheckColumns;
    }
}