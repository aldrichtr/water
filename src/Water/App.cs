
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

using Water.Settings;
using Water.Util;

namespace Water;
internal sealed class App(string[] args) {

  // SECTION Defaults
  const string DefaultPrefix = "WATER_";
  private static readonly string DefaultPath = ConfigUtils.GetDefaultConfigPath();
  // !SECTION

  private readonly HostApplicationBuilder _builder = Host.CreateApplicationBuilder(args);

  public void Configure(Options? options, string? path) {
    options ??= new Options();
    path ??= DefaultPath;

    _builder.Configuration.Sources.Clear();
    _builder.Configuration.AddEnvironmentVariables(prefix: DefaultPrefix);
    _builder.Configuration.AddJsonFile(path, optional: true, reloadOnChange: true);
    _builder.Configuration.Bind(options);
  }

  public Task Run() {
// TODO: This function should build and run, but i don't know how to do that yet

    var options = new Options();
    Console.WriteLine($"The database file is {options.Database.Path}");
    var IHost  = _builder.Build();
    return Task.CompletedTask;
  }
}
