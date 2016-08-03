namespace MemoryGame.Interfaces
{
    public interface IWriter
    {
        void DrowGameWindow(IGame game);

        void DrowMenuWindow(IGame game);

        void DrowHighScoreWindow(IGame game);

        void DrowNameWindow(IGame game);
    }
}
