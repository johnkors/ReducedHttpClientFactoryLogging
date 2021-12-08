using With;
using Microsoft.Extensions.DependencyInjection;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureLogging((c, b) =>
    {
        b.AddSimpleConsole(o => { o.SingleLine = true; });
    })
    .ConfigureServices(services =>
    {
        services.AddHttpClient();
        services.UseMinimalHttpLogger();
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();



