using System.Management.Automation;

Console.WriteLine("Hello, World!");
await RunSleep();

static async Task RunSleep()
{
    using PowerShell ps = PowerShell.Create();

    ps.AddScript("Start-Sleep 1000; Write-Host 'Done';");


    var pipelineObjects = await ps.InvokeAsync().ConfigureAwait(false);

    foreach (PSObject obj in pipelineObjects)
    {
        Console.WriteLine(obj);
    }
}