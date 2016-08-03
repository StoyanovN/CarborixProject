using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MemoryGame.Interfaces;

namespace MemoryGame
{
    public partial class HighScoreForm : Form
    {
        private IGame game;
        public HighScoreForm(IGame game)
        {
            this.game = game;
            InitializeComponent();
        }

        private void HighScoreForm_Load(object sender, EventArgs e)
        {
            var image = new Bitmap(this.pictureBoxHighScore.Width, this.pictureBoxHighScore.Height);
            var font = new Font("Mistral", 38, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphic = Graphics.FromImage(image);
            graphic.DrawString(PrintScores().ToUpper(), font, Brushes.Black, new PointF(0, 0));
            this.pictureBoxHighScore.Image = image;
            this.game.GameStage = Enums.GameStage.HighScore;
           // this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.game.GameStage = Enums.GameStage.Menu;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private string PrintScores()
        {
            PlayerScore.PlayerScore plScore = new PlayerScore.PlayerScore();
            plScore.ReadScore();
            return plScore.GiveScores();
        }

    }
}
