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
            player.MoveToPosition(0);
        }
    }
}