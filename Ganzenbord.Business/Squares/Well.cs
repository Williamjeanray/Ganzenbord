namespace Ganzenbord.Business.Squares
{
    internal class Well : ISquare
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Well(int id)
        {
            Id = id;
        }
        public void HandlePlayer(IPlayer player)
        {
            throw new NotImplementedException();
        }
    }
}