namespace Cursova
{
    partial class ComputerForm
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
            title = new Label();
            inputTextBox = new TextBox();
            startGameBtn = new Button();
            checkBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            prevAnswear = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // returnBtn
            // 
            returnBtn.Location = new Point(38, 545);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(244, 62);
            returnBtn.TabIndex = 0;
            returnBtn.Text = "Назад";
            returnBtn.UseVisualStyleBackColor = true;
            returnBtn.Click += ReturnBtn_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(337, 37);
            title.Name = "title";
            title.Size = new Size(499, 46);
            title.TabIndex = 1;
            title.Text = "Введіть чотирьохзначне число";
            title.Visible = false;
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(506, 111);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(185, 27);
            inputTextBox.TabIndex = 2;
            inputTextBox.Visible = false;
            // 
            // startGameBtn
            // 
            startGameBtn.Location = new Point(449, 189);
            startGameBtn.Name = "startGameBtn";
            startGameBtn.Size = new Size(299, 92);
            startGameBtn.TabIndex = 3;
            startGameBtn.Text = "Розпочати гру";
            startGameBtn.UseVisualStyleBackColor = true;
            startGameBtn.Click += StartGameBtn_Click;
            // 
            // checkBtn
            // 
            checkBtn.Location = new Point(449, 189);
            checkBtn.Name = "checkBtn";
            checkBtn.Size = new Size(299, 92);
            checkBtn.TabIndex = 4;
            checkBtn.Text = "Перевірити";
            checkBtn.UseVisualStyleBackColor = true;
            checkBtn.Visible = false;
            checkBtn.Click += CheckBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(522, 372);
            label2.Name = "label2";
            label2.Size = new Size(0, 38);
            label2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(522, 433);
            label3.Name = "label3";
            label3.Size = new Size(0, 38);
            label3.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(prevAnswear);
            panel1.Location = new Point(428, 319);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 333);
            panel1.TabIndex = 12;
            // 
            // prevAnswear
            // 
            prevAnswear.AutoSize = true;
            prevAnswear.Location = new Point(45, 37);
            prevAnswear.Name = "prevAnswear";
            prevAnswear.Size = new Size(17, 20);
            prevAnswear.TabIndex = 0;
            prevAnswear.Text = "  ";
            // 
            // ComputerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 664);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkBtn);
            Controls.Add(startGameBtn);
            Controls.Add(inputTextBox);
            Controls.Add(title);
            Controls.Add(returnBtn);
            Name = "ComputerForm";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button returnBtn;
        private Label title;
        private TextBox inputTextBox;
        private Button startGameBtn;
        private Button checkBtn;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label prevAnswear;
    }
}