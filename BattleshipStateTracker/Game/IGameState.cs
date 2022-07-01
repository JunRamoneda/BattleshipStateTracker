namespace BattleshipStateTracker;

public interface IGameState
{
    GameStatus Status => GameStatus.New;
}