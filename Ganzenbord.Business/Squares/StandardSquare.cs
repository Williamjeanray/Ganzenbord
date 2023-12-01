using Ganzenbord.Business.Loggers;
using Ganzenbord.Business.Players;

namespace Ganzenbord.Business.Squares
{
    internal class StandardSquare : ISquare
    {
        public int Id { get; set; }

        private ILogger _logger;

        public StandardSquare(int id, ILogger logger)
        {
            Id = id;
            _logger = logger;
        }

        public void HandlePlayer(IPlayer player)
        {
            _logger.Log($"{player.Name} has landed on an empty square and is now on position: {player.Position}");
        }
    }
}