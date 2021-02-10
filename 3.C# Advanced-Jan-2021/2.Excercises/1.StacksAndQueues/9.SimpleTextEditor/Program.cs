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
            Queue<string> commandsQueue = new Queue<string>();
            Stack<string> undoState = new Stack<string>();
            string target = " ";

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split();

                switch (cmd[0])
                {
                    case "1":
                        target += cmd[1];
                        undoState.Push(target);
                        break;
                    case "2":
                        if (target.Length != 0 && int.Parse(cmd[1]) != 0)
                        {
                            target = target.Substring(0, target.Length - int.Parse(cmd[1]));
                            undoState.Push(target);
                        }
                        break;
                    case "3":
                        if (target.Length != 0)
                        {
                            Console.WriteLine(target[int.Parse(cmd[1])]);
                        }
                        break;
                    case "4":
                        if (undoState.Count > 0)
                        {
                            undoState.Pop();

                            if (undoState.Count > 0)
                            {
                                target = undoState.Peek();
                            }
                            else
                            {
                                target = string.Empty;
                            }
                        }
                        else
                        {
                            target = string.Empty;
                        }
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
