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
            /*Application.Run(new GameWindow());
            */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
            
        }
    }
}
