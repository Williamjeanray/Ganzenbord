using Ganzenbord.Business.Factory;
using Ganzenbord.Business.Squares;

namespace Ganzenbord.Business
{
    public static class GameBoard
    {
        //dependency, altijd boven de klasse
        private static IFactory _factory = new SquareFactory();

        private static List<ISquare> squares = FillsSquares();

        private static List<ISquare> FillsSquares()
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
                //31 moet nog gemaakt worden dit is "Well"
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
                //ToDo Well & Goose
                else
                {
                    square = _factory.Create(i, SquareType.Standard);
                }
                mylist.Add(square);
            }
            return mylist;
        }

        public static ISquare GetSquare(int id)
        {
            return squares[id];
        }
    }
}