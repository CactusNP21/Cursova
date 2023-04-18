namespace Cursova
{
    partial class PlayersForm
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
            returnBtn = new Button();
            startGameBtn = new Button();
            P1GroupBox = new GroupBox();
            prevAnsP1GroupBox = new GroupBox();
            panel1 = new Panel();
            prevAnsP1Label = new Label();
            checkP1GroupBox = new GroupBox();
            checkP1Btn = new Button();
            label3 = new Label();
            checkP1TextBox = new TextBox();
            generateP1GroupBox = new GroupBox();
            generateP1Btn = new Button();
            label2 = new Label();
            generateP1TextBox = new TextBox();
            label1 = new Label();
            P2GroupBox = new GroupBox();
            prevAnsP2GroupBox = new GroupBox();
            panel2 = new Panel();
            prevAnsP2Label = new Label();
            checkP2GroupBox = new GroupBox();
            checkP2Btn = new Button();
            label4 = new Label();
            checkP2TextBox = new TextBox();
            label5 = new Label();
            generateP2GroupBox = new GroupBox();
            generateP2Btn = new Button();
            label6 = new Label();
            generateP2TextBox = new TextBox();
            button7 = new Button();
            P1GroupBox.SuspendLayout();
            prevAnsP1GroupBox.SuspendLayout();
            panel1.SuspendLayout();
            checkP1GroupBox.SuspendLayout();
            generateP1GroupBox.SuspendLayout();
            P2GroupBox.SuspendLayout();
            prevAnsP2GroupBox.SuspendLayout();
            panel2.SuspendLayout();
            checkP2GroupBox.SuspendLayout();
            generateP2GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // returnBtn
            // 
            returnBtn.Location = new Point(40, 614);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(205, 62);
            returnBtn.TabIndex = 0;
            returnBtn.Text = "Назад";
            returnBtn.UseVisualStyleBackColor = true;
            returnBtn.Click += ReturnBtn_Click;
            // 
            // startGameBtn
            // 
            startGameBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            startGameBtn.Location = new Point(360, 222);
            startGameBtn.Name = "startGameBtn";
            startGameBtn.Size = new Size(305, 131);
            startGameBtn.TabIndex = 1;
            startGameBtn.Text = "Розпочати";
            startGameBtn.UseVisualStyleBackColor = true;
            startGameBtn.Click += StartGameBtn_Click;
            // 
            // P1GroupBox
            // 
            P1GroupBox.Controls.Add(prevAnsP1GroupBox);
            P1GroupBox.Controls.Add(checkP1GroupBox);
            P1GroupBox.Controls.Add(generateP1GroupBox);
            P1GroupBox.Controls.Add(label1);
            P1GroupBox.Location = new Point(12, 12);
            P1GroupBox.Name = "P1GroupBox";
            P1GroupBox.Size = new Size(517, 571);
            P1GroupBox.TabIndex = 2;
            P1GroupBox.TabStop = false;
            P1GroupBox.Visible = false;
            // 
            // prevAnsP1GroupBox
            // 
            prevAnsP1GroupBox.Controls.Add(panel1);
            prevAnsP1GroupBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            prevAnsP1GroupBox.Location = new Point(46, 347);
            prevAnsP1GroupBox.Name = "prevAnsP1GroupBox";
            prevAnsP1GroupBox.Size = new Size(387, 203);
            prevAnsP1GroupBox.TabIndex = 3;
            prevAnsP1GroupBox.TabStop = false;
            prevAnsP1GroupBox.Text = "Попередні значення";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(prevAnsP1Label);
            panel1.Location = new Point(21, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 160);
            panel1.TabIndex = 1;
            // 
            // prevAnsP1Label
            // 
            prevAnsP1Label.AutoSize = true;
            prevAnsP1Label.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            prevAnsP1Label.Location = new Point(12, 6);
            prevAnsP1Label.Name = "prevAnsP1Label";
            prevAnsP1Label.Size = new Size(15, 23);
            prevAnsP1Label.TabIndex = 0;
            prevAnsP1Label.Text = " ";
            // 
            // checkP1GroupBox
            // 
            checkP1GroupBox.Controls.Add(checkP1Btn);
            checkP1GroupBox.Controls.Add(label3);
            checkP1GroupBox.Controls.Add(checkP1TextBox);
            checkP1GroupBox.Location = new Point(111, 88);
            checkP1GroupBox.Name = "checkP1GroupBox";
            checkP1GroupBox.Size = new Size(306, 116);
            checkP1GroupBox.TabIndex = 2;
            checkP1GroupBox.TabStop = false;
            checkP1GroupBox.Visible = false;
            // 
            // checkP1Btn
            // 
            checkP1Btn.Location = new Point(32, 74);
            checkP1Btn.Name = "checkP1Btn";
            checkP1Btn.Size = new Size(225, 36);
            checkP1Btn.TabIndex = 5;
            checkP1Btn.Text = "Перевірити";
            checkP1Btn.UseVisualStyleBackColor = true;
            checkP1Btn.Click += CheckP1Btn_Click;
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
            // checkP1TextBox
            // 
            checkP1TextBox.Location = new Point(22, 41);
            checkP1TextBox.Name = "checkP1TextBox";
            checkP1TextBox.Size = new Size(247, 27);
            checkP1TextBox.TabIndex = 3;
            // 
            // generateP1GroupBox
            // 
            generateP1GroupBox.BackColor = SystemColors.Control;
            generateP1GroupBox.Controls.Add(generateP1Btn);
            generateP1GroupBox.Controls.Add(label2);
            generateP1GroupBox.Controls.Add(generateP1TextBox);
            generateP1GroupBox.Location = new Point(111, 210);
            generateP1GroupBox.Name = "generateP1GroupBox";
            generateP1GroupBox.Size = new Size(306, 131);
            generateP1GroupBox.TabIndex = 2;
            generateP1GroupBox.TabStop = false;
            // 
            // generateP1Btn
            // 
            generateP1Btn.Location = new Point(74, 91);
            generateP1Btn.Name = "generateP1Btn";
            generateP1Btn.Size = new Size(169, 32);
            generateP1Btn.TabIndex = 3;
            generateP1Btn.Text = "Задати число";
            generateP1Btn.UseVisualStyleBackColor = true;
            generateP1Btn.Click += GenerateP1Btn_Click;
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
            // generateP1TextBox
            // 
            generateP1TextBox.Location = new Point(22, 58);
            generateP1TextBox.Name = "generateP1TextBox";
            generateP1TextBox.Size = new Size(269, 27);
            generateP1TextBox.TabIndex = 1;
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
            // P2GroupBox
            // 
            P2GroupBox.Controls.Add(prevAnsP2GroupBox);
            P2GroupBox.Controls.Add(checkP2GroupBox);
            P2GroupBox.Controls.Add(label5);
            P2GroupBox.Controls.Add(generateP2GroupBox);
            P2GroupBox.Location = new Point(610, 12);
            P2GroupBox.Name = "P2GroupBox";
            P2GroupBox.Size = new Size(476, 571);
            P2GroupBox.TabIndex = 3;
            P2GroupBox.TabStop = false;
            P2GroupBox.Visible = false;
            // 
            // prevAnsP2GroupBox
            // 
            prevAnsP2GroupBox.Controls.Add(panel2);
            prevAnsP2GroupBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            prevAnsP2GroupBox.Location = new Point(36, 347);
            prevAnsP2GroupBox.Name = "prevAnsP2GroupBox";
            prevAnsP2GroupBox.Size = new Size(420, 203);
            prevAnsP2GroupBox.TabIndex = 4;
            prevAnsP2GroupBox.TabStop = false;
            prevAnsP2GroupBox.Text = "Попередні значення";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(prevAnsP2Label);
            panel2.Location = new Point(21, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 160);
            panel2.TabIndex = 2;
            // 
            // prevAnsP2Label
            // 
            prevAnsP2Label.AutoSize = true;
            prevAnsP2Label.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            prevAnsP2Label.Location = new Point(17, 6);
            prevAnsP2Label.Name = "prevAnsP2Label";
            prevAnsP2Label.Size = new Size(15, 23);
            prevAnsP2Label.TabIndex = 0;
            prevAnsP2Label.Text = " ";
            // 
            // checkP2GroupBox
            // 
            checkP2GroupBox.Controls.Add(checkP2Btn);
            checkP2GroupBox.Controls.Add(label4);
            checkP2GroupBox.Controls.Add(checkP2TextBox);
            checkP2GroupBox.Location = new Point(91, 88);
            checkP2GroupBox.Name = "checkP2GroupBox";
            checkP2GroupBox.Size = new Size(306, 116);
            checkP2GroupBox.TabIndex = 2;
            checkP2GroupBox.TabStop = false;
            checkP2GroupBox.Visible = false;
            // 
            // checkP2Btn
            // 
            checkP2Btn.Location = new Point(42, 74);
            checkP2Btn.Name = "checkP2Btn";
            checkP2Btn.Size = new Size(225, 36);
            checkP2Btn.TabIndex = 6;
            checkP2Btn.Text = "Перевірити";
            checkP2Btn.UseVisualStyleBackColor = true;
            checkP2Btn.Click += CheckP2Btn_Click;
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
            // checkP2TextBox
            // 
            checkP2TextBox.Location = new Point(21, 41);
            checkP2TextBox.Name = "checkP2TextBox";
            checkP2TextBox.Size = new Size(269, 27);
            checkP2TextBox.TabIndex = 3;
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
            // generateP2GroupBox
            // 
            generateP2GroupBox.BackColor = SystemColors.Control;
            generateP2GroupBox.Controls.Add(generateP2Btn);
            generateP2GroupBox.Controls.Add(label6);
            generateP2GroupBox.Controls.Add(generateP2TextBox);
            generateP2GroupBox.Location = new Point(91, 210);
            generateP2GroupBox.Name = "generateP2GroupBox";
            generateP2GroupBox.Size = new Size(306, 131);
            generateP2GroupBox.TabIndex = 2;
            generateP2GroupBox.TabStop = false;
            // 
            // generateP2Btn
            // 
            generateP2Btn.Location = new Point(75, 91);
            generateP2Btn.Name = "generateP2Btn";
            generateP2Btn.Size = new Size(169, 32);
            generateP2Btn.TabIndex = 4;
            generateP2Btn.Text = "Задати число";
            generateP2Btn.UseVisualStyleBackColor = true;
            generateP2Btn.Click += GenerateP2Btn_Click;
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
            // generateP2TextBox
            // 
            generateP2TextBox.Location = new Point(21, 58);
            generateP2TextBox.Name = "generateP2TextBox";
            generateP2TextBox.Size = new Size(269, 27);
            generateP2TextBox.TabIndex = 1;
            // 
            // button7
            // 
            button7.Location = new Point(428, 614);
            button7.Name = "button7";
            button7.Size = new Size(271, 63);
            button7.TabIndex = 4;
            button7.Text = "Рестарт";
            button7.UseVisualStyleBackColor = true;
            button7.Click += RestartBtn_Click;
            // 
            // PlayersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 705);
            Controls.Add(button7);
            Controls.Add(P2GroupBox);
            Controls.Add(P1GroupBox);
            Controls.Add(startGameBtn);
            Controls.Add(returnBtn);
            Name = "PlayersForm";
            Text = "Form3";
            P1GroupBox.ResumeLayout(false);
            P1GroupBox.PerformLayout();
            prevAnsP1GroupBox.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            checkP1GroupBox.ResumeLayout(false);
            checkP1GroupBox.PerformLayout();
            generateP1GroupBox.ResumeLayout(false);
            generateP1GroupBox.PerformLayout();
            P2GroupBox.ResumeLayout(false);
            P2GroupBox.PerformLayout();
            prevAnsP2GroupBox.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            checkP2GroupBox.ResumeLayout(false);
            checkP2GroupBox.PerformLayout();
            generateP2GroupBox.ResumeLayout(false);
            generateP2GroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button returnBtn;
        private Button startGameBtn;
        private GroupBox P1GroupBox;
        private Label label3;
        private TextBox checkP1TextBox;
        private GroupBox generateP1GroupBox;
        private Label label2;
        private TextBox generateP1TextBox;
        private Label label1;
        private GroupBox checkP1GroupBox;
        private GroupBox P2GroupBox;
        private GroupBox checkP2GroupBox;
        private Label label4;
        private TextBox checkP2TextBox;
        private Label label5;
        private GroupBox generateP2GroupBox;
        private Label label6;
        private TextBox generateP2TextBox;
        private GroupBox prevAnsP1GroupBox;
        private Label prevAnsP1Label;
        private GroupBox prevAnsP2GroupBox;
        private Button checkP1Btn;
        private Button generateP1Btn;
        private Button checkP2Btn;
        private Button generateP2Btn;
        private Panel panel1;
        private Panel panel2;
        private Label prevAnsP2Label;
        private Button button7;
    }
}