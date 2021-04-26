using System.Collections.Generic;

namespace PrimeLogic
{
    public static class PrimeNumbersLogic
    {
        public static string GetPrimeNumbers(int number)
        {
            if (!CheckPrimeNumber(number))
            {
                return "Entered number is not Prime";
            }
            else
            {
                return GetAllIncludingPrimeNumbers(number);
            }
        }
        public static string GetAllIncludingPrimeNumbers(int number)
        {
            List<int> result = new List<int>();

            for (int i = 0; i <= number; i++)
                if (CheckPrimeNumber(i))
                    result.Add(i);
            return string.Join(", ", result);
        }

        public static bool CheckPrimeNumber(int number)
        {
            if (number < 2)
                return false;

            for (int j = 2; j * j <= number; ++j)
                if (number % j == 0)
                    return false;

            return true;
        }

    }
}
