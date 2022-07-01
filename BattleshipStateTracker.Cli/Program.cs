using BattleshipStateTracker;
using BattleshipStateTracker.Cli;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddTransient<IInvoker, Invoker>();
        services.AddSingleton<AppService>();
    })
    .Build();

await host.Services.GetRequiredService<AppService>().ExecuteAsync();
