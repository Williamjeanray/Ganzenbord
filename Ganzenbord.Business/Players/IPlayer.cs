namespace Ganzenbord.Business.Players
{
    public interface IPlayer
    {
        int[] DiceRoll { get; set; }
        bool IsMovingBack { get; set; }
        bool IsWinner { get; set; }
        string Name { get; set; }
        int Position { get; set; }
        int TurnsToSkip { get; set; }

        void Move(int[] diceRoll, bool isFirstTurn = false);

        void MoveToPosition(int destination);

        void RollTheDice(bool isFirstTurn);

        void SkipTurn(int skipT);
    }
}