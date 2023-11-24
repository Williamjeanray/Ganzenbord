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

    }
}