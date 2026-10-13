using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberforme
{
    public partial class Form1 : Form
    {
        private int secret;                    // new: the hidden number
        private Random rnd = new Random();     // new: makes random numbers
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbMin.TickStyle = TickStyle.Both;
            tbMax.TickStyle = TickStyle.Both;
            tbGuess.TickStyle = TickStyle.Both;

            SetStartState();
        }
        // new: the whole method below
        private void SetStartState()
        {
            numMax.Enabled = true;
            btnStart.Enabled = true;

            // sliders back to the neutral look: all at the left, ticks only at the ends
            foreach (TrackBar tb in new[] { tbMin, tbMax, tbGuess })
            {
                tb.TickStyle = TickStyle.Both;
                tb.Minimum = 1;
           
                tb.Value = 1;
                tb.TickFrequency = 100;
                tb.Enabled = false;
            }

            // the square boxes are empty until the game starts
            lblMin.Text = "";
            lblMax.Text = "";
            lblGuess.Text = "";

            btnGuess.Enabled = false;
            lblMessage.Text = "";
            lblMessage.BackColor = SystemColors.Control;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int max = (int)numMax.Value;
            secret = rnd.Next(1, max + 1);     // hidden number from 1 to max

            // all three sliders now cover the range 1..max
            tbMin.Minimum = 1; tbMin.Maximum = max; tbMin.Value = 1;
            tbMax.Minimum = 1; tbMax.Maximum = max; tbMax.Value = max;
            tbGuess.Minimum = 1; tbGuess.Maximum = max; tbGuess.Value = 1;

            lblMin.Text = "1";
            lblMax.Text = max.ToString();
            lblGuess.Text = "1";

            // lock the setup controls, unlock the playing controls
            numMax.Enabled = false;
            btnStart.Enabled = false;
            tbGuess.Enabled = true;
            btnGuess.Enabled = true;
        }

        private void tbGuess_Scroll(object sender, EventArgs e)
        {
            lblGuess.Text = tbGuess.Value.ToString();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int guess = tbGuess.Value;

            if (guess == secret)
            {
                // correct guess
                lblMessage.Text = "Atspėjote!";
                lblMessage.BackColor = Color.Green;

                btnGuess.Enabled = false;
                tbGuess.Enabled = false;
                numMax.Enabled = true;       // allow a new round
                btnStart.Enabled = true;
            }
            else if (guess < secret)
            {
                // the secret number is higher: raise the lower limit
                lblMessage.Text = "Skaičius yra didesnis!";
                lblMessage.BackColor = Color.Red;

                tbMin.Value = guess;
                lblMin.Text = guess.ToString();
            }
            else
            {
                // the secret number is lower: lower the upper limit
                lblMessage.Text = "Skaičius yra mažesnis!";
                lblMessage.BackColor = Color.Red;

                tbMax.Value = guess;
                lblMax.Text = guess.ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // put the sliders and boxes back to the starting values
            tbMin.Value = tbMin.Minimum;
            tbMax.Value = tbMax.Maximum;
            tbGuess.Value = tbGuess.Minimum;

            lblMin.Text = tbMin.Value.ToString();
            lblMax.Text = tbMax.Value.ToString();
            lblGuess.Text = tbGuess.Value.ToString();

            SetStartState();    // reuse the "back to the beginning" method from Step 7
        }
    }
}
