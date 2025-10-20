
using LiteGraph;

namespace Water.Domain.Persistence;

internal interface IGraphService {

  public LiteGraphClient Initialize();

  public bool DatabaseExists();
}
