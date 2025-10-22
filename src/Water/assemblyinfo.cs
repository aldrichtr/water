
using System;
using System.Reflection;
using System.Globalization;

/*
  Do not add the following value to the project file or this will be overwritten!
  <GeneratedAssemblyInfoFile>assemblyinfo.cs</GeneratedAssemblyInfoFile>
*/

internal static class AssemblyInfo {

  private static string GetAttribute<T>(Func<T, string> value) where T : Attribute {
    return Attribute.GetCustomAttribute(
      Assembly.GetExecutingAssembly(),
      typeof(T)) is T attribute ? value.Invoke(attribute)
      : string.Empty;
  }
  public static string Company {
    get {
      return GetAttribute<AssemblyCompanyAttribute>(a => a.Company);
    }
  }
  public static string Product {
    get {
      return GetAttribute<AssemblyProductAttribute>(a => a.Product);
    }
  }
  public static string Copyright {
    get {
      return GetAttribute<AssemblyCopyrightAttribute>(a => a.Copyright);
    }
  }
  public static string Trademark {
    get {
      return GetAttribute<AssemblyTrademarkAttribute>(a => a.Trademark);
    }
  }
  public static string Title {
    get {
      return GetAttribute<AssemblyTitleAttribute>(a => a.Title);
    }
  }
  public static string Description {
    get {
      return GetAttribute<AssemblyDescriptionAttribute>(a => a.Description);
    }
  }
  public static string Configuration {
    get {
      return GetAttribute<AssemblyConfigurationAttribute>(a => a.Configuration);
    }
  }
  public static string FileVersion {
    get {
      return GetAttribute<AssemblyFileVersionAttribute>(a => a.Version);
    }
  }

  public static Version Version {
    get {
      var version = Assembly.GetExecutingAssembly().GetName().Version;
      return version ?? new Version(0, 0, 0, 0);
    }
  }
  public static string VersionFull {
    get {
      return Version.ToString();
    }
  }
  public static string VersionMajor {
    get {
      return Version.Major.ToString(CultureInfo.InvariantCulture);
    }
  }
  public static string VersionMinor {
    get {
      return Version.Minor.ToString(CultureInfo.InvariantCulture);
    }
  }
  public static string VersionBuild {
    get {
      return Version.Build.ToString(CultureInfo.InvariantCulture);
    }
  }
  public static string VersionRevision {
    get {
      return Version.Revision.ToString(CultureInfo.InvariantCulture);
    }
  }
}
