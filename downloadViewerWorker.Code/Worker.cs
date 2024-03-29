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
        ConfigLoader cl = new ConfigLoader("./config.json");
        ConfigImportTester cit = new ConfigImportTester(cl);
        if (cl.error){
            _logger.LogError(cl.errorMsg);
        }

        Viewer v = new Viewer(cl.GetDownloadFolder());

        _logger.LogInformation(v.getFolder());
        _logger.LogInformation(v.countFiles().ToString());

        if (v.countFiles() > 0) 
        { 
            foreach (FileInfo file in v.fileInfo)
            {
                _logger.LogInformation(file.ToString());
            }
        }

        _logger.LogInformation(cit.showConfig());

        /*
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            await Task.Delay(1000, stoppingToken);
        }
        */
    }
}
