namespace MathGame
{
    public partial class Form1 : Form
    {
        private bool MiscellaneousQuestions = false;
        public Form1()
        {
            InitializeComponent();

            lbResult.Visible = false;
            pbTimeQuestion.Visible = false;

            MiscellaneousQuestions = cbRandomQuestions.Checked;
        }

        private void pbTimeQuestion_Click(object sender, EventArgs e)
        {

        }

        private void cbTimeToRespond_CheckedChanged(object sender, EventArgs e)
        {
            pbTimeQuestion.Enabled = cbTimeToRespond.Checked;
            pbTimeQuestion.Visible = cbTimeToRespond.Checked;
        }
    }
}
