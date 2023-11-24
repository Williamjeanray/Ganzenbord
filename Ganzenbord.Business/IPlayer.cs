namespace Ganzenbord.Business
{
    public interface IPlayer
    {
        int Position { get; set; }
        int DiceRoll { get; set; }

        void Move(int diceRoll);

        void MoveToPosition(int v);

        void SkipTurn(int skipT);
    }
}