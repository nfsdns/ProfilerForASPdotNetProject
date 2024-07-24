using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyNewProject.Web;


public class BackgroundJobHostedService : IHostedService, IDisposable
{
    private readonly BackgroundJobProcessor _jobProcessor;
    private Timer _timer;

    public BackgroundJobHostedService()
    {
        _jobProcessor = new BackgroundJobProcessor();
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromMinutes(1));

        return Task.CompletedTask;
    }

    private void DoWork(object state)
    {
        _jobProcessor.ProcessJob();
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _timer?.Change(Timeout.Infinite, 0);

        return Task.CompletedTask;
    }

    public void Dispose()
    {
        _timer?.Dispose();
    }
}

