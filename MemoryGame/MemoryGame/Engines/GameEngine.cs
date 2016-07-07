namespace MemoryGame.Engines
{
    using Interfaces;
    using Models;

    public class GameEngine : IGameEngine
    {
        private const int NumberOfCards = 24;
        private readonly IReader reader;
        private readonly IWriter writer;
        private Card[] cards;

        public GameEngine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
            this.cards = new Card[NumberOfCards];
        }

        public void Run()
        {
            IGame game = new Game();
            this.writer.DrowGameWindow();
        }
    }
}
