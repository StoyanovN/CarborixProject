namespace MemoryGame.UI
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    public class GUIWriter : IWriter
    {
        //private readonly GameWindow gameWindow;
        //private readonly Form formWindow;
        private readonly Random location;

        //public GUIWriter(GameWindow gameWindow)
        //{
        //    this.gameWindow = gameWindow;
        //    this.location = new Random();
        //}

        public GUIWriter()
        {
            //this.formWindow = formWindow;
            this.location = new Random();
        }
        public List<Point> points = new List<Point>();
        
        public void DrowGameWindow(IGame game)
        {
            var gameWindow = new GameWindow(game);
            gameWindow.GameWindowLoad();
            gameWindow.ShowDialog();
        }
        
        public void DrowMenuWindow(IGame game)
        {
            var menu = new frmMenu(game);
            menu.ShowDialog();
        }

        public void DrowHighScoreWindow(IGame game)
        {
            var highScore = new HighScoreForm(game);
            highScore.ShowDialog();
            
        }

        public void DrowNameWindow(IGame game)
        {
            var name = new NameOfTheUserWindowsForm(game);
            name.ShowDialog();
        }
    }
}
