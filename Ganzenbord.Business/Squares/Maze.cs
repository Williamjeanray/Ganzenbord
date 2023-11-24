namespace Ganzenbord.Business.Squares
{
    public class Maze : ISquare
    {
        public int Id { get; set; }

        public Maze(int id)
        {
            Id = id;
        }

        public void HandlePlayer(IPlayer player)
        {
            player.MoveToPosition(39);
        }
    }
}