using Ganzenbord.Business.Squares;
using System.Numerics;

namespace Ganzenbord.Business
{
    public class Player : IPlayer
    {
        public int Position { get; set; }
        public int[] DiceRoll { get; set; }
        public bool IsMovingBack { get; set; }
        public int TurnsToSkip { get; set; } = 0;
        public string Name { get; set; }
        public bool IsWinner { get; set; }


        public void Move(int[] diceRoll)
        {
            if (!diceRoll.Any(x => x < 0))
            {
                DiceRoll = diceRoll;
            }

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
                    int overschot = (destination - lastSquare);
                    destination = lastSquare - overschot;
                    IsMovingBack = true;
                }

                MoveToPosition(destination);
            }
        }

        public void MoveToPosition(int destination)
        {
            Position = destination;
            GameBoard board = GameBoard.GetSingleTonInstance();
            ISquare destinationSquare = board.GetSquare(destination);
            destinationSquare.HandlePlayer(this);
        }

        public void RollTheDice()
        {
            Dice myDice = new Dice();
            int[] result = myDice.RollTheDices();
            Move(result);
        }

        public void SkipTurn(int skipT)
        {
            TurnsToSkip = skipT;
        }
    }
}