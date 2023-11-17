using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Business.Squares
{
    public interface ISquare
    {
        int Id { get; set; }
        void HandlePlayer(IPlayer player);

    }
}
