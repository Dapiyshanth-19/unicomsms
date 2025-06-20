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
            UserDeatails_Btn = new Button();
            Exams_Btn = new Button();
            Course_Btn = new Button();
            panel1 = new Panel();
            Marks_Btn = new Button();
            Students_Btn = new Button();
            Logout_Btn = new Button();
            Timetable_Btn = new Button();
            U = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            U.SuspendLayout();
            SuspendLayout();
            // 
            // UserDeatails_Btn
            // 
            UserDeatails_Btn.Location = new Point(19, 134);
            UserDeatails_Btn.Name = "UserDeatails_Btn";
            UserDeatails_Btn.Size = new Size(127, 23);
            UserDeatails_Btn.TabIndex = 1;
            UserDeatails_Btn.Text = "UserDeatails";
            UserDeatails_Btn.UseVisualStyleBackColor = true;
            UserDeatails_Btn.Click += button2_Click;
            // 
            // Exams_Btn
            // 
            Exams_Btn.Location = new Point(19, 264);
            Exams_Btn.Name = "Exams_Btn";
            Exams_Btn.Size = new Size(127, 23);
            Exams_Btn.TabIndex = 2;
            Exams_Btn.Text = "Exams";
            Exams_Btn.UseVisualStyleBackColor = true;
            // 
            // Course_Btn
            // 
            Course_Btn.Location = new Point(19, 232);
            Course_Btn.Name = "Course_Btn";
            Course_Btn.Size = new Size(127, 26);
            Course_Btn.TabIndex = 4;
            Course_Btn.Text = "Course";
            Course_Btn.UseVisualStyleBackColor = true;
            Course_Btn.Click += Course_Btn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(Marks_Btn);
            panel1.Controls.Add(Students_Btn);
            panel1.Controls.Add(Logout_Btn);
            panel1.Controls.Add(Timetable_Btn);
            panel1.Controls.Add(Course_Btn);
            panel1.Controls.Add(Exams_Btn);
            panel1.Controls.Add(UserDeatails_Btn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(164, 450);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // Marks_Btn
            // 
            Marks_Btn.Location = new Point(41, 293);
            Marks_Btn.Name = "Marks_Btn";
            Marks_Btn.Size = new Size(75, 23);
            Marks_Btn.TabIndex = 12;
            Marks_Btn.Text = "Marks";
            Marks_Btn.UseVisualStyleBackColor = true;
            // 
            // Students_Btn
            // 
            Students_Btn.Location = new Point(19, 163);
            Students_Btn.Name = "Students_Btn";
            Students_Btn.Size = new Size(127, 25);
            Students_Btn.TabIndex = 11;
            Students_Btn.Text = "Students";
            Students_Btn.UseVisualStyleBackColor = true;
            // 
            // Logout_Btn
            // 
            Logout_Btn.Location = new Point(41, 402);
            Logout_Btn.Name = "Logout_Btn";
            Logout_Btn.Size = new Size(75, 23);
            Logout_Btn.TabIndex = 8;
            Logout_Btn.Text = "Logout";
            Logout_Btn.UseVisualStyleBackColor = true;
            Logout_Btn.Click += button8_Click_1;
            // 
            // Timetable_Btn
            // 
            Timetable_Btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Timetable_Btn.Location = new Point(19, 203);
            Timetable_Btn.Name = "Timetable_Btn";
            Timetable_Btn.Size = new Size(127, 23);
            Timetable_Btn.TabIndex = 5;
            Timetable_Btn.Text = "Timetable";
            Timetable_Btn.UseVisualStyleBackColor = true;
            // 
            // U
            // 
            U.Controls.Add(label2);
            U.Controls.Add(label1);
            U.Dock = DockStyle.Top;
            U.Location = new Point(164, 0);
            U.Name = "U";
            U.Size = new Size(1084, 65);
            U.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(888, 41);
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
            // DashbordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 450);
            Controls.Add(U);
            Controls.Add(panel1);
            Name = "DashbordForm";
            Text = " ";
            Load += DashbordForm_Load;
            panel1.ResumeLayout(false);
            U.ResumeLayout(false);
            U.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button UserDeatails_Btn;
        private Button Exams_Btn;
        private Button Course_Btn;
        private Panel panel1;
        private Panel U;
        private Button Logout_Btn;
        private Button Timetable_Btn;
        private Label label1;
        private Button Marks_Btn;
        private Button Students_Btn;
        private Label label2;
    }
}