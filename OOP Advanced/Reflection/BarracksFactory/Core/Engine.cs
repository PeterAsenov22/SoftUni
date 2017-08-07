using System.Linq;
using System.Text;
using _03BarracksFactory.Core.Commands;

namespace _03BarracksFactory.Core
{
    using System;
    using Contracts;

    class Engine : IRunnable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public void Run()
        {
            var cmdInterpreter = new CommandInterpreter(repository,unitFactory);
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    var command = cmdInterpreter.InterpretCommand(data, commandName);
                    string result = command.Execute();
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
