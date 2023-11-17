using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Business.Squares
{
    internal class StandardSquare : ISquare
    {
        public int Id { get ; set ; }

        public StandardSquare(int id)
        {
            Id = id;
        }

        public void HandlePlayer(IPlayer player)
        {
          
        }
    }
}
