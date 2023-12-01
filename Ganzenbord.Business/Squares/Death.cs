using Ganzenbord.Business.Loggers;
using Ganzenbord.Business.Players;

namespace Ganzenbord.Business.Squares
{
    public class Death : ISquare
    {
        public int Id { get; set; }

        private ILogger _logger;

        public Death(int id, ILogger logger)
        {
            Id = id;
            _logger = logger;
        }

        public void HandlePlayer(IPlayer player)
        {
            _logger.Log($"Oh no! {player.Name} has died and been reset to square 0");
            player.MoveToPosition(0);
        }
    }
}