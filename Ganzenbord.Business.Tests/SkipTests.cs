using Ganzenbord.Business.Players;

namespace Ganzenbord.Business.Tests
{
    internal class SkipTests
    {
        [Test]
        public void WhenPlayerHasToSkipTurn_ThenTheyCannotMove()
        {
            //Arrange
            IPlayer player = new Player();
            player.Position = 16;
            player.DiceRoll = new int[] { 1, 2 };

            //Act
            player.Move(player.DiceRoll);

            //Assert
            Assert.That(player.Position, Is.EqualTo(19));
            Assert.That(player.TurnsToSkip, Is.EqualTo(1));

            player.Move(player.DiceRoll);
            Assert.That(player.Position, Is.EqualTo(19));
            Assert.That(player.TurnsToSkip, Is.EqualTo(0));

            player.Move(player.DiceRoll);
            Assert.That(player.Position, Is.EqualTo(22));
            Assert.That(player.TurnsToSkip, Is.EqualTo(0));
        }
    }
}