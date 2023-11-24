using Ganzenbord.Business.Squares;

namespace Ganzenbord.Business
{
    public class Player : IPlayer
    {
        public int Position { get; set; }
        public int DiceRoll { get; set; }
        public bool IsMovingBack { get; set; }

        public void Move(int diceRoll)
        {
            GameBoard board = GameBoard.GetSingleTonInstance();
            int lastSquare = board.GetEndPosition();
            int destination = Position + diceRoll;


            if (destination > lastSquare)
            {
                int overschot = (destination - lastSquare);
                destination = lastSquare - overschot;
                IsMovingBack = true;
     
            }
                MoveToPosition(destination);
        }

        public void MoveToPosition(int destination)
        {
            Position = destination;
            GameBoard board = GameBoard.GetSingleTonInstance();
            ISquare destinationSquare = board.GetSquare(destination);
            destinationSquare.HandlePlayer(this);
        }

        public void SkipTurn(int skipT)
        {
            throw new NotImplementedException();
            //moet nog gemaakt worden
        }
    }
}