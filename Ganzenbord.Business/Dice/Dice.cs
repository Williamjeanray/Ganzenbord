namespace Ganzenbord.Business
{
    public class Dice : IDice
    {
        private Random rnd = new Random();

        private int RollTheDices()
        {
            return rnd.Next(1, 7);
        }

        public int[] RollTheDices(int amountOfDices = 2)
        {
            if (amountOfDices < 1)
            {
                amountOfDices = 1;
            }

            int[] result = new int[amountOfDices];

            for (int i = 0; i < amountOfDices; i++)
            {
                result[i] = RollTheDices();
            }

            return result;
        }
    }
}