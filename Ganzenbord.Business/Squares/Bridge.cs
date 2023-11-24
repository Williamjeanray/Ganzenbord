namespace Ganzenbord.Business.Squares
{
    public class Bridge : ISquare
    {
        public int Id { get; set; }

        public Bridge(int id)
        {
            Id = id;
        }

        public void HandlePlayer(IPlayer player)
        {
            player.MoveToPosition(12);
        }
    }
}