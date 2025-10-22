
using Spectre.Console.Cli;

namespace Water.Infrastructure;

internal sealed class TypeResolver(IServiceProvider provider) : ITypeResolver {

  /// <summary>
  /// Resolve the service for the given type.
  /// </summary>
  /// <param name="type">The type of object</param>
  /// <returns>IService or null</returns>
  /// <exception cref="InvalidOperationException">Throws if the service could not be found</exception>
  public object Resolve(Type? type) {
    ArgumentNullException.ThrowIfNull(type, "No Type was given");
    var service = provider.GetService(type);
    return service is null ?
      throw new InvalidOperationException(
        $"Service for type '{type}' was not found.") :
        service;
  }
}
