namespace MemoryGame
{
    using Engines;
    using Interfaces;
    using UI;
    using System;
    using System.Windows.Forms;

    public static class Program
    {
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
