using Ganzenbord.Business.Squares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Business.Factory
{
    public interface IFactory
    {
        ISquare Create(int Id, SquareType squaretype);
    }
}
