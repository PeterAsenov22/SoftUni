namespace _02.Blobs
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Core;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleWriter writer = new ConsoleWriter();
            ConsoleReader reader = new ConsoleReader();
            IOManager manager = new IOManager(writer);
            Object managerInstance = Activator.CreateInstance(typeof(IOManager),new object[]{writer});
            string input = reader.ReadLine();
            while (input!="Drop")
            {
                var cmdArgs = input.Split().ToList();
                string commandName = cmdArgs[0];
                cmdArgs.RemoveAt(0);

                MethodInfo command =
                    typeof(IOManager).GetMethod(commandName, BindingFlags.Instance | BindingFlags.Public);
               
                command.Invoke(managerInstance, new[] {cmdArgs.ToArray()});

                input = reader.ReadLine();
            }
        }
    }
}
