namespace Ganzenbord.Business.Squares
{
    public class End : ISquare
    {
        public int Id { get; set; }

        private ILogger _logger;

        public End(int id, ILogger logger)
        {
            Id = id;
            _logger = logger;
        }

        public void HandlePlayer(IPlayer player)
        {
            player.IsWinner = true;
            _logger.Log($"{player.Name} has won!!!");
        }
    }
}