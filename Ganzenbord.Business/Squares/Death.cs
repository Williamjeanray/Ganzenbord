namespace Ganzenbord.Business.Squares
{
    public class Death : ISquare
    {
        public int Id { get; set; }

        public Death(int id)
        {
            Id = id;
        }

        public void HandlePlayer(IPlayer player)
        {
            player.MoveToPosition(0);
        }
    }
}