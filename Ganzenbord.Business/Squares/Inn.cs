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
            player.SkipTurn(1);
        }
    }
}