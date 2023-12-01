using Ganzenbord.Business.Loggers;
using Ganzenbord.Business.Players;

namespace Ganzenbord.Business.Tests
{
    internal class DiceRollTests
    {
        [Test]
        public void TrowTest()
        {
            //Arrange
            Dice die = new Dice();

            //Act
            int[] result = die.RollTheDices();

            //Assert
            Assert.That(result[0], Is.LessThanOrEqualTo(6));
            Assert.That(result[1], Is.LessThanOrEqualTo(6));
        }

        [Test]
        public void WhenSumOfDiceRollIs9_OnFirstTurn_With5And4_ThenPlayerShouldMoveTo26()
        {
            //Arrange
            Player player1 = new Player();
            player1.Position = 0;
            int[] dice = { 5, 4 };
            Game game = new Game(new ConsoleLogger());

            //Act
            player1.Move(dice, true);

            //Assert
            Assert.That(dice.Sum, Is.EqualTo(9));
            Assert.That(player1.Position, Is.EqualTo(26));
        }

        [Test]
        public void WhenSumOfDiceRollIs9_OnFirstTurn_With6And3_ThenPlayerShouldMoveTo53()
        {
            //Arrange
            Player player1 = new Player();
            player1.Position = 0;
            int[] dice = { 6, 3 };
            Game game = new Game(new ConsoleLogger());

            //Act
            player1.Move(dice, true);

            //Assert
            Assert.That(dice.Sum, Is.EqualTo(9));
            Assert.That(player1.Position, Is.EqualTo(53));
        }
    }
}