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
            player.DiceRoll = 2;

            //Act
            player.Move(player.DiceRoll);

            //Assert
            Assert.AreEqual(11, player.Position);
        }

        [Test]
        public void WhenPlayerRollsDice_ThenPlayerMoves()
        {
            //Arrange

            IPlayer player = new Player();
            player.Position = 1;
            player.DiceRoll = 2;

            //Act
            player.Move(player.DiceRoll);

            //Assert
            Assert.That(player.Position, Is.EqualTo(3));
        }

        [Test]
        public void WhenPlayerLandsOnBridge_ThenPlayerMovesTo12()
        {
            //Arrange

            IPlayer player = new Player();
            player.Position = 4;
            player.DiceRoll = 2;

            //Act
            player.Move(player.DiceRoll);

            //Assert
            Assert.That(player.Position, Is.EqualTo(12));
        }
        [Test]
        public void WhenPlayerOverschootsEndzoneWalkBackAmountOfExtraMovement()
        {
            //Arrange

            IPlayer player = new Player();
            player.Position = 61;
            player.DiceRoll = 5;

            //Act
            player.Move(player.DiceRoll);

            //Assert
            Assert.That(player.Position, Is.EqualTo(60));
        }
    }
}