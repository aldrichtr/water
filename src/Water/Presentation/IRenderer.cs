
using Water.Domain.Entities;

namespace Water.Presentation;

internal interface IRenderer {

  /// <summary>
  /// Output the list of WorkItems to the rendering mechanism.
  /// </summary>
  /// <param name="list">This is the list of WorkItems</param>
  public void RenderList(IEnumerable<WorkItem> list);

  /// <summary>
  /// Display the success message to the rendering mechanism
  /// </summary>
  /// <param name="message">The undecorated message string</param>
  public void RenderSuccess(string message);

  /// <summary>
  /// Display the error message to the rendering mechanism
  /// </summary>
  /// <param name="message">The undecorated message string</param>
  public void RenderError(string message);
}
