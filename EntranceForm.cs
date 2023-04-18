namespace Cursova
{
    public partial class EntranceForm : Form
    {
        public EntranceForm()
        {
            InitializeComponent();
        }

        private void ComputerPathBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComputerForm f = new ComputerForm();
            f.Show();
        }

        private void PlayersPathBtn_Click(object sender, EventArgs e)
        {
            PlayersForm f = new PlayersForm();
            this.Hide();
            f.Show();
        }
    }
}