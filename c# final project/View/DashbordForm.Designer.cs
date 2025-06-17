namespace c__final_project.View
{
    partial class DashbordForm
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
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            button8 = new Button();
            button7 = new Button();
            U = new Panel();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            U.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(19, 134);
            button2.Name = "button2";
            button2.Size = new Size(127, 23);
            button2.TabIndex = 1;
            button2.Text = "UserDeatails";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(19, 264);
            button3.Name = "button3";
            button3.Size = new Size(127, 23);
            button3.TabIndex = 2;
            button3.Text = "Exams";
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(19, 232);
            button5.Name = "button5";
            button5.Size = new Size(127, 26);
            button5.TabIndex = 4;
            button5.Text = "Course";
            button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(164, 450);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.Location = new Point(41, 293);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 12;
            button4.Text = "Marks";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(41, 174);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Students";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "Admin", "Staff", "Lecturer", "Student" });
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Staff", "Lecturer", "Student" });
            comboBox1.Location = new Point(19, 96);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(127, 23);
            comboBox1.TabIndex = 9;
            comboBox1.Text = "Role";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button8
            // 
            button8.Location = new Point(41, 402);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 8;
            button8.Text = "Logout";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click_1;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(19, 203);
            button7.Name = "button7";
            button7.Size = new Size(127, 23);
            button7.TabIndex = 5;
            button7.Text = "Timetable";
            button7.UseVisualStyleBackColor = true;
            // 
            // U
            // 
            U.Controls.Add(label2);
            U.Controls.Add(label1);
            U.Controls.Add(textBox1);
            U.Dock = DockStyle.Top;
            U.Location = new Point(164, 0);
            U.Name = "U";
            U.Size = new Size(1084, 65);
            U.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(897, 47);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 11;
            label2.Text = "User :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(601, 47);
            label1.TabIndex = 0;
            label1.Text = " Unicom TIC Management System";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(939, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 23);
            textBox1.TabIndex = 10;
            // 
            // DashbordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 450);
            Controls.Add(U);
            Controls.Add(panel1);
            Name = "DashbordForm";
            Text = "Dashbord";
            Load += DashbordForm_Load;
            panel1.ResumeLayout(false);
            U.ResumeLayout(false);
            U.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button5;
        private Panel panel1;
        private Panel U;
        private Button button8;
        private Button button7;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button4;
        private Button button1;
        private Label label2;
    }
}