
using LiteGraph;
using Water.Util;

namespace Water.Settings;


internal sealed class DatabaseOptions() {

  public string Path {
    get; set;
  } = ConfigUtils.GetDefaultDatabasePath();
  public bool InMemory { get; set; } = true;
  public LoggingSettings? Logging{ get; set; } = new LoggingSettings();
  public StorageSettings? Storage{ get; set; } = new StorageSettings();
  public CachingSettings? Caching{ get; set; } = new CachingSettings();

}
