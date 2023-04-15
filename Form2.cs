namespace Cursova
{
    public partial class Form2 : Form
    {
        BullsAndCowsAI Ai = new();
        string secretNumber = "";
        Player player = new();
        public Form2()
        {
            InitializeComponent();
        }
        private void ResetGame()
        {

            label4.ResetText();
            label1.Visible = false;
            button3.Visible = false;
            button2.Visible = true;
            textBox1.ResetText();
            player.prevAns = "";

        }
        private void button2_Click(object sender, EventArgs e)
        {
            secretNumber = Ai.generateRnd();
            label1.Visible = true;
            textBox1.Visible = true;
            button2.Visible = false;
            button3.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var res = Tools.Validate(textBox1.Text, secretNumber, player);
            if (res)
            {
                label4.Text = player.prevAns;
                if (player.bulls == "4")
                {
                    MessageBox.Show("Гравець 1 переміг");
                    ResetGame();
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new();
            form.Show();
        }
    }
}
