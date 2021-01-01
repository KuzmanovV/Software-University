using System;
using System.ComponentModel;

namespace _4.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isValid1 = false;
            bool isValid2 = false;
            bool isValid3 = false;
            int sumDigits = 0;

            if (Between6And10Incl(password.Length))
            {
                isValid1 = true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid1 = false;
            }

            for (int i = 0; i < password.Length; i++)
            {
                if (ConsistsOnlyLettersDigits(password[i]))
                {
                    isValid2 = true;
                }
                else
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    isValid2 = false;
                    break;
                }
            }

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] > 47 && password[i] < 58)
                {
                    sumDigits++;
                }
            }

            if (sumDigits >= 2)
            {
                isValid3 = true;
            }
            else
            {
                isValid3 = false;
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isValid1 && isValid2 && isValid3)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool Between6And10Incl(int length)
        {
            if (length >= 6 && length <= 10)
            {
                return true;
            }

            return false;
        }

        private static bool ConsistsOnlyLettersDigits(char v)
        {
            if ((v >= '0' && v <= '9') || (v >='A' && v <= 'Z') || (v >='a' && v <='z'))
            {
                return true;
            }

            return false;
        }
    }
}
