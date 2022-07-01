namespace BattleshipStateTracker;

public class Board
{
    private readonly IBoardState _boardState;

    public Board(IBoardState boardState) => _boardState = boardState;

    public Player OwnedBy { get; set; }
}