namespace Black_Box_Integer
{
    using System;
    using System.Reflection;

    public class StartUp
    {
        public static void Main()
        {          
            Type blackBoxInt = typeof(BlackBoxInt);
           // BlackBoxInt instancee = (BlackBoxInt) Activator.CreateInstance(blackBoxInt,true);
            ConstructorInfo constructor = blackBoxInt.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null,
                new Type[] {typeof(int)}, null);
            BlackBoxInt instance = (BlackBoxInt)constructor.Invoke(new object[] {0});

            var command = Console.ReadLine();
            while (command!="END")
            {
                var commandInfo = command.Split('_');
                var commandName = commandInfo[0];
                var commandParams = int.Parse(commandInfo[1]);

                MethodInfo method = blackBoxInt.GetMethod(commandName,
                    BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);
                method.Invoke(instance, new object[] { commandParams });
                var field = blackBoxInt.GetField("innerValue", BindingFlags.Instance | BindingFlags.NonPublic);
                Console.WriteLine(field.GetValue(instance));

                command = Console.ReadLine();
            }           
        }
    }
}
