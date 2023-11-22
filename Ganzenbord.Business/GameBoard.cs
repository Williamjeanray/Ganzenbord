using Ganzenbord.Business.Factory;
using Ganzenbord.Business.Squares;
using System.Collections.Generic;

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
                else if (i == 42)
                {
                    square = _factory.Create(i, SquareType.Maze);

                }
                //Aanvullen
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