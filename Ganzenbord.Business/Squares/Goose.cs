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
            if (player.IsMovingBack)
            {
                int reverse = -player.DiceRoll;
                player.Move(reverse);
            }
            else
            {
                player.Move(player.DiceRoll);
            }

            player.IsMovingBack = false;
        }
    }
}