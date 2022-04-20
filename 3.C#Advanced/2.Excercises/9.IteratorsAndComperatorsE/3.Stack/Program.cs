using System;
using System.Linq;

namespace _3.Stack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();

            string command;
            while ((command = Console.ReadLine())!="END")
            {
                string[] cmd = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (cmd[0]=="Push")
                {
                    int[] cmdElements = cmd[1].Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    for (int i = 1; i < cmdElements.Length; i++)
                    {
                        myStack.Push(cmdElements[i]);
                    }
                }
                else if (cmd[0]=="Pop")
                {
                    try
                    {
                        myStack.Pop();
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);   
                    }     
                }
            }
            
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(string.Join(Environment.NewLine, myStack));
        }
    }
}
