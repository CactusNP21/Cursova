namespace Cursova
{
    public partial class ComputerForm : Form
    {
        BullsAndCowsAI Ai = new();
        string secretNumber = "";
        Player player = new();
        public ComputerForm()
        {
            InitializeComponent();
        }
        private void ResetGame()
        {

            prevAnswear.ResetText();
            title.Visible = false;
            checkBtn.Visible = false;
            startGameBtn.Visible = true;
            inputTextBox.ResetText();
            player.prevAns = "";

        }
        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            secretNumber = Ai.generateRnd();
            title.Visible = true;
            inputTextBox.Visible = true;
            startGameBtn.Visible = false;
            checkBtn.Visible = true;

        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            var res = Tools.Validate(inputTextBox.Text, secretNumber, player);
            if (res)
            {
                prevAnswear.Text = player.prevAns;
                if (player.bulls == "4")
                {
                    MessageBox.Show("Гравець переміг");
                    ResetGame();
                    return;
                }
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EntranceForm form = new();
            form.Show();
        }
    }
}
