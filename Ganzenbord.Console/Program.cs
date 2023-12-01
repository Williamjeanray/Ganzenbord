using Ganzenbord.Business;

ILogger logger = new ConsoleLogger();
Game game = new Game(logger);

game.StartGame();