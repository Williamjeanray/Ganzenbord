using Ganzenbord.Business.Factory;
using Ganzenbord.Business.Squares;

namespace Ganzenbord.Business
{
    public  class GameBoard
    {
        //dependency, altijd boven de klasse
        private  IFactory _factory = new SquareFactory();

        private List<ISquare> squares;

        private  int[] gooseIds = { 5, 9, 14, 18, 23, 27, 32, 36, 41, 45, 50, 54, 59 };

        public static GameBoard GetSingleTonInstance()
        {
            if (singleTonInstance == null) 
            {
                singleTonInstance = new GameBoard();
            }
            return singleTonInstance;
        }

        //singleTon stap 2 refer naar zichzelf
        private static GameBoard singleTonInstance;

        //singleTon stap 1 private constructor
        private GameBoard()
        {
            squares = FillsSquares();
        }

        private  List<ISquare> FillsSquares()
        {
            var mylist = new List<ISquare>();
            for (int i = 0; i < 64; i++)
            {
                ISquare square;

                if (i == 6)
                {
                    square = _factory.Create(i, SquareType.Bridge);
                }
                else if (i == 19)
                {
                    square = _factory.Create(i, SquareType.Inn);
                }
                else if (i == 42)
                {
                    square = _factory.Create(i, SquareType.Maze);
                }
                else if (i == 52)
                {
                    square = _factory.Create(i, SquareType.Prison);
                }
                else if (i == 58)
                {
                    square = _factory.Create(i, SquareType.Death);
                }
                else if (i == 63)
                {
                    square = _factory.Create(i, SquareType.End);
                }
                else if (gooseIds.Contains(i))
                {
                    square = _factory.Create(i, SquareType.Goose);
                }
                else
                {
                    square = _factory.Create(i, SquareType.Standard);
                }
                mylist.Add(square);
            }
            return mylist;
        }

        public  ISquare GetSquare(int id)
        {
            return squares[id];
        }

        public int GetEndPosition()
        {
            return squares.Count -1;
        }
    }
}