namespace Frends.TestTask.DoNothing
{
    public class TestTask
    {
        /// <summary>
        /// Not a real task.
        /// </summary>
        public static bool DoNothing()
        {
            return true;
        }

        internal static int DummySumEvenNumbers(int limit)
        {
            var normalizedLimit = DummyNormalizeLimit(limit);
            var total = 0;

            for (var i = 0; i <= normalizedLimit; i++)
            {
                if (i % 2 == 0)
                {
                    total += i;
                }
            }

            return total;
        }

        internal static string DummyFormatMessage(string prefix, int value, bool upperCase)
        {
            var safePrefix = string.IsNullOrWhiteSpace(prefix) ? "value" : prefix.Trim();
            var formatted = safePrefix + ":" + value;
            return upperCase ? formatted.ToUpperInvariant() : formatted.ToLowerInvariant();
        }

        internal static bool DummyIsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (var i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static int DummyNormalizeLimit(int limit)
        {
            if (limit < 0)
            {
                return 0;
            }

            return limit > 10000 ? 10000 : limit;
        }
    }
}
