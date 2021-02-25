using System;

namespace _08scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double success = double.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            double scholarshipSocial = 0;
            double scholarshipSuccess = 0;
            if (income<salary && success>4.5)
            {
                scholarshipSocial = Math.Floor(0.35 * salary);
            }
            if (success>=5.5)
            {
               scholarshipSuccess = Math.Floor(25 * success);
            }
            string res = "";
            if (scholarshipSocial>scholarshipSuccess)
            {
                res=$"You get a Social scholarship {scholarshipSocial} BGN";
            }
            else if  (scholarshipSocial <= scholarshipSuccess && scholarshipSuccess != 0)
                {
                res = $"You get a scholarship for excellent results {scholarshipSuccess} BGN";
                }
            else
            {
                res = "You cannot get a scholarship!";
            }
            Console.WriteLine(res);
        }
    }
}
