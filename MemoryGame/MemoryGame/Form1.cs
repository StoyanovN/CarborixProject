using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class GameWindow : Form
    {
        // variables
        int score = 0;  // our scores
        Random Location = new Random(); // selects random value from X and Y lists and assign a new location for each card
        List<int> X = new List<int>();  // X values of each picturebox
        List<int> Y = new List<int>();  // Y values of each picturebox
        bool again = false; // play again or no

        public GameWindow()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = false;
            }
            timer1.Start();
            timerCountDown.Start();
            Card1.Image = Properties.Resources.Card1;
            DupCard1.Image = Properties.Resources.Card1;
            Card2.Image = Properties.Resources.Card2;
            DupCard2.Image = Properties.Resources.Card2;
            Card3.Image = Properties.Resources.Card3;
            DupCard3.Image = Properties.Resources.Card3;
            Card4.Image = Properties.Resources.Card4;
            DupCard4.Image = Properties.Resources.Card4;
            Card5.Image = Properties.Resources.Card5;
            DupCard5.Image = Properties.Resources.Card5;
            Card6.Image = Properties.Resources.Card6;
            DupCard6.Image = Properties.Resources.Card6;
            Card7.Image = Properties.Resources.Card7;
            DupCard7.Image = Properties.Resources.Card7;
            Card8.Image = Properties.Resources.Card8;
            DupCard8.Image = Properties.Resources.Card8;
            Card9.Image = Properties.Resources.Card9;
            DupCard9.Image = Properties.Resources.Card9;
            Card10.Image = Properties.Resources.Card10;
            DupCard10.Image = Properties.Resources.Card10;
            Card11.Image = Properties.Resources.Card11;
            DupCard11.Image = Properties.Resources.Card11;
            Card12.Image = Properties.Resources.Card12;
            DupCard12.Image = Properties.Resources.Card12;



        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CardsHolder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.Cover;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void timerCountDown_Tick(object sender, EventArgs e)
        {

            int timer = int.Parse(labelCountDown.Text);
            timer = timer - 1;
            labelCountDown.Text = timer.ToString();
            if (timer == 0)
            {
                timerCountDown.Stop();
            }
        }
        #region Cards
        private void Card1_Click(object sender, EventArgs e)
        {
            Card1.Image = Properties.Resources.Card1;
        }

        private void DupCard1_Click(object sender, EventArgs e)
        {
            DupCard1.Image = Properties.Resources.Card1;
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            Card2.Image = Properties.Resources.Card2;
        }

        private void DupCard2_Click(object sender, EventArgs e)
        {
            DupCard2.Image = Properties.Resources.Card2;
        }

        private void Card3_Click(object sender, EventArgs e)
        {
            Card3.Image = Properties.Resources.Card3;
        }

        private void DupCard3_Click(object sender, EventArgs e)
        {
            DupCard3.Image = Properties.Resources.Card3;
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            Card4.Image = Properties.Resources.Card4;
        }

        private void DupCard4_Click(object sender, EventArgs e)
        {
            DupCard4.Image = Properties.Resources.Card4;
        }
        private void Card5_Click(object sender, EventArgs e)
        {
            Card5.Image = Properties.Resources.Card5;
        }

        private void DupCard5_Click(object sender, EventArgs e)
        {
            DupCard5.Image = Properties.Resources.Card5;
        }
        private void Card6_Click(object sender, EventArgs e)
        {
            Card6.Image = Properties.Resources.Card6;
        }

        private void DupCard6_Click(object sender, EventArgs e)
        {
            DupCard6.Image = Properties.Resources.Card6;
        }
        private void Card7_Click(object sender, EventArgs e)
        {
            Card7.Image = Properties.Resources.Card7;
        }

        private void DupCard7_Click(object sender, EventArgs e)
        {
            DupCard7.Image = Properties.Resources.Card7;
        }
        private void Card8_Click(object sender, EventArgs e)
        {
            Card8.Image = Properties.Resources.Card8;
        }

        private void DupCard8_Click(object sender, EventArgs e)
        {
            DupCard8.Image = Properties.Resources.Card8;
        }
        private void Card9_Click(object sender, EventArgs e)
        {
            Card9.Image = Properties.Resources.Card9;
        }

        private void DupCard9_Click(object sender, EventArgs e)
        {
            DupCard9.Image = Properties.Resources.Card9;
        }
        private void Card10_Click(object sender, EventArgs e)
        {
            Card10.Image = Properties.Resources.Card10;
        }

        private void DupCard10_Click(object sender, EventArgs e)
        {
            DupCard10.Image = Properties.Resources.Card10;
        }
        private void Card11_Click(object sender, EventArgs e)
        {
            Card11.Image = Properties.Resources.Card11;
        }

        private void DupCard11_Click(object sender, EventArgs e)
        {
            DupCard11.Image = Properties.Resources.Card11;
        }
        private void Card12_Click(object sender, EventArgs e)
        {
            Card12.Image = Properties.Resources.Card12;
        }

        private void DupCard12_Click(object sender, EventArgs e)
        {
            DupCard12.Image = Properties.Resources.Card12;
        }
        #endregion
    }
}
