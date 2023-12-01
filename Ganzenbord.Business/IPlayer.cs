namespace Ganzenbord.Business
{
    public interface IPlayer
    {
        int [] DiceRoll { get; set; }
        bool IsMovingBack { get; set; }
        bool IsWinner { get; set; }
        string Name { get; set; }
        int Position { get; set; }
        int TurnsToSkip { get; set; }

        void Move(int[] diceRoll);
        void MoveToPosition(int destination);
        void RollTheDice();
        void SkipTurn(int skipT);
    }
}