
namespace Water.Settings;
internal sealed class Options {
  public DatabaseOptions Database { get; set; } = new DatabaseOptions();

  // SECTION Verbosity Level
  internal enum VerbosityLevel {
    None = 0, Error = 1, Warn = 2,
    Info = 3, Debug = 4, Trace = 5
  };
  private VerbosityLevel _verbosityLevel = VerbosityLevel.Warn;


  /// <summary>
  /// Controls the amount of logging information that is output.  Choices are:
  /// NONE,  0 = No Output ( == Quiet )
  /// ERROR, 1 = Errors only
  /// WARN,  2 = Warns
  /// INFO,  3 = Info (default)
  /// DEBUG, 4 = Debug (detailed)
  /// TRACE, 5 = Trace (very detailed)
  /// </summary>
  public string? Verbosity {
    get {
      return ConvertVerbosity(_verbosityLevel);
    }
    set {
      _verbosityLevel = ConvertVerbosity(value);
    }
  }

  /// <summary>
  ///
  /// </summary>
  /// <param name="verbosity">string representing a verbosity level</param>
  /// <returns>VerbosityLevel enum value</returns>
  private static VerbosityLevel ConvertVerbosity(string? verbosity) {
    ArgumentNullException.ThrowIfNull(verbosity, "No value was given to convert");

    return verbosity.ToUpperInvariant() switch {
      "NONE" => VerbosityLevel.None,
      "QUIET" => VerbosityLevel.None,
      "ERROR" => VerbosityLevel.Error,
      "WARN" => VerbosityLevel.Warn,
      "INFO" => VerbosityLevel.Info,
      "DEBUG" => VerbosityLevel.Debug,
      "TRACE" => VerbosityLevel.Trace,
      _ => throw new ArgumentOutOfRangeException(
        nameof(verbosity), $"{verbosity} is not valid")
    };
  }

  private static string ConvertVerbosity(VerbosityLevel verbosity) {
    return verbosity.ToString().ToUpperInvariant();
  }
  // !SECTION

}
