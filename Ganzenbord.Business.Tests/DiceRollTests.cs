namespace Ganzenbord.Business.Tests
{
    internal class DiceRollTests
    {
        [Test]
        public void TrowTest()
        {
            //Arrange
            Dice dice1 = new Dice();

            //Act
            int[] result = dice1.RollTheDices();

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

            //Act
            player1.Move(dice);

            //Assert
            Assert.That(player1.Round, Is.EqualTo(1));
            Assert.That(dice.Sum, Is.EqualTo(9));
            Assert.That(player1.Position, Is.EqualTo(26));
        }

    }
}