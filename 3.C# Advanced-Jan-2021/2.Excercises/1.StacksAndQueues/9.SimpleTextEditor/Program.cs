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
            Stack<string> undoState = new Stack<string>();
            string target = String.Empty;

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split();

                switch (cmd[0])
                {
                    case "1":
                        undoState.Push(target);
                        target += cmd[1];
                        break;
                    case "2":
                        if (target.Length >= int.Parse(cmd[1]))
                        {
                            undoState.Push(target);
                            target = target.Substring(0, target.Length - int.Parse(cmd[1]));
                        }
                        break;
                    case "3":
                        if (target.Length != 0)
                        {
                            Console.WriteLine(target[int.Parse(cmd[1])-1]);
                        }
                        break;
                    case "4":
                        if (undoState.Count > 0)
                        {
                                target = undoState.Pop();
                        }
                        else
                        {
                            target = "";
                        }
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
