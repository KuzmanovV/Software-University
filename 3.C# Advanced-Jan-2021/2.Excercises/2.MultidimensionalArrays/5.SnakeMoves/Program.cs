﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            string[,] matrix = new string[rows, cols];
            Queue<string> snakeQueue = new Queue<string>();
            string snake = Console.ReadLine();

            foreach (var item in snake)
            {
                snakeQueue.Enqueue(item.ToString());
            }
           
            int counter = 0;

            for (int row = 0; row < rows; row++)
            {
                if (counter%2==0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = snakeQueue.Peek();
                        snakeQueue.Enqueue(snakeQueue.Dequeue());
                        Console.Write(matrix[row,col]);
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snakeQueue.Peek();
                        snakeQueue.Enqueue(snakeQueue.Dequeue());
                    }

                    for (int col = 0; col < cols; col++)
                    {
                        Console.Write(matrix[row,col]);
                    }
                }

                counter++;
                Console.WriteLine();
            }
        }
    }
}
