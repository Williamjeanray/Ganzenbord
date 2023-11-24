using Ganzenbord.Business.Squares;

namespace Ganzenbord.Business.Factory
{
    public interface IFactory
    {
        ISquare Create(int Id, SquareType squaretype);
    }
}