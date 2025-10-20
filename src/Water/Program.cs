using Microsoft.Extensions.DependencyInjection;

using Spectre.Console.Cli;
using Water;
using Water.Presentation;
using Water.Infrastructure;
using Water.Domain.Persistence;

var app = new App(args);

var registrations = new ServiceCollection();
registrations.AddScoped<IGraphService>();
registrations.AddScoped<IRenderer, ConsoleRenderer>();
var registrar = new TypeRegistrar(registrations);
