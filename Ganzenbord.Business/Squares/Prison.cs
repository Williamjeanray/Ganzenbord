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
            _logger.Log($"{player.Name} has committed tax fraud with a smile and has to spend 3 turns in prison.");
            player.SkipTurn(3);
        }
    }
}