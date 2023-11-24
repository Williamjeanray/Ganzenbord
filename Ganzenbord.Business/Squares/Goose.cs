namespace Ganzenbord.Business.Squares
{
    public class Goose : ISquare
    {
        public int Id { get; set; }

        public Goose(int id)
        {
            Id = id;
        }

        public void HandlePlayer(IPlayer player)
        {
            player.Move(player.DiceRoll);
        }
    }
}