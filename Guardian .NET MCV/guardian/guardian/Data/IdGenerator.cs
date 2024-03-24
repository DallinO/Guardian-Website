namespace guardian.Data
{
    public class IdGenerator
    {
        private static readonly Random random = new Random();

        public static int GenerateUniqueNumber()
        {
            int number;
            do
            {
                number = random.Next(100000000, 999999999); // Generate a random 9-digit number
            } while (!HasAtLeastThreeUniqueDigits(number) || HasConsecutiveRepetitions(number));

            return number;
        }

        private static bool HasAtLeastThreeUniqueDigits(int number)
        {
            var uniqueDigits = new HashSet<int>();
            while (number > 0)
            {
                int digit = number % 10;
                uniqueDigits.Add(digit);
                number /= 10;
            }
            return uniqueDigits.Count >= 3;
        }

        private static bool HasConsecutiveRepetitions(int number)
        {
            string numberString = number.ToString();
            int consecutiveCount = 1;
            for (int i = 1; i < numberString.Length; i++)
            {
                if (numberString[i] == numberString[i - 1])
                {
                    consecutiveCount++;
                    if (consecutiveCount > 3)
                    {
                        return true; // Found more than 3 consecutive repetitions
                    }
                }
                else
                {
                    consecutiveCount = 1; // Reset consecutive count
                }
            }
            return false;
        }
    }
}
