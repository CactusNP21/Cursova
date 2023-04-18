namespace Cursova
{
    partial class EntranceForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            title = new Label();
            PlayersPathBtn = new Button();
            ComputerPathBtn = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(417, 83);
            title.Name = "title";
            title.Size = new Size(334, 46);
            title.TabIndex = 0;
            title.Text = "Виберіть режим гри";
            // 
            // PlayersPathBtn
            // 
            PlayersPathBtn.Location = new Point(277, 189);
            PlayersPathBtn.Name = "PlayersPathBtn";
            PlayersPathBtn.Size = new Size(225, 103);
            PlayersPathBtn.TabIndex = 1;
            PlayersPathBtn.Text = "Два гравці";
            PlayersPathBtn.UseVisualStyleBackColor = true;
            PlayersPathBtn.Click += PlayersPathBtn_Click;
            // 
            // ComputerPathBtn
            // 
            ComputerPathBtn.Location = new Point(638, 189);
            ComputerPathBtn.Name = "ComputerPathBtn";
            ComputerPathBtn.Size = new Size(225, 103);
            ComputerPathBtn.TabIndex = 2;
            ComputerPathBtn.Text = "Проти комп'ютера";
            ComputerPathBtn.UseVisualStyleBackColor = true;
            ComputerPathBtn.Click += ComputerPathBtn_Click;
            // 
            // EntranceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 600);
            Controls.Add(ComputerPathBtn);
            Controls.Add(PlayersPathBtn);
            Controls.Add(title);
            Name = "EntranceForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Button PlayersPathBtn;
        private Button ComputerPathBtn;
    }
}