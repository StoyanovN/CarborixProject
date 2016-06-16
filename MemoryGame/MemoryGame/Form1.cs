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
                                        //List<int> X = new List<int>();  // X values of each picturebox
                                        //List<int> Y = new List<int>();  // Y values of each picturebox
        List<Point> points = new List<Point>();
        bool again = false; // play again or no
        PictureBox pendingImage01; // store first flipped card in a variable
        PictureBox pendingImage02; // store second flipped card in a variable

        public GameWindow()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            labelCountDown.Text = "5";
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = false;
                points.Add(picture.Location);
            }

            foreach (PictureBox picture in CardsHolder.Controls)
            {
                int next = Location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);

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
            if (pendingImage01 == null)
            {
                pendingImage01 = Card1;
            }
            else if(pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = Card1;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card1.Enabled = false;
                    DupCard1.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
           }
        }

        private void DupCard1_Click(object sender, EventArgs e)
        {
            DupCard1.Image = Properties.Resources.Card1;
            if (pendingImage01 == null)
            {
                pendingImage01 = DupCard1;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = DupCard1;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card1.Enabled = false;
                    DupCard1.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            Card2.Image = Properties.Resources.Card2;
            if (pendingImage01 == null)
            {
                pendingImage01 = Card2;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = Card2;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card2.Enabled = false;
                    DupCard2.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DupCard2_Click(object sender, EventArgs e)
        {
            DupCard2.Image = Properties.Resources.Card2;
            if (pendingImage01 == null)
            {
                pendingImage01 = DupCard2;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = DupCard2;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card2.Enabled = false;
                    DupCard2.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card3_Click(object sender, EventArgs e)
        {
            Card3.Image = Properties.Resources.Card3;
            if (pendingImage01 == null)
            {
                pendingImage01 = Card3;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = Card3;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card3.Enabled = false;
                    DupCard3.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DupCard3_Click(object sender, EventArgs e)
        {
            DupCard3.Image = Properties.Resources.Card3;
            if (pendingImage01 == null)
            {
                pendingImage01 = DupCard3;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = DupCard3;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card3.Enabled = false;
                    DupCard3.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            Card4.Image = Properties.Resources.Card4;
            if (pendingImage01 == null)
            {
                pendingImage01 = Card4;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = Card4;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card4.Enabled = false;
                    DupCard4.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DupCard4_Click(object sender, EventArgs e)
        {
            DupCard4.Image = Properties.Resources.Card4;
            if (pendingImage01 == null)
            {
                pendingImage01 = DupCard4;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = DupCard4;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card4.Enabled = false;
                    DupCard4.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }
        private void Card5_Click(object sender, EventArgs e)
        {
            Card5.Image = Properties.Resources.Card5;
            if (pendingImage01 == null)
            {
                pendingImage01 = Card5;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = Card5;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card5.Enabled = false;
                    DupCard5.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DupCard5_Click(object sender, EventArgs e)
        {
            DupCard5.Image = Properties.Resources.Card5;
            if (pendingImage01 == null)
            {
                pendingImage01 = DupCard5;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = DupCard5;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card5.Enabled = false;
                    DupCard5.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }
        private void Card6_Click(object sender, EventArgs e)
        {
            Card6.Image = Properties.Resources.Card6;
            if (pendingImage01 == null)
            {
                pendingImage01 = Card6;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = Card6;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card6.Enabled = false;
                    DupCard6.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DupCard6_Click(object sender, EventArgs e)
        {
            DupCard6.Image = Properties.Resources.Card6;
            if (pendingImage01 == null)
            {
                pendingImage01 = DupCard6;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = DupCard6;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card6.Enabled = false;
                    DupCard6.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }
        private void Card7_Click(object sender, EventArgs e)
        {
            Card7.Image = Properties.Resources.Card7;
            if (pendingImage01 == null)
            {
                pendingImage01 = Card7;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = Card7;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card7.Enabled = false;
                    DupCard7.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DupCard7_Click(object sender, EventArgs e)
        {
            DupCard7.Image = Properties.Resources.Card7;
            if (pendingImage01 == null)
            {
                pendingImage01 = DupCard7;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = DupCard7;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card7.Enabled = false;
                    DupCard7.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }
        private void Card8_Click(object sender, EventArgs e)
        {
            Card8.Image = Properties.Resources.Card8;
            if (pendingImage01 == null)
            {
                pendingImage01 = Card8;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = Card8;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card8.Enabled = false;
                    DupCard8.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DupCard8_Click(object sender, EventArgs e)
        {
            DupCard8.Image = Properties.Resources.Card8;
            if (pendingImage01 == null)
            {
                pendingImage01 = DupCard8;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = DupCard8;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card8.Enabled = false;
                    DupCard8.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }
        private void Card9_Click(object sender, EventArgs e)
        {
            Card9.Image = Properties.Resources.Card9;
            if (pendingImage01 == null)
            {
                pendingImage01 = Card9;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = Card9;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card9.Enabled = false;
                    DupCard9.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DupCard9_Click(object sender, EventArgs e)
        {
            DupCard9.Image = Properties.Resources.Card9;
            if (pendingImage01 == null)
            {
                pendingImage01 = DupCard9;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = DupCard9;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card9.Enabled = false;
                    DupCard9.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }
        private void Card10_Click(object sender, EventArgs e)
        {
            Card10.Image = Properties.Resources.Card10;
            if (pendingImage01 == null)
            {
                pendingImage01 = Card10;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = Card10;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card10.Enabled = false;
                    DupCard10.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DupCard10_Click(object sender, EventArgs e)
        {
            DupCard10.Image = Properties.Resources.Card10;
            if (pendingImage01 == null)
            {
                pendingImage01 = DupCard10;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = DupCard10;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card10.Enabled = false;
                    DupCard10.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }
        private void Card11_Click(object sender, EventArgs e)
        {
            Card11.Image = Properties.Resources.Card11;
            if (pendingImage01 == null)
            {
                pendingImage01 = Card11;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = Card11;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card11.Enabled = false;
                    DupCard11.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DupCard11_Click(object sender, EventArgs e)
        {
            DupCard11.Image = Properties.Resources.Card11;
            if (pendingImage01 == null)
            {
                pendingImage01 = DupCard11;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = DupCard11;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card11.Enabled = false;
                    DupCard11.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }
        private void Card12_Click(object sender, EventArgs e)
        {
            Card12.Image = Properties.Resources.Card12;
            if (pendingImage01 == null)
            {
                pendingImage01 = Card12;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = Card12;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card12.Enabled = false;
                    DupCard12.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DupCard12_Click(object sender, EventArgs e)
        {
            DupCard12.Image = Properties.Resources.Card12;
            if (pendingImage01 == null)
            {
                pendingImage01 = DupCard12;
            }
            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = DupCard12;
            }
            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    Card12.Enabled = false;
                    DupCard12.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        #endregion

        private void timer3_Tick(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - 10);
            timer3.Stop();
            pendingImage01.Image = Properties.Resources.Cover;
            pendingImage02.Image = Properties.Resources.Cover;
            pendingImage01 = null;
            pendingImage02 = null;
        }

        // PlayAgain button
        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
            label2.Text = Convert.ToString(0);
        }
    }
}
