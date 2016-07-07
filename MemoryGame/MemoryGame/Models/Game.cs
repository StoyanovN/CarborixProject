namespace MemoryGame.Models
{
    using Interfaces;

    public class Game : IGame
    {
        private const int NumberOfCards = 24;

        public Game()
        {
            this.PlayAgain = false;
            this.CountDown = 5;
            this.Cards = new Card[NumberOfCards];
        }

        public bool PlayAgain { get; set; }

        public int CountDown { get; set; }

        public Card[] Cards { get; set; }
    }
}
