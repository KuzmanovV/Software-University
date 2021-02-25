using System;

namespace _03Key
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string word = "";
            int marker1 = 0;
            int marker2 = 0;
            int marker3 = 0;
            string output = "";

            while (n!="End")
            {
                char letter = char.Parse(n);

                if (letter>='a' && letter<='z' || letter>='A' && letter<='Z')
                {
                    if (letter=='c' && marker1==0)
                    {
                        marker1++;
                    }
                    else if (letter=='o' && marker2==0)
                    {
                        marker2++;
                    }
                    else if (letter=='n' && marker3==0)
                    {
                        marker3++;
                    }
                    else
                    {
                        word += letter;
                    }
                    
                }
                if (marker1 + marker2 + marker3 == 3)
                {
                            output +=word;
                            output +=" ";
                            marker1 = 0;
                            marker2 = 0;
                            marker3 = 0;
                            word = "";
                }

                n = Console.ReadLine();
            }

            Console.WriteLine(output);
        }
    }
}
