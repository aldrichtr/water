
namespace Water.Util;

internal static class ConfigUtils {
public static string GetDefaultConfigPath() {
    var baseDir = Environment.GetEnvironmentVariable("APPDATA")
               ?? Environment.GetEnvironmentVariable("USERPROFILE")
               ?? string.Empty;

    var configDir = Path.Combine(baseDir, "water");
    var configFile = "config.json";

    return Path.Combine(configDir, configFile);
  }


public static string GetDefaultDatabasePath() {
    var baseDir = Environment.GetEnvironmentVariable("LOCALAPPDATA")
               ?? Environment.GetEnvironmentVariable("USERPROFILE")
               ?? string.Empty;

    var configDir = Path.Combine(baseDir, "water");
    var configFile = "water.db";

    return Path.Combine(configDir, configFile);
  }
}
