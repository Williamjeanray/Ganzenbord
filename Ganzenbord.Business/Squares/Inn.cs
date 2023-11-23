using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Business.Squares
{
    public class Inn : ISquare
    {
        public int Id { get; set; }

        public Inn(int id)
        {
            Id = id;
        }

        public void HandlePlayer(IPlayer player)
        {
            player.SkipTurn(1);
        }
    }
}
