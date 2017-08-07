using System;
using System.Linq;
using System.Reflection;
using System.Text;
using _03BarracksFactory.Attributes;
using _03BarracksFactory.Contracts;
using _03BarracksFactory.Core.Commands;

namespace _03BarracksFactory.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            StringBuilder name = new StringBuilder(commandName);
            name[0] = name[0].ToString().ToUpper().ToCharArray().First();

            Type commandType =
                Type.GetType($"_03BarracksFactory.Core.Commands.{name}Command");

            IExecutable command;
            try
            {
                command = (Command)Activator.CreateInstance(commandType, new object[] { data});
                command = this.InjectDependencies(command);
                return command;
            }
            catch (Exception)
            {
                throw new Exception("Invalid command!");
            }
        }

        private IExecutable InjectDependencies(IExecutable command)
        {
            FieldInfo[] cmdFields = command.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            FieldInfo[] interpreterFields = typeof(CommandInterpreter).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var field in cmdFields)
            {
                if (field.GetCustomAttribute(typeof(InjectAttribute)) != null)
                {
                    if (interpreterFields.Any(x => x.FieldType == field.FieldType))
                    {
                        field.SetValue(command,interpreterFields.First(x=>x.FieldType==field.FieldType).GetValue(this));
                    }
                }
            }

            return command;
        }
    }
}
