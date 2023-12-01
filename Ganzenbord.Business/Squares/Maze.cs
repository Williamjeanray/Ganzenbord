using Ganzenbord.Business.Loggers;
using Ganzenbord.Business.Players;

namespace Ganzenbord.Business.Squares
{
    public class Maze : ISquare
    {
        public int Id { get; set; }

        private ILogger _logger;

        public Maze(int id, ILogger logger)
        {
            Id = id;
            _logger = logger;
        }

        public void HandlePlayer(IPlayer player)
        {
            _logger.Log($"{player.Name} has gotten lost in the maze and moved back to square 39");
            player.MoveToPosition(39);
        }
    }
}