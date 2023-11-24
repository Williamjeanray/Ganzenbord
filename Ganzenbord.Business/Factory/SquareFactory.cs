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
                
                case SquareType.Inn:
                    return new Inn(id);

                case SquareType.Prison:
                    return new Prison(id);

                case SquareType.Goose:
                    return new Goose(id);
                
                case SquareType.Well:
                    return new Well(id);

                case SquareType.End:
                    return new End(id);
                
                default:
                    return new StandardSquare(id);
            }
        }
    }
}