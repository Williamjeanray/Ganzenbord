using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Business.Squares
{
    public class End : ISquare
    {
        public int Id { get; set; }

        public End(int id)
        {
            Id = id;
        }

        public void HandlePlayer(IPlayer player)
        {
            player.MoveToPosition(0);
            //Nog een vraag naar restart toevoegen
        }
    }
}
