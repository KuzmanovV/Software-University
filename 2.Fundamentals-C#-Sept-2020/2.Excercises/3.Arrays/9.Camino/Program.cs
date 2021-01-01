using System;
using System.Linq;

namespace _9.Camino
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int bestSample = 1;
            int[] bestDNA = new int[length];
            int counterSequence = 0;
            int sumOnesBestDNA = 0;
            int greatestCounterElementsBestDNA = 0;
            int indexBestDNA = 0;

            string input = "";
            
            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int[] dna = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int counterElements = 0;
                int greatestCounterElements = 0;
                int index = 0;
                int sumOnes = 0;

                counterSequence++;

                for (int i = 0; i < length; i++)
                {
                    if (dna[i] == 1)
                    {

                        for (int j = i + 1; j < length; j++)
                        {
                            if (dna[i] == dna[j])
                            {
                                counterElements++;
                            }
                            else
                            {
                                break;
                            }
                        }

                        if (counterElements > greatestCounterElements)
                        {
                            greatestCounterElements = counterElements;
                            index = i;
                        }
                    }
                }

                sumOnes = dna.Sum();

                if (greatestCounterElements > greatestCounterElementsBestDNA)
                {
                    greatestCounterElementsBestDNA = greatestCounterElements;
                    bestDNA = dna;
                    indexBestDNA = index;
                    sumOnesBestDNA = sumOnes;
                    bestSample = counterSequence;
                }
                else if (index < indexBestDNA && greatestCounterElementsBestDNA == greatestCounterElements)
                {
                    greatestCounterElementsBestDNA = greatestCounterElements;
                    bestDNA = dna;
                    indexBestDNA = index;
                    sumOnesBestDNA = sumOnes;
                    bestSample = counterSequence;
                }
                else if (index == indexBestDNA && greatestCounterElements == greatestCounterElementsBestDNA)
                {
                    if (sumOnes > sumOnesBestDNA)
                    {
                        greatestCounterElementsBestDNA = greatestCounterElements;
                        bestDNA = dna;
                        indexBestDNA = index;
                        sumOnesBestDNA = sumOnes;
                        bestSample = counterSequence;
                    }
                }

                counterElements = 0;
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {sumOnesBestDNA}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}
