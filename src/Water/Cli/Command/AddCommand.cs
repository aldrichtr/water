
using Spectre.Console.Cli;
using Water.Cli.Settings;

namespace Water.Cli.Command;

#pragma warning disable CA1812
// TODO: this pragma is temporary until the class is used in the program
internal sealed class AddCommand : Command<AddSettings> {
  public override int Execute(CommandContext context, AddSettings settings) {
    return 0;
  }
}
#pragma warning restore CA1812
