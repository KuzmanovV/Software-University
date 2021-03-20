using System;
using System.Linq;
using System.Reflection;
using CommandPattern.Commands;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] inputTokens = args.Split();
            string commandType = inputTokens[0];
            string[] commandArguments = inputTokens.Skip(1).ToArray();

            string result = null;

            ICommand command = null;

            Type type = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x=>x.Name==$"{commandType}Command");

            ICommand instance = (ICommand) Activator.CreateInstance(type);

            result = instance.Execute(commandArguments);

            return result;
        }
    }
}