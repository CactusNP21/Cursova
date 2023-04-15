namespace Cursova
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Player player1;
        Player player2;

        public void NextTurn()
        {
            groupBox1.Visible = !groupBox1.Visible;
            groupBox4.Visible = !groupBox4.Visible;
        }
        public void ResetGame()
        {
            groupBox1.Visible = false;
            groupBox4.Visible = false;
            groupBox3.Visible = false;
            groupBox5.Visible = false;

            groupBox2.Visible = true;
            groupBox6.Visible = true;
            button2.Visible = true;

            label7.ResetText();
            label8.ResetText();

            List<Control> gb1 = groupBox1.Controls.OfType<GroupBox>().Cast<Control>().ToList();
            foreach (Control cItem in gb1)
            {
                var t = cItem.Controls.OfType<TextBox>().Cast<Control>().ToList();
                foreach (Control cItem2 in t)
                {
                    cItem2.ResetText();

                }
            }
            var gb4 = groupBox4.Controls.OfType<GroupBox>().Cast<Control>().ToList();
            foreach (Control cItem in gb4)
            {
                var t = cItem.Controls.OfType<TextBox>().Cast<Control>().ToList();
                foreach (Control cItem2 in t)
                {
                    cItem2.ResetText();

                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new();
            this.Hide();
            form1.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            groupBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Tools.Uniqueness(textBox1.Text))
            {
                player1 = new Player(textBox1.Text);
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox4.Visible = true;
                groupBox3.Visible = true;
            }
            else
            {
                Tools.IncorrectInput();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Tools.Uniqueness(textBox4.Text))
            {
                player2 = new Player(textBox4.Text);
                groupBox4.Visible = false;
                groupBox6.Visible = false;
                groupBox1.Visible = true;
                groupBox5.Visible = true;
            }
            else
            {
                Tools.IncorrectInput();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var res = Tools.Validate(textBox2.Text, player2.secretNumber, player1);
            if (res)
            {
                label7.Text = player1.prevAns;
                if (player1.bulls == "4")
                {
                    MessageBox.Show("Гравець 1 переміг");
                    ResetGame();
                    return;
                }
                NextTurn();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var res = Tools.Validate(textBox3.Text, player1.secretNumber, player2);
            if (res)
            {
                label8.Text = player2.prevAns;
                if (player2.bulls == "4")
                {
                    MessageBox.Show("Гравець 2 переміг");
                    ResetGame();
                    return;
                }
                NextTurn();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
