<<<<<<< HEAD
﻿namespace CommandPattern.Core.Models
{
    using Core.Contracts;
    using System;
    public class Engine : IEngine
    {
        private ICommandInterpreter _commandInterpreter;
        public Engine(ICommandInterpreter commandInterpreter)
        {
            this._commandInterpreter = commandInterpreter;
        }
        public void Run()
        {
            while (true)
            {
                string command = Console.ReadLine();

                string result = this._commandInterpreter.Read(command);

                if (result == null)
                {
                    break;
                }

                Console.WriteLine(result);
            }
        }
    }
}
=======
﻿namespace CommandPattern.Core.Models
{
    using Core.Contracts;
    using System;
    public class Engine : IEngine
    {
        private ICommandInterpreter _commandInterpreter;
        public Engine(ICommandInterpreter commandInterpreter)
        {
            this._commandInterpreter = commandInterpreter;
        }
        public void Run()
        {
            while (true)
            {
                string command = Console.ReadLine();

                string result = this._commandInterpreter.Read(command);

                if (result == null)
                {
                    break;
                }

                Console.WriteLine(result);
            }
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
