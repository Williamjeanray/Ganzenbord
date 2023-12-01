using Ganzenbord.Business.Loggers;
using Ganzenbord.Business.Players;

namespace Ganzenbord.Business.Squares
{
    internal class Well : ISquare
    {
        public int Id { get; set; }

        private ILogger _logger;

        public Well(int id, ILogger logger)
        {
            Id = id;
            _logger = logger;
        }

        public void HandlePlayer(IPlayer player)
        {
            _logger.Log("Wooops. This has not been implemented yet. Bye bye!");
            throw new NotImplementedException();
        }
    }
}