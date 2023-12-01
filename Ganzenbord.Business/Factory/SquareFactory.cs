using Ganzenbord.Business.Squares;

namespace Ganzenbord.Business.Factory
{
    public class SquareFactory : IFactory
    {
        private ILogger _logger;

        public SquareFactory(ILogger logger)
        {
            _logger = logger;
        }

        public ISquare Create(int id, SquareType squaretype)
        {
            switch (squaretype)
            {
                case SquareType.Bridge:
                    return new Bridge(id, _logger);

                case SquareType.Maze:
                    return new Maze(id, _logger);

                case SquareType.Death:
                    return new Death(id, _logger);

                case SquareType.Inn:
                    return new Inn(id, _logger);

                case SquareType.Prison:
                    return new Prison(id, _logger);

                case SquareType.Goose:
                    return new Goose(id, _logger);

                case SquareType.Well:
                    return new Well(id, _logger);

                case SquareType.End:
                    return new End(id, _logger);

                default:
                    return new StandardSquare(id, _logger);
            }
        }
    }
}