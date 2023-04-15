namespace Cursova
{
    partial class Form3
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
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            groupBox7 = new GroupBox();
            panel1 = new Panel();
            label7 = new Label();
            groupBox3 = new GroupBox();
            button5 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            button3 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox4 = new GroupBox();
            groupBox8 = new GroupBox();
            panel2 = new Panel();
            label9 = new Label();
            label8 = new Label();
            groupBox5 = new GroupBox();
            button6 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            groupBox6 = new GroupBox();
            button4 = new Button();
            label6 = new Label();
            textBox4 = new TextBox();
            button7 = new Button();
            groupBox1.SuspendLayout();
            groupBox7.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox8.SuspendLayout();
            panel2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(40, 614);
            button1.Name = "button1";
            button1.Size = new Size(205, 62);
            button1.TabIndex = 0;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(360, 222);
            button2.Name = "button2";
            button2.Size = new Size(305, 131);
            button2.TabIndex = 1;
            button2.Text = "Розпочати";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox7);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(517, 571);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Visible = false;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(panel1);
            groupBox7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox7.Location = new Point(46, 347);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(387, 203);
            groupBox7.TabIndex = 3;
            groupBox7.TabStop = false;
            groupBox7.Text = "Попередні значення";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(21, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 160);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 14);
            label7.Name = "label7";
            label7.Size = new Size(15, 23);
            label7.TabIndex = 0;
            label7.Text = " ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Location = new Point(111, 88);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(306, 116);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Visible = false;
            // 
            // button5
            // 
            button5.Location = new Point(32, 74);
            button5.Name = "button5";
            button5.Size = new Size(225, 36);
            button5.TabIndex = 5;
            button5.Text = "Перевірити";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(82, 13);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 4;
            label3.Text = "Відгадує число";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(247, 27);
            textBox2.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(111, 210);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(306, 131);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(74, 91);
            button3.Name = "button3";
            button3.Size = new Size(169, 32);
            button3.TabIndex = 3;
            button3.Text = "Задати число";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(87, 20);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 2;
            label2.Text = "Загадує число";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(193, 35);
            label1.Name = "label1";
            label1.Size = new Size(154, 41);
            label1.TabIndex = 0;
            label1.Text = "Гравець 1";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox8);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Location = new Point(610, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(476, 571);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            groupBox4.Visible = false;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(panel2);
            groupBox8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox8.Location = new Point(36, 347);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(420, 203);
            groupBox8.TabIndex = 4;
            groupBox8.TabStop = false;
            groupBox8.Text = "Попередні значення";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(21, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 160);
            panel2.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(17, 6);
            label9.Name = "label9";
            label9.Size = new Size(15, 23);
            label9.TabIndex = 0;
            label9.Text = " ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(43, 38);
            label8.Name = "label8";
            label8.Size = new Size(20, 23);
            label8.TabIndex = 0;
            label8.Text = "  ";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button6);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(textBox3);
            groupBox5.Location = new Point(91, 88);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(306, 116);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Visible = false;
            // 
            // button6
            // 
            button6.Location = new Point(42, 74);
            button6.Name = "button6";
            button6.Size = new Size(225, 36);
            button6.TabIndex = 6;
            button6.Text = "Перевірити";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(86, 13);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 4;
            label4.Text = "Відгадує число";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(21, 41);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(269, 27);
            textBox3.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(166, 35);
            label5.Name = "label5";
            label5.Size = new Size(154, 41);
            label5.TabIndex = 0;
            label5.Text = "Гравець 2";
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SystemColors.Control;
            groupBox6.Controls.Add(button4);
            groupBox6.Controls.Add(label6);
            groupBox6.Controls.Add(textBox4);
            groupBox6.Location = new Point(91, 210);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(306, 131);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(75, 91);
            button4.Name = "button4";
            button4.Size = new Size(169, 32);
            button4.TabIndex = 4;
            button4.Text = "Задати число";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(86, 20);
            label6.Name = "label6";
            label6.Size = new Size(127, 25);
            label6.TabIndex = 2;
            label6.Text = "Загадує число";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(21, 58);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(269, 27);
            textBox4.TabIndex = 1;
            // 
            // button7
            // 
            button7.Location = new Point(428, 614);
            button7.Name = "button7";
            button7.Size = new Size(271, 63);
            button7.TabIndex = 4;
            button7.Text = "Рестарт";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 705);
            Controls.Add(button7);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox8.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private GroupBox groupBox6;
        private Label label6;
        private TextBox textBox4;
        private GroupBox groupBox7;
        private Label label7;
        private GroupBox groupBox8;
        private Label label8;
        private Button button5;
        private Button button3;
        private Button button6;
        private Button button4;
        private Panel panel1;
        private Panel panel2;
        private Label label9;
        private Button button7;
    }
}