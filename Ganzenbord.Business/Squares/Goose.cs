using Ganzenbord.Business.Loggers;
using Ganzenbord.Business.Players;

namespace Ganzenbord.Business.Squares
{
    public class Goose : ISquare
    {
        public int Id { get; set; }

        private ILogger _logger;

        public Goose(int id, ILogger logger)
        {
            Id = id;
            _logger = logger;
        }

        public void HandlePlayer(IPlayer player)
        {
            string direction = player.IsMovingBack ? "backwards" : "forward"; // Shorthand for if else

            _logger.Log($"{player.Name} hit a goose and is moving {player.DiceRoll.Sum()} {direction}!");

            if (player.IsMovingBack)
            {
                int[] negative = player.DiceRoll.Select(x => -x).ToArray();
                player.Move(negative);
            }
            else
            {
                player.Move(player.DiceRoll);
            }

            player.IsMovingBack = false;
        }
    }
}