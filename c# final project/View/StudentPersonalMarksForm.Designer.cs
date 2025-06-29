namespace c__final_project.View
{
    partial class StudentPersonalMarksForm
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
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 83);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Index number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 239);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "exam name";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(314, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(349, 240);
            dataGridView1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(161, 231);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(161, 188);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(161, 130);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 138);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "course";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 191);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 8;
            label4.Text = "subject";
            // 
            // button1
            // 
            button1.Location = new Point(446, 350);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "view marks";
            button1.UseVisualStyleBackColor = true;
            // 
            // StudentPersonalMarksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentPersonalMarksForm";
            Text = "StudentPersonalMarksForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}