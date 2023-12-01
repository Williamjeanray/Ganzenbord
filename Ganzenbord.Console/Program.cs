using Ganzenbord.Business;
using Ganzenbord.Business.Loggers;

ILogger logger = new ConsoleLogger();
Game game = new Game(logger);

game.StartGame();