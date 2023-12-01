using Ganzenbord.Business.Loggers;
using Ganzenbord.Business.Players;

namespace Ganzenbord.Business.Squares
{
    public class Prison : ISquare
    {
        public int Id { get; set; }

        private ILogger _logger;

        public Prison(int id, ILogger logger)
        {
            Id = id;
            _logger = logger;
        }

        public void HandlePlayer(IPlayer player)
        {
            player.SkipTurn(3);
        }
    }
}