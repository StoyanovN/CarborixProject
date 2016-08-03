namespace MemoryGame
{
    using Engines;
    using Interfaces;
    using UI;
    using System;
    using System.Windows.Forms;
    using Models;
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            /*Application.Run(new GameWindow());
            */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IGame game = new Game();
            IWriter writer = new GUIWriter();
            IReader reader = new GUIReader();
            IGameEngine gameEngine = new GameEngine(reader, writer, game);
            gameEngine.Run();


            //frmMenu menu = new frmMenu();
            //menu.ShowDialog();
            
        }
    }
}
