namespace Inferno_Infinity
{
    using System;
    using Interfaces;

    public class StartUp
    {
        public static void Main()
        {
            var command = Console.ReadLine();
            IManager manager = new Manager();

            while (command != "END")
            {
                var cmdArgs = command.Split(';');
                switch (cmdArgs[0])
                {
                    case "Create":
                        manager.Create(cmdArgs[1], cmdArgs[2]);
                        break;
                    case "Add":
                        manager.Add(cmdArgs[1], int.Parse(cmdArgs[2]), cmdArgs[3]);
                        break;
                    case "Remove":
                        manager.Remove(cmdArgs[1], int.Parse(cmdArgs[2]));
                        break;
                    case "Print":
                        Console.WriteLine(manager.Print(cmdArgs[1]));
                        break;
                }

                command = Console.ReadLine();
            }

            //var command = Console.ReadLine();
            //WeaponAttribute myWeaponAttr = typeof(Weapon).GetCustomAttribute<WeaponAttribute>();

            //while (command != "END")
            //{
            //    switch (command)
            //    {
            //        case "Author":
            //            Console.WriteLine($"Author: {myWeaponAttr.Author}");
            //            break;
            //        case "Revision":
            //            Console.WriteLine($"Revision: {myWeaponAttr.Revision}");
            //            break;
            //        case "Description":
            //            Console.WriteLine($"Class description: {myWeaponAttr.Description}");
            //            break;
            //        case "Reviewers":
            //            Console.WriteLine($"Reviewers: {string.Join(", ",myWeaponAttr.Reviewers)}");
            //            break;
            //    }

            //    command = Console.ReadLine();
            //}
        }
    }
}
