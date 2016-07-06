using MemoryGame.Engines;
using MemoryGame.Interfaces;
using MemoryGame.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GameWindow());
            GameWindow playGround = new GameWindow();
            IWriter writer = new GUIWriter(playGround);
            IReader reader = new GUIReader();
            IGameEngine gameEngine = new GameEngine(reader, writer);
            gameEngine.Run();

        }
    }
}
