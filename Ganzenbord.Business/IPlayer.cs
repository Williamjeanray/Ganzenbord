namespace Ganzenbord.Business
{
    public interface IPlayer
    {
        int [] DiceRoll { get; set; }
        bool IsMovingBack { get; set; }
        string Name { get; set; }
        int Position { get; set; }
        int Round { get; }
        int TurnsToSkip { get; set; }

        void Move(int[] diceRoll);
        void MoveToPosition(int destination);
        void SkipTurn(int skipT);
    }
}