using Ganzenbord.Business.Squares;

namespace Ganzenbord.Business.Factory
{
    public class SquareFactory : IFactory
    {
        public ISquare Create(int id, SquareType squaretype)
        {
            switch (squaretype)
            {
                case SquareType.Bridge:
                    return new Bridge(id);
                case SquareType.Maze:
                    return new Maze(id);
                case SquareType.Death:
                    return new Death(id);
                    //Rest aanmaken (huiswerk)
                default: 
                    return new StandardSquare(id);
            }
        }
    }
}