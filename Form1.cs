using System;
using System.Diagnostics.Metrics;

namespace MathGame
{
    public partial class Form1 : Form
    {
        static Random random = new Random();
        private bool MiscellaneousQuestions = false;
        private List<Button> buttonList = new List<Button>();
        private Button? QuestionButton;
        private int CountProgress = 0;

        PlayerData playerData;
        MathQuestionsGenerator mathGenerator = new MathQuestionsGenerator();

        public Form1()
        {
            InitializeComponent();

            playerData = new PlayerData(true);

            buttonList.Add(button1);
            buttonList.Add(button2);
            buttonList.Add(button3);
            buttonList.Add(button4);

            lbResult.Visible = false;
            StopGameTimers();

            //pbTimeQuestion.Visible = false;

            MiscellaneousQuestions = cbRandomQuestions.Checked;

            SetGameText();
            NextQuestion();
        }
        private void StopGameTimers()
        {
            timer1.Stop();
            timer2.Stop();

            timer1.Enabled = false;
            timer2.Enabled = false;

            CountProgress = 0;
            pbTimeQuestion.Value = CountProgress;
        }
        private void SetGameText(){
            lbPoints.Text = "Acertos: " + playerData.RightAnswers.ToString();
            lbErrors.Text = "Erros: " + playerData.WrongAnswers.ToString();
            lbLevel.Text = "Nível: " + playerData.Level.ToString();
        }
        private void EndQuestion(int type){
            lbResult.Visible = true;
            switch (type){
                case 0:
                    lbResult.Text = "Resposta Correta!";
                    playerData.RightAnswers++;
                    playerData.Level++;
                    break;
                case 1:
                    lbResult.Text = "Resposta Incorreta!";
                    playerData.WrongAnswers++;
                    break;
                case 2:
                    lbResult.Text = "Tempo Esgotado!";
                    break;
            }

            SetGameText();
            StopGameTimers();

            if (cbNextQuestion.Checked){
                timer2.Interval = 2000;
                timer2.Tick += new EventHandler(NextQuestion_Tick);

                timer2.Enabled = true;
            }
        }
        private void NextQuestion_Tick(object Sender, EventArgs e){
            NextQuestion();
        }
        private void NextQuestion(){
            string question;
            int result;

            StopGameTimers();
            lbResult.Visible = false;

            mathGenerator.GenerateMathQuestion(playerData.Level, out question, out result);

            lbQuestion.Text = question;

            foreach (Button button in buttonList){
                button.Text = result + random.Next(0, 20 + 1).ToString();
               // button.ForeColor = Color.White;
            }

            QuestionButton = buttonList[random.Next(buttonList.Count)];
            QuestionButton.Text = result.ToString();
           // QuestionButton.ForeColor = Color.Green;

            if (cbNextQuestion.Checked){
                timer1.Interval = 1000;
                timer1.Enabled = true;

                this.timer1.Tick += new EventHandler(ProgressBarUpdate);
            }
        }
        private void ProgressBarUpdate(object sender, System.EventArgs e)
        {
            if (CountProgress >= 100){
                StopGameTimers();

                EndQuestion(2);
            }
            else{
                CountProgress += 5;

                if (CountProgress > 100)
                    CountProgress = 100;

                pbTimeQuestion.Value = (CountProgress > 100) ? 100 : CountProgress;
            }
        }
        private void pbTimeQuestion_Click(object sender, EventArgs e)
        {

        }

        private void cbTimeToRespond_CheckedChanged(object sender, EventArgs e){
            pbTimeQuestion.Visible = cbNextQuestion.Checked;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn == null)
                return;

            if (btn == QuestionButton){
                EndQuestion(0);
                return;
            }

            EndQuestion(1);
        }

        private void btnNewQuestion_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }
    }
}
