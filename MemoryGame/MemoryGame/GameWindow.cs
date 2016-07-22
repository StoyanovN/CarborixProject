namespace MemoryGame
{
    using MemoryGame.Engines;
    using MemoryGame.Interfaces;
    using Properties;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Diagnostics;
    using UI;

    public partial class GameWindow : Form
    {
        // variables
        //int score = 0;  // our scores
        Random location = new Random(); // selects random value from X and Y lists and assign a new location for each card
        //List<int> X = new List<int>();  // X values of each picturebox
        //List<int> Y = new List<int>();  // Y values of each picturebox
        List<Point> points = new List<Point>();
        //bool again = false; // Property in Game class
        PictureBox pendingImage01; // store first flipped card in a variable
        PictureBox pendingImage02; // store second flipped card in a variable
        private string firstPendingCardName;
        private string secondPendingCardName;

        private IGame game;

        public GameWindow(IGame game)
        {
            InitializeComponent();
            this.game = game;
            //IReader reader = new GUIReader();
            //IWriter writer = new GUIWriter(this);
            //IGameEngine engine = new GameEngine(reader, writer);
            //engine.Run();
        }
        

        public void GameWindowLoad(object sender = null, EventArgs e = null)
        {
            labelCountDown.Text = "5";

            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = false;
                points.Add(picture.Location);
            }

            foreach (PictureBox picture in CardsHolder.Controls)
            {
                int next = location.Next(points.Count);
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


        /// <summary>
        ///close cards
        /// </summary>

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

        /// <summary>
        /// counts time (for 5 seconds) at the beggining of the game, when cards are faced
        /// </summary>
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

        private void Card_Click(object sender, EventArgs e)
        {
            PictureBox currentPicture = (PictureBox)sender;
            string nameCurrentPicture = currentPicture.Name;
            ExecuteClick(nameCurrentPicture);
        }

        

        private void ExecuteClick(string cardCalledClickMethod)
        {
            string cardNumber = GetCardNumber(cardCalledClickMethod);
            string card = "Card" + cardNumber;
            string dublicatedCard = "DupCard" + cardNumber;
            
            PictureBox currentPicture = (PictureBox)this.CardsHolder.Controls[cardCalledClickMethod];
            object O = Resources.ResourceManager.GetObject(card);
            currentPicture.Image = (Image)O;

            PictureBox pictureCard = (PictureBox)this.CardsHolder.Controls[card];
            PictureBox pictureCardDup = (PictureBox)this.CardsHolder.Controls[dublicatedCard];
            
            if (pendingImage01 == null)
            {
                pendingImage01 = currentPicture;
                pendingImage01.Enabled = false;
            }

            else if (pendingImage01 != null && pendingImage02 == null)
            {
                pendingImage02 = currentPicture;
                pendingImage02.Enabled = false;
            }

            if (pendingImage01 != null && pendingImage02 != null)
            {
                if (pendingImage01.Tag == pendingImage02.Tag &&
                    pendingImage01.Name != pendingImage02.Name)
                {
                    pendingImage01 = null;
                    pendingImage02 = null;
                    pictureCard.Enabled = false;
                    pictureCardDup.Enabled = false;
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
                }

                else
                {
                    pendingImage01.Enabled = true;
                    pendingImage02.Enabled = true;
                    timer3.Start();
                }
            }
        }

        private string GetCardNumber(string cardCalledClickMethod)
        {
            string lastTwoDigits = cardCalledClickMethod.Substring(cardCalledClickMethod.Length - 2);
            if (char.IsLetter(lastTwoDigits[0]))
            {
                return lastTwoDigits[1].ToString();
            }

            return lastTwoDigits;
        }
        
        #endregion
        /// <summary>
        /// close cards when they do not match
        /// </summary>
        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            pendingImage01.Image = Properties.Resources.Cover;
            pendingImage02.Image = Properties.Resources.Cover;
            pendingImage01 = null;
            pendingImage02 = null;
        }

        // PlayAgain button
        private void button1_Click(object sender, EventArgs e)
        {
            GameWindowLoad(sender, e);
            label2.Text = Convert.ToString(0);
        }
        private void labelCountDown_Click(object sender, EventArgs e)
        {
        }

        private void CardsHolder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.game.GameStage = Enums.GameStage.Menu;
            this.Close();
        }
    }
}
