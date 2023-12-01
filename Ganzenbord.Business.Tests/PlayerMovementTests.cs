using Ganzenbord.Business.Players;

namespace Ganzenbord.Business.Tests
{
    internal class PlayerMovementTests
    {
        [Test]
        public void WhenPlayerLandsOnGoose_ThenPlayerMovesDiceRollAgain()
        {
            //Arrange

            IPlayer player = new Player();
            player.Position = 7;
            int[] dice = { 1, 1 };

            //Act
            player.Move(dice);

            //Assert
            Assert.That(player.Position, Is.EqualTo(11));
        }

        [Test]
        public void WhenPlayerRollsDice_ThenPlayerMoves()
        {
            //Arrange

            IPlayer player = new Player();
            player.Position = 1;
            int[] dice = { 1, 1 };

            //Act
            player.Move(dice);

            //Assert
            Assert.That(player.Position, Is.EqualTo(3));
        }

        [Test]
        public void WhenPlayerLandsOnBridge_ThenPlayerMovesTo12()
        {
            //Arrange

            IPlayer player = new Player();
            player.Position = 4;
            int[] dice = { 1, 1 };

            //Act
            player.Move(dice);

            //Assert
            Assert.That(player.Position, Is.EqualTo(12));
        }

        [Test]
        public void WhenPlayerOverschootsEndzoneWalkBackAmountOfExtraMovement()
        {
            //Arrange

            IPlayer player = new Player();
            player.Position = 61;
            int[] dice = { 3, 2 };

            //Act
            player.Move(dice);

            //Assert
            Assert.That(player.Position, Is.EqualTo(60));
        }
    }
}