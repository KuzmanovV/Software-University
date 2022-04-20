using System;
using System.Linq;

namespace ArraysME
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequenceNumber = int.Parse(Console.ReadLine());
            int[] totalArr = new int[sequenceNumber];

            int code = 0;

            for (int i = 0; i < sequenceNumber; i++)
            {
                string input = Console.ReadLine();

                int letterCode = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    switch ((int)input[j])
                    {
                        case 65:
                        case 69:
                        case 73:
                        case 79:
                        case 85:
                        case 97:
                        case 101:
                        case 105:
                        case 111:
                        case 117: letterCode = input[j] * input.Length; break;
                        default:
                            letterCode = input[j] / input.Length;
                            break;
                    }

                    code += letterCode;
                }
                totalArr[i] = code;
                code = 0;
            }
            Array.Sort(totalArr);
            Console.WriteLine(string.Join(Environment.NewLine, totalArr));
        }
    }
}
