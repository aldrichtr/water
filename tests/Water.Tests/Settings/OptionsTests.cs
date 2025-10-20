
using System.Reflection;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Water.Settings;

namespace Water.Tests.Settings;

[TestClass]
public class OptionsTests {

  [TestMethod]
  public void default_verbosity_value_is_warn() {
    var options = new Options();
    Assert.AreEqual("WARN", options.Verbosity);
  }

  [TestMethod]
  public void update_verbosity_level() {
    var level = "ERROR";
    var options = new Options();

    options.Verbosity = level;
    var new_value = options.Verbosity;
    Assert.AreEqual(level, new_value, $"Did not update the level to {level}");
  }
}
