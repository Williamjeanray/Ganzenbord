namespace Ganzenbord.Business.Squares
{
    public interface ISquare
    {
        int Id { get; set; }

        void HandlePlayer(IPlayer player);
    }
}