namespace BattleshipStateTracker.Cli;

public class AppService
{
    private const string instructions =
        @"   COMMANDS:
      NEW  = setup a new game
      EXIT = end the application";

    private readonly IInvoker _invoker;

    public AppService(IInvoker invoker)
    {
        _invoker = invoker;
    }

    public async Task ExecuteAsync(CancellationToken cancellationToken = default)
    {
        Console.WriteLine(instructions);

        while (true)
        {
            Console.Write("=> ");
            var input = Console.ReadLine();
            if (input?.ToLower() == "exit")
            {
                break;
            }

            Console.WriteLine(_invoker.ExecuteCommand(input));
        }
    }
}
