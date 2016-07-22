namespace MemoryGame.Models
{
    using Enums;
    using Interfaces;

    public class Game : IGame
    {
        private const int NumberOfCards = 24;
        private const int TimeBeforTurning = 5;

        public Game()
        {
            this.PlayAgain = false;
            this.CountDown = TimeBeforTurning;
            this.Cards = new Card[NumberOfCards];
            this.GameStage = GameStage.Menu;
        }

        public GameStage GameStage { get; set; }

        public bool PlayAgain { get; set; }

        public int CountDown { get; set; }

        public Card[] Cards { get; set; }
    }
}
