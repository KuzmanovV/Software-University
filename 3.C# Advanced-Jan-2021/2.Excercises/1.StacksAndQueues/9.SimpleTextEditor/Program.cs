using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<char> stack = new Stack<char>();
            Stack<char> container = new Stack<char>();

            int stringForRemoval1 = 0;
            Stack<int> forUndo = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split();

                if (int.Parse(cmd[0])==1||int.Parse(cmd[0])==2)
                {
                forUndo.Push(int.Parse(cmd[0]));
                }

                switch (cmd[0])
                {
                    case "1":
                        foreach (var item in cmd[1])
                        {
                            stack.Push(item);
                        }
                        stringForRemoval1 = cmd[1].Length;
                        break;
                    case "2":
                        for (int j = 0; j < int.Parse(cmd[1]); j++)
                        {
                            container.Push(stack.Pop());
                        }
                        break;
                    case "3":
                        char[] forPrint = stack.ToArray();
                        Array.Reverse(forPrint);
                        Console.WriteLine(forPrint[int.Parse(cmd[1]) - 1]);
                        break;
                    case "4":
                        switch (forUndo.Pop())
                        {
                            case 1:
                                for (int k = 0; k < stringForRemoval1; k++)
                                {
                                    stack.Pop();
                                }
                                break;
                            case 2:
                                stack.Push(container.Pop());
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
