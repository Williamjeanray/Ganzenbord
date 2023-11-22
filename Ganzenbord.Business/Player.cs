using Ganzenbord.Business.Squares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Business
{
    public class Player : IPlayer
    {
        public int Position { get ; set ; }
        public int DiceRoll { get ; set ; }

        public void Move(int diceRoll)
        {
            int destination = Position + diceRoll;
            MoveToPosition(destination);
        }

        public void MoveToPosition(int destination)
        {
            Position = destination;
            ISquare destinationSquare = GameBoard.GetSquare(destination);
            destinationSquare.HandlePlayer(this);
        }
    }
}
