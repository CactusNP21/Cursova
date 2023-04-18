namespace Cursova
{
    public partial class PlayersForm : Form
    {
        public PlayersForm()
        {
            InitializeComponent();
        }
        Player player1;
        Player player2;

        public void NextTurn()
        {
            P1GroupBox.Visible = !P1GroupBox.Visible;
            P2GroupBox.Visible = !P2GroupBox.Visible;
        }
        public void ResetGame()
        {
            P1GroupBox.Visible = false;
            P2GroupBox.Visible = false;
            checkP1GroupBox.Visible = false;
            checkP2GroupBox.Visible = false;

            generateP1GroupBox.Visible = true;
            generateP2GroupBox.Visible = true;
            startGameBtn.Visible = true;

            prevAnsP1Label.ResetText();
            prevAnsP2Label.ResetText();

            List<Control> p1gb = P1GroupBox.Controls.OfType<GroupBox>().Cast<Control>().ToList();
            foreach (Control cItem in p1gb)
            {
                var t = cItem.Controls.OfType<TextBox>().Cast<Control>().ToList();
                foreach (Control cItem2 in t)
                {
                    cItem2.ResetText();

                }
            }
            var p2gb = P2GroupBox.Controls.OfType<GroupBox>().Cast<Control>().ToList();
            foreach (Control cItem in p2gb)
            {
                var t = cItem.Controls.OfType<TextBox>().Cast<Control>().ToList();
                foreach (Control cItem2 in t)
                {
                    cItem2.ResetText();

                }
            }
        }
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            EntranceForm form1 = new();
            this.Hide();
            form1.Show();
        }


        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            startGameBtn.Visible = false;
            P1GroupBox.Visible = true;
        }

        private void GenerateP1Btn_Click(object sender, EventArgs e)
        {
            if (Tools.Uniqueness(generateP1TextBox.Text))
            {
                player1 = new Player(generateP1TextBox.Text);
                P1GroupBox.Visible = false;
                generateP1GroupBox.Visible = false;
                P2GroupBox.Visible = true;
                checkP1GroupBox.Visible = true;
            }
            else
            {
                Tools.IncorrectInput();
            }
        }

        private void GenerateP2Btn_Click(object sender, EventArgs e)
        {
            if (Tools.Uniqueness(generateP2TextBox.Text))
            {
                player2 = new Player(generateP2TextBox.Text);
                P2GroupBox.Visible = false;
                generateP2GroupBox.Visible = false;
                P1GroupBox.Visible = true;
                checkP2GroupBox.Visible = true;
            }
            else
            {
                Tools.IncorrectInput();
            }
        }

        private void CheckP1Btn_Click(object sender, EventArgs e)
        {
            var res = Tools.Validate(checkP1TextBox.Text, player2.secretNumber, player1);
            if (res)
            {
                prevAnsP1Label.Text = player1.prevAns;
                if (player1.bulls == "4")
                {
                    MessageBox.Show("Гравець 1 переміг");
                    ResetGame();
                    return;
                }
                NextTurn();
            }

        }

        private void CheckP2Btn_Click(object sender, EventArgs e)
        {
            var res = Tools.Validate(checkP2TextBox.Text, player1.secretNumber, player2);
            if (res)
            {
                prevAnsP2Label.Text = player2.prevAns;
                if (player2.bulls == "4")
                {
                    MessageBox.Show("Гравець 2 переміг");
                    ResetGame();
                    return;
                }
                NextTurn();
            }
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
