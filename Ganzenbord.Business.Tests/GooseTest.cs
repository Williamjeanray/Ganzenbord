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
            int[] dice = { 1, 1};

            //Act
            player.Move(dice);

            //Assert
            Assert.That(player.Position, Is.EqualTo(7));
        }
        [Test]
        public void WhenSquareIsGooseThenRepeatMovementMultipleGoose()
        {
            //Arrange
            IPlayer player = new Player();
            player.Position = 1;
            int[] dice = { 2, 2 };

            //Act
            player.Move(dice);

            //Assert
            Assert.That(player.Position, Is.EqualTo(13));
        }

        [Test]
        public void WhenPlayerIsMovingBackwards_AndLandsOnGoose_ThenGooseSendsPlayerBack()
        {
            //Arrange
            IPlayer player = new Player();
            player.Position = 61;
            int[] dice = { 3, 3 };

            //Act
            player.Move(dice);

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
            int[] dice = { 2, 3 };

            //Act
            player.Move(dice);

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
            int[] dice = { 2, 3 };

            //Act
            player.Move(dice);

            //Assert
            Assert.That(player.Position, Is.EqualTo(49));

            // Now move player forward again after hitting a streak of bad luck.
            dice[0] = 1;
            dice[1] = 1;
            player.Move(dice);
            Assert.That(player.Position, Is.EqualTo(51));
            Assert.False(player.IsMovingBack);
        }
    }
}