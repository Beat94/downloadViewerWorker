using Microsoft.Extensions.Logging;
using ViewerNamespace;

namespace downloadViewerWorker;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        Viewer v = new Viewer("E:/daten/Downloads");

        _logger.LogInformation(v.getFolder());
        /*
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            await Task.Delay(1000, stoppingToken);
        }
        */
    }
}
