namespace Ganzenbord.Business.Squares
{
    public class Maze : ISquare
    {
        public int Id { get; set; }

        private ILogger _logger;

        public Maze(int id, ILogger logger)
        {
            Id = id;
            _logger = logger;
        }

        public void HandlePlayer(IPlayer player)
        {
            player.MoveToPosition(39);
        }
    }
}