using System;

namespace FootballTeamGenerator
{
    public static class Validator
    {
        public static void ThrowIfNullOrWhiteSpace(string str, string exceptionMessege)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException(exceptionMessege);
            }
        }

        public static void ThrowIfNotInRange(int min, int max, int stat, string exceptionMessege)
        {
            if (stat < min || stat > max)
            {
                throw new ArgumentException(exceptionMessege);
            }
        }
    }
}