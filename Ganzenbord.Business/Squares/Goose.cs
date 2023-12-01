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
                int[] negative = player.DiceRoll.Select(x => -x).ToArray();
                player.Move(negative);
            }
            else
            {
                player.Move(player.DiceRoll);
            }

            player.IsMovingBack = false;
        }
    }
}