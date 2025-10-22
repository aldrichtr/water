
using Spectre.Console.Cli;

namespace Water.Cli.Settings;

#pragma warning disable CA1812
// TODO: This pragma is only until the class is used by the program
internal sealed class AddSettings : CommandSettings {

  [CommandArgument(0, "<Title>")]
  public required string Title { get; set; }

  [CommandOption("-t|--tags <tag>[,tag]")]
  public string[]? Tags { get; set; }
}
#pragma warning restore CA1812
