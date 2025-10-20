
using Water.Domain.Entities;

namespace Water.Presentation;

#pragma warning disable CA1812
// TODO: This pragma is only until the class is used by the program
internal sealed class ConsoleRenderer : IRenderer {

  /// <summary>
  /// Output the list of WorkItems to the console.
  /// </summary>
  /// <param name="list">This is the list of WorkItems</param>
  public void RenderList(IEnumerable<WorkItem> list) {
    // TODO: This is where we write the list to the console
  }

  /// <summary>
  /// Output messages to the console when an operation fails.
  /// </summary>
  /// <param name="message">The error message</param>
  public void RenderError(string message) {
    // TODO: Decorate the message and output to the Console
  }

  /// <summary>
  /// Output messages to the console when an operation succeeds.
  /// </summary>
  /// <param name="message">The success message</param>
  public void RenderSuccess(string message) {
    // TODO: Decorate the message and output to the Console
  }
}

#pragma warning restore CA1812
