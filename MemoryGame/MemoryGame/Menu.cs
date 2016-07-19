//using MemoryGame.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using MemoryGame.Engines;
//using MemoryGame.UI;

namespace MemoryGame
{

    using Engines;
    using Interfaces;
    using UI;
    using System;
    using System.Windows.Forms;
    public partial class frmMenu : Form
    {

        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GameWindow playGround = new GameWindow();
            IWriter writer = new GUIWriter(playGround);
            IReader reader = new GUIReader();
            IGameEngine gameEngine = new GameEngine(reader, writer);
            gameEngine.Run();
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
