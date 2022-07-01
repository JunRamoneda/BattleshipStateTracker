namespace BattleshipStateTracker;

public class Game
{
    private readonly IGameState _gameState;

    public Game(IGameState gameState) => _gameState = gameState;

    public Player Player1 { get; set; }

    public Player Player2 { get; set; }
}