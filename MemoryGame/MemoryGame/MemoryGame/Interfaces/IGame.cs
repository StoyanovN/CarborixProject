namespace MemoryGame.Interfaces
{
    using MemoryGame.Enums;

    /// <summary>
    /// Responsible for holding games properties
    /// </summary>
    public interface IGame
    {
        GameStage GameStage { get; set; }
    }
}
