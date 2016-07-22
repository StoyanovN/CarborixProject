namespace MemoryGame.Engines
{
    using Interfaces;
    using Models;
    using System.Windows.Forms;
    public class GameEngine : IGameEngine
    {
        private const int NumberOfCards = 24;
        private readonly IReader reader;
        private readonly IWriter writer;
        private Card[] cards;

        public GameEngine(IReader reader, IWriter writer, IGame game)
        {
            this.reader = reader;
            this.writer = writer;
            this.cards = new Card[NumberOfCards];
            this.Game = game;
        }

        public IGame Game { get; set; }

        public void Run()
        {
            while (Game.GameStage!=Enums.GameStage.End)
            {
                switch (Game.GameStage)
                {
                    case Enums.GameStage.Menu:
                        this.RunMenu();
                        break;
                    case Enums.GameStage.Game:
                        this.RunGame();
                        break;
                    case Enums.GameStage.End:
                        break;
                    default:
                        break;
                }
            }
            //this.writer.DrowGameWindow();
        }

        private void RunMenu()
        {
            this.writer.DrowMenuWindow(this.Game);
        }

        private void RunGame()
        {
            this.writer.DrowGameWindow(this.Game);
        } 
        
    }
}
