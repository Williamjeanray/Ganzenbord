using Ganzenbord.Business.Loggers;
using Ganzenbord.Business.Squares;

namespace Ganzenbord.Business.Players
{
    public class Player : IPlayer
    {
        public int Position { get; set; }
        public int[] DiceRoll { get; set; }
        public bool IsMovingBack { get; set; }
        public int TurnsToSkip { get; set; } = 0;
        public string Name { get; set; }
        public bool IsWinner { get; set; }

        private ILogger logger;

        public Player(ILogger logger = null)
        {
            if (logger == null)
            {
                // Dirty fix for unit testing
                this.logger = new ConsoleLogger();
            }
            else
            {
                this.logger = logger;
            }
        }

        public void Move(int[] diceRoll, bool isFirstTurn)
        {
            if (!diceRoll.Any(x => x < 0))
            {
                DiceRoll = diceRoll;
            }

            if (isFirstTurn && diceRoll.Sum() == 9)
            {
                HandleFirstTurnException(diceRoll);
            }
            else
            {
                if (TurnsToSkip > 0)
                {
                    TurnsToSkip--;
                }
                else
                {
                    GameBoard board = GameBoard.GetSingleTonInstance();
                    int lastSquare = board.GetEndPosition();
                    int destination = Position + diceRoll.Sum();

                    if (destination > lastSquare)
                    {
                        int overschot = destination - lastSquare;
                        destination = lastSquare - overschot;
                        IsMovingBack = true;
                    }

                    MoveToPosition(destination);
                }
            }
        }

        private void HandleFirstTurnException(int[] diceRoll)
        {
            logger.Log($"Woops. Can't win that easy {Name}! After rolling a 9, you will be moved to a special square instead of winning! ");
            if (diceRoll.Contains(5) && diceRoll.Contains(4))
            {
                MoveToPosition(26);
            }
            else if (diceRoll.Contains(6) && diceRoll.Contains(3))
            {
                MoveToPosition(53);
            }
        }

        public void MoveToPosition(int destination)
        {
            Position = destination;
            GameBoard board = GameBoard.GetSingleTonInstance();
            ISquare destinationSquare = board.GetSquare(destination);
            destinationSquare.HandlePlayer(this);
        }

        public void RollTheDice(bool isFirstTurn)
        {
            Dice myDice = new Dice();
            int[] result = myDice.RollTheDices();

            logger.Log($"{Name} has rolled {result.Sum()} and is on the move from position {Position}!");

            Move(result, isFirstTurn);
        }

        public void SkipTurn(int skipT)
        {
            logger.Log($"{Name} has to skip a turn and remains on position {Position}. {TurnsToSkip} of turns left to wait!");
            TurnsToSkip = skipT;
        }
    }
}