<<<<<<< HEAD
﻿namespace CommandPattern.Core.Models
{
    using Core.Contracts;
    using Core.Models.Commands;
    using System;
    using System.Reflection;
    using System.Linq;

    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] tokens = args.Split();

            string commandName = tokens[0];
            string[] commandArgs = tokens[1..];

            Type commandType = Assembly
                 .GetCallingAssembly()
                 .GetTypes()
                 .FirstOrDefault(x => x.Name == $"{commandName}Command");

            if (commandType == null)
            {
                throw new InvalidOperationException("Invalid command type");
            }
            ICommand command = (ICommand)Activator.CreateInstance(commandType);

            string result = command.Execute(commandArgs);

            return result;
        }
    }
}
=======
﻿namespace CommandPattern.Core.Models
{
    using Core.Contracts;
    using Core.Models.Commands;
    using System;
    using System.Reflection;
    using System.Linq;

    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] tokens = args.Split();

            string commandName = tokens[0];
            string[] commandArgs = tokens[1..];

            Type commandType = Assembly
                 .GetCallingAssembly()
                 .GetTypes()
                 .FirstOrDefault(x => x.Name == $"{commandName}Command");

            if (commandType == null)
            {
                throw new InvalidOperationException("Invalid command type");
            }
            ICommand command = (ICommand)Activator.CreateInstance(commandType);

            string result = command.Execute(commandArgs);

            return result;
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
