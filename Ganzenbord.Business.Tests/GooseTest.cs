namespace Ganzenbord.Business.Tests
{
    public class GooseTest
    {
        [Test]
        public void WhenSquareIsGooseThenRepeatMovement()
        {
            //Arrange
            IPlayer player = new Player();
            player.Position = 3;
            player.DiceRoll = 2;

            //Act
            player.Move(player.DiceRoll);

            //Assert
            Assert.That(player.Position, Is.EqualTo(7));
        }
        [Test]
        public void WhenSquareIsGooseThenRepeatMovementMultipleGoose()
        {
            //Arrange
            IPlayer player = new Player();
            player.Position = 1;
            player.DiceRoll = 4;

            //Act
            player.Move(player.DiceRoll);

            //Assert
            Assert.That(player.Position, Is.EqualTo(13));
        }

        [Test]
        public void WhenPlayerIsMovingBackwards_AndLandsOnGoose_ThenGooseSendsPlayerBack()
        {
            //Arrange
            IPlayer player = new Player();
            player.Position = 61;
            player.DiceRoll = 6;

            //Act
            player.Move(player.DiceRoll);

            //Assert
            Assert.That(player.Position, Is.EqualTo(53));
            Assert.False(player.IsMovingBack);
        }

        [Test]
        public void WhenPlayerIsMovingBackwards_AndLandsOnGoose_ThenGooseSendsPlayerBackAsLongAsGeeseAreHit()
        {
            //Arrange
            IPlayer player = new Player();
            player.Position = 62;
            player.DiceRoll = 5;

            //Act
            player.Move(player.DiceRoll);

            //Assert
            Assert.That(player.Position, Is.EqualTo(49));
            Assert.False(player.IsMovingBack);
        }

        [Test]
        public void WhenPlayerIsMovingBackwards_AndLandsOnGoose_ThenGooseSendsPlayerBackAsLongAsGeeseAreHit_AndNextThrowMovesForward()
        {
            //Arrange
            IPlayer player = new Player();
            player.Position = 62;
            player.DiceRoll = 5;

            //Act
            player.Move(player.DiceRoll);

            //Assert
            Assert.That(player.Position, Is.EqualTo(49));

            // Now move player forward again after hitting a streak of bad luck.
            player.DiceRoll = 2;
            player.Move(player.DiceRoll);
            Assert.That(player.Position, Is.EqualTo(51));
            Assert.False(player.IsMovingBack);
        }
    }
}