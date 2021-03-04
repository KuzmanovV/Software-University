using System;

namespace _4.PizzaCalories
{
    public static class Validator
    {
        public static void ThroughIfInvalidNumber(int min, int max, int number, string exceptionMessege)
        {
            if (number<min || number>max)
            {
                throw new ArgumentException(exceptionMessege);
            }
        }
    }
}