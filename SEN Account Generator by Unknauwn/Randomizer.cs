namespace SEN_Account_Generator_by_Unknauwn
{
    using System;
    using System.Text;

    public class Randomizer
    {
        private static Random random = new Random((int) DateTime.Now.Ticks);

        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public static string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                char ch = Convert.ToChar(Convert.ToInt32(Math.Floor((double) ((26.0 * random.NextDouble()) + 65.0))));
                builder.Append(ch);
            }
            return builder.ToString();
        }
    }
}

