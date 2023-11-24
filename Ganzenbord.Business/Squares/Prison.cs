﻿namespace Ganzenbord.Business.Squares
{
    public class Prison : ISquare
    {
        public int Id { get; set; }

        public Prison(int id)
        {
            Id = id;
        }

        public void HandlePlayer(IPlayer player)
        {
            player.SkipTurn(3);
        }
    }
}