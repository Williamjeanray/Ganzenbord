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
                case SquareType.Inn:
                    return new Inn(id);

                case SquareType.Prison:
                    return new Prison(id);

                case SquareType.End:
                    return new End(id);
                //Well nog toevoegen (kan enkel met een 2de speler gebruikt worden)
                default:
                    return new StandardSquare(id);
            }
        }
    }
}