
using System.ServiceModel.Syndication;

namespace Water.Domain.Entities;

using ItemType = KeyValuePair<string, string>;
#pragma warning disable CA1812
// TODO: This pragma is only until the class is used by the program

/// <summary>
/// A generic item representing a unit of work, for example Task, Project, Goal, etc.
/// </summary>
internal sealed class WorkItem {

  public required string Title {
    get; set;
  }
  public required Guid Id { get; set; }

  public required Workspace Workspace { get; set; }
  public ItemType? Type { get; set; }

  /// <summary>
  /// A collection of custom properties that are user defined.
  /// </summary>
  public Dictionary<object, object>? CustomProperties { get; set; }
  public List<object>? Tags { get; set; }
  public List<object>? Labels { get; set; }
}

#pragma warning restore CA1812
