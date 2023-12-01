using Ganzenbord.Business.Loggers;
using Ganzenbord.Business.Players;

namespace Ganzenbord.Business.Squares
{
    public class Bridge : ISquare
    {
        private ILogger _logger;

        public int Id { get; set; }

        public Bridge(int id, ILogger logger)
        {
            Id = id;
            _logger = logger;
        }

        public void HandlePlayer(IPlayer player)
        {
            player.MoveToPosition(12);
            _logger.Log($"{player.Name} hit the bridge and moved to position 12");
        }
    }
}