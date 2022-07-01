namespace BattleshipStateTracker;

public class Invoker : IInvoker
{
    public string ExecuteCommand(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return "Please enter a valid command";
        }

        var command = Parser.Parse(input);

        return command is not null ? command.Execute() : string.Empty;
    }
}
