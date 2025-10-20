
using Spectre.Console.Cli;

namespace Water.Cli.Settings;
#pragma warning disable CA1812
// TODO: this pragma is temporary until the class is used in the program
internal sealed class BaseSettings : CommandSettings {

  [CommandOption("-f|--database-file")]
  public string? Path { get; set; }


  [CommandOption("--version")]
  public bool? Version { get; set; }
}

#pragma warning restore CA1812
