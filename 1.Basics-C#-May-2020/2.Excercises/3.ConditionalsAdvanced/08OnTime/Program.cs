using System;

namespace _08OnTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int hExam = int.Parse(Console.ReadLine());
            int mExam = int.Parse(Console.ReadLine());
            int hCome = int.Parse(Console.ReadLine());
            int mCome = int.Parse(Console.ReadLine());
            int tExam = mExam + hExam * 60;
            int tCome = mCome + hCome * 60;
            string output1 = "";
            string output2 = "";
            if (tCome < (tExam - 30))
            {
                output1 = "Early";
                if (tExam - tCome < 60)
                {
                    output2 = $"{tExam - tCome} minutes before the start";
                }
                else
                {
                    int outH = (tExam - tCome) / 60;
                    int outM = (tExam - tCome) % 60;
                    if (outM < 10)
                    {
                        output2 = $"{outH}:0{outM} hours before the start";
                    }
                    else
                    {
                        output2 = $"{outH}:{outM} hours before the start";
                    }
                }
            }
            else if (tCome >= (tExam - 30) && tCome <= tExam)
            {
                output1 = "On time";
                if (tExam > tCome)
                {
                    output2 = $"{tExam - tCome} minutes before the start";
                }
            }
            else if (tCome > tExam)
            {
                output1 = "Late";
                if (tCome - tExam < 60)
                {
                    output2 = $"{tCome - tExam} minutes after the start";
                }
                else
                {
                    int outH = (tCome - tExam) / 60;
                    int outM = (tCome - tExam) % 60;
                    if (outM < 10)
                    {
                        output2 = $"{outH}:0{outM} hours after the start";
                    }
                    else
                    {
                        output2 = $"{outH}:{outM} hours after the start";
                    }
                }
            }
            Console.WriteLine(output1);
            Console.WriteLine(output2);
        }
    }
}
