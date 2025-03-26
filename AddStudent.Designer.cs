namespace StudentManagerWinform
{
    partial class AddStudent
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
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 75);
            label1.Name = "label1";
            label1.Size = new Size(130, 46);
            label1.TabIndex = 0;
            label1.Text = "学生ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 157);
            label2.Name = "label2";
            label2.Size = new Size(164, 46);
            label2.TabIndex = 1;
            label2.Text = "学生姓名";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 239);
            label3.Name = "label3";
            label3.Size = new Size(164, 46);
            label3.TabIndex = 2;
            label3.Text = "学生年龄";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(245, 314);
            label4.Name = "label4";
            label4.Size = new Size(164, 46);
            label4.TabIndex = 3;
            label4.Text = "学生成绩";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(437, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 53);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(437, 150);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 53);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(437, 232);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(277, 53);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(437, 307);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(277, 53);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(319, 428);
            button1.Name = "button1";
            button1.Size = new Size(303, 76);
            button1.TabIndex = 8;
            button1.Text = "提交";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(22F, 46F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 597);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Margin = new Padding(6);
            Name = "AddStudent";
            Text = "AddStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
    }
}