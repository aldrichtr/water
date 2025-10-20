
using System;
using System.IO;

using LiteGraph;
using LiteGraph.GraphRepositories.Sqlite;

using Water.Settings;
using Water.Domain.Persistence;

namespace Water.Infrastructure.Persistence;
#pragma warning disable CA1812
// TODO: This pragma is only in place until the class is used by the program
internal sealed class GraphService(DatabaseOptions options) : IGraphService {

  public DatabaseOptions Options = options;

  public LiteGraphClient Initialize() {
    var repo = new SqliteGraphRepository(Options.Path, Options.InMemory);
    var client = new LiteGraphClient(
      repo,
      Options.Logging,
      Options.Caching,
      Options.Storage);
    return client;
  }
  public bool DatabaseExists() {
    return Path.Exists(Options.Path);
  }
}
#pragma warning restore CA1812
