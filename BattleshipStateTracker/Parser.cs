using BattleshipStateTracker.Commands;

namespace BattleshipStateTracker;

public static class Parser
{
    public static ICommand Parse(string input)
    {
        var commands = new Dictionary<string, Func<ICommand>>
        {
            { "new", () => new NewGameCommand() }
        };

        var raw = input.ToLower().Split();
        if (commands.ContainsKey(raw[0]))
        {
            return commands[raw[0]].Invoke();
        }

        return null;
    }
}