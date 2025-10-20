
using System.Globalization;

namespace Water.Domain.Entities;

#pragma warning disable CA1812
// TODO: This pragma is only until the class is used by the program
internal sealed class Workspace {

  public Guid Id { get; set; }
  public required string Name { get; set; }
  public string? Description { get; set; }
}
#pragma warning restore CA1812
