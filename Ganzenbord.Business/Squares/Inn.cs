using Ganzenbord.Business.Loggers;
using Ganzenbord.Business.Players;

namespace Ganzenbord.Business.Squares
{
    public class Inn : ISquare
    {
        public int Id { get; set; }

        private ILogger _logger;

        public Inn(int id, ILogger logger)
        {
            Id = id;
            _logger = logger;
        }

        public void HandlePlayer(IPlayer player)
        {
            _logger.Log($"{player.Name} has reached the inn and is spending 1 turn to rest up.");
            player.SkipTurn(1);
        }
    }
}