using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public static class ArenaSetting
    {

        public static int BaseHealthPoints { get; private set; } = 100;
        public static int BaseDamage { get; private set; } = 5;

        private static Random s_random = new Random();
        private static int s_minRandom = 0;
        private static int s_maxRandom = 101;

        private static string[] s_names = { "Санек", "Леха", "Костян", "Кирилл", "Женя" };

        public static int GetRandomNumber(int maxRandom)
        {
            int number = 0;

            number = s_random.Next(s_minRandom, maxRandom + 1);

            return number;
        }

        public static bool IsEvent(int probability)
        {
            int randomNumber = s_random.Next(s_minRandom, s_maxRandom);

            if(randomNumber <= probability)
                return true;
            return false;
        }

        public static string GetRandomNumber()
        {
            return s_names[s_random.Next(s_minRandom, s_names.Length)];
        }
    }
}
