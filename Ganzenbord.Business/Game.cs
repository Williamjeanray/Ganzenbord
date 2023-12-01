using Ganzenbord.Business.Loggers;
using Ganzenbord.Business.Players;

namespace Ganzenbord.Business
{
    public class Game
    {
        private ILogger logger;

        public Game(ILogger logger)
        {
            this.logger = logger;
        }

        private int round = 1;
        public int Round { get { return round; } }

        private List<IPlayer> Players { get; set; } = new List<IPlayer>();

        public void StartGame(int amountOfPlayers = 2)
        {
            logger.Log($"Game starting with {amountOfPlayers} player(s)!");
            CreatePlayers(amountOfPlayers);

            while (!Players.Any(x => x.IsWinner == true))
            {
                PlayRound(Players);
            }

            EndGame();
        }

        private void EndGame()
        {
            logger.Log("Game Over! Press enter to quit.");
            Console.ReadLine();
        }

        private void PlayRound(List<IPlayer> players)
        {
            logger.Log($"Round {Round} starting.");
            bool isFirstThrow = Round == 1;

            foreach (IPlayer player in players)
            {
                player.RollTheDice(isFirstThrow);
            }

            Console.ReadLine();
            EndTurn();
        }

        private void CreatePlayers(int amountOfPlayers)
        {
            for (int i = 1; i <= amountOfPlayers; i++)
            {
                Players.Add(new Player
                {
                    Name = $"Player {i}",
                });
            }
        }

        private void EndTurn()
        {
            round++;
        }
    }
}