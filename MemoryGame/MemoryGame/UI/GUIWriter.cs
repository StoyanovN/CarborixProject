namespace MemoryGame.UI
{
    using MemoryGame.Interfaces;
    using MemoryGame.Properties;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;


    public class GUIWriter : IWriter
    {
        private readonly GameWindow gameWindow;
        private readonly Random location;

        public GUIWriter(GameWindow gameWindow)
        {
            this.gameWindow = gameWindow;
            this.location = new Random();
        }
        public List<Point> points = new List<Point>();
        
        public void DrowGameWindow()
        {
            this.gameWindow.GameWindowLoad();
            this.ShowGame();
        }

        private void ShowGame()
        {
            this.gameWindow.ShowDialog();
        }
    }
}
