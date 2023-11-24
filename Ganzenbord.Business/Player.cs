using Ganzenbord.Business.Squares;

namespace Ganzenbord.Business
{
    public class Player : IPlayer
    {
        public int Position { get; set; }
        public int DiceRoll { get; set; }

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

        public void SkipTurn(int skipT)
        {
            throw new NotImplementedException();
            //moet nog gemaakt worden
        }
    }
}