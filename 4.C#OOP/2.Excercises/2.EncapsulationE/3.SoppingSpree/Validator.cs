using System;

namespace _3.SoppingSpree
{
    public static class Validator
    {
        public static void ThrowIfStringIsNullOrEmpty(string str, string exceptionMessage)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException(exceptionMessage);
            }
        }

        public static void ThrowIfNumberIsNegative(decimal dec, string exceptionMessage)
        {
            if (dec<0)
            {
                throw new ArgumentException(exceptionMessage);
            }
        }
    }
}