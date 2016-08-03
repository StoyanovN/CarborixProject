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
    public partial class NameOfTheUserWindowsForm : Form
    {
        private IGame game;
        Random rnd = new Random();
        public NameOfTheUserWindowsForm(IGame game)
        {
            this.game = game;
            
            InitializeComponent();
        }

        private void txtBoxPlayerName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int points = rnd.Next(100, 10000);
            string playerName = txtBoxPlayerName.Text;
            PlayerScore.PlayerScore player = new PlayerScore.PlayerScore(playerName, points);
            player.ReceivePlayer(player);
            this.game.GameStage = Enums.GameStage.Game;
            this.Close();
        }

        
    }
}
