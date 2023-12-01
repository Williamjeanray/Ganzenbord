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
        public void WhenDiceRollIs9_AndOneDiceIsFive_AndIsFirstTurn()
        {
            //Arrange
            Player player1 = new Player();
            player1.Position = 0;
            int[] dice = { 5, 4 };
            Game game = new Game(new ConsoleLogger());


            //Act
            game.StartGame();

            //Assert
            Assert.That(game.Round, Is.EqualTo(1));
            Assert.That(dice.Sum, Is.EqualTo(9));
            Assert.That(player1.Position, Is.EqualTo(26));
        }

    }
}