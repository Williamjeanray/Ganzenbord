using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Business
{
    public interface IPlayer
    {
        int Position { get; set; }
        int DiceRoll { get; set; }

        void Move(int diceRoll);
        void MoveToPosition(int v);
    }
}
