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
                picture.Image = Properties.Resources.Cover;
            }
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

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
