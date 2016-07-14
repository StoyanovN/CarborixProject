namespace MemoryGame.Models
{
    using Interfaces.CardsInterfaces;

    public class Card : ICard
    {
        public Card()
        {
            this.CardBackImage = "Cover";
        }
        /// <summary>
        /// goes to PictureBox.Tag
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// goes to PictireBox.Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// goes to PictireBox.location
        /// </summary>
        public int LocationX { get; set; }
        public int LocationY { get; set; }

        /// <summary>
        /// goes to PictireBox.Size
        /// </summary>
        public int CardWidth { get; set; }
        public int CardHeigth { get; set; }

        public string CardFrontImage { get; set; }
        public string CardBackImage { get; set; }

        //this.DupCard1.TabIndex = 26;
        //this.DupCard1.TabStop = false;
        //this.DupCard1.Click += new System.EventHandler(this.DupCard1_Click);

        /// <summary>
        /// if true the face is visible
        /// </summary>
        public bool IsVisible { get; set; }
    }
}
