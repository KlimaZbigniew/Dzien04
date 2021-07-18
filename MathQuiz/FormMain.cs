using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            panel1Quiz.BringToFront();
            SetupQuiz();
        }

        private Random random = new Random(0);

        private int RandomNumber(int min, int max)
        {
            
            return random.Next(min, max); 
        }
        int timeleft = 60; //inicjalna wartosć czasu na rozwiązanie

        Quiz quiz1, quiz2, quiz3, quiz4;

        private void timerQuiz_Tick(object sender, EventArgs e)
        {
            timeleft--;
            lblTimer.Text = string.Format("Pozostały czas: {0} sek.", timeleft);
            lblTimer.ForeColor = Color.Black;

            if (timeleft == 0)
            {
                lblTimer.Text = "Czas minął";
                timerQuiz.Enabled = false;
                btnStart.Text = "START";
                CheckAnswers();
            }
            else if (timeleft <= 15)
                lblTimer.ForeColor = Color.Red;
            else if (timeleft <= 30)
                lblTimer.ForeColor = Color.Yellow;
            else
                lblTimer.ForeColor = Color.Black;
        }

        private void numQ1_Enter(object sender, EventArgs e)
        {
           // numQ1.SelectAll();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            string msg = "Czy na pewno zamknąc aplikację?";
            string title = "Pytanie";
            DialogResult result = MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void CheckAnswers()
        {
            int correctAnswers = 0;
            if (numQ1.Value == quiz1.Result) correctAnswers++;
            if (numQ2.Value == quiz2.Result) correctAnswers++;
            if (numQ3.Value == quiz3.Result) correctAnswers++;
            if (numQ4.Value == quiz4.Result) correctAnswers++;

            MessageBox.Show(string.Format("Liczba poprawnych odpowiedzi:\n{0}/4", correctAnswers));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timerQuiz.Enabled)
            {
                //zakoncz quis
                timerQuiz.Enabled = false;
                btnStart.Text = "START";
                CheckAnswers();
            }
            else
            {
                //uruchom quiz
                SetupQuiz();
                panel1Quiz.Visible = false;
                timerQuiz.Enabled = true;
                btnStart.Text = "STOP";
            }
        }

        private void SetupQuiz()
        {
            numQ1.Controls[0].Enabled = false;
            numQ1.Controls[0].Width = 0;
            numQ1.Controls[0].Visible = false;
            //numQ1.Controls[0].ControlRemoved;

            //zerowanie odpowiedzi i ustawienia min.max w numericUpDowm
            numQ1.Value = 0; numQ1.Minimum = Int32.MinValue; numQ1.Maximum = Int32.MaxValue;
            numQ2.Value = 0; numQ2.Minimum = Int32.MinValue; numQ2.Maximum = Int32.MaxValue;
            numQ3.Value = 0; numQ3.Minimum = Int32.MinValue; numQ3.Maximum = Int32.MaxValue;
            numQ4.Value = 0; numQ4.Minimum = Int32.MinValue; numQ4.Maximum = Int32.MaxValue;

            quiz1 = new Quiz(RandomNumber(-10, -1), RandomNumber(2, 20), "+");
            quiz2 = new Quiz(RandomNumber(-10, -1), RandomNumber(2, 20), "-");
            quiz3 = new Quiz(RandomNumber(-10, -1), RandomNumber(2, 20), "*");
            quiz4 = new Quiz(RandomNumber(-10, -1), RandomNumber(2, 20), "/");
            //MessageBox.Show(q.ToString());
            lblQ1.Text = quiz1.ToString();
            lblQ2.Text = quiz2.ToString();
            lblQ3.Text = quiz3.ToString();
            lblQ4.Text = quiz4.ToString();

            timeleft = 60;
            lblTimer.Text = string.Format("Pozostały czas: {0} sek.", timeleft);
            lblTimer.ForeColor = Color.Black;

            btnStart.Text = "START";
        }
    }
}
