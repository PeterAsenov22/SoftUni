namespace Military_Elite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Military_Elite.Soldiers;

    public class StartUp
    {
        public static void Main()
        {
            var privates = new List<Private>();

            var command = Console.ReadLine();
            while (command != "End")
            {
                var cmdArgs = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs[0] == "Private")
                {
                    var privatte = new Private(cmdArgs[1], cmdArgs[2], cmdArgs[3], double.Parse(cmdArgs[4]));
                    privates.Add(privatte);
                    Console.WriteLine(privatte);
                }
                else if (cmdArgs[0] == "LeutenantGeneral")
                {
                    var leutenantPrivates = new List<Private>();
                    for (int i = 5; i < cmdArgs.Length; i++)
                    {
                        var currID = cmdArgs[i];
                        var @private = privates.First(x => x.ID == currID);
                        leutenantPrivates.Add(@private);
                    }

                    var leutenantGeneral = new LeutenantGeneral(cmdArgs[1],cmdArgs[2],cmdArgs[3],double.Parse(cmdArgs[4]),leutenantPrivates);
                    Console.WriteLine(leutenantGeneral);
                }
                else if (cmdArgs[0] == "Spy")
                {
                    var spy = new Spy(cmdArgs[1],cmdArgs[2],cmdArgs[3],int.Parse(cmdArgs[4]));
                    Console.WriteLine(spy);
                }
                else if (cmdArgs[0] == "Engineer")
                {
                    if (cmdArgs[5] == "Marines" || cmdArgs[5] == "Airforces")
                    {
                        var repairs = new List<Repair>();
                        for (int i = 6; i < cmdArgs.Length; i++)
                        {
                            var currRepair = new Repair(cmdArgs[i], int.Parse(cmdArgs[i + 1]));
                            repairs.Add(currRepair);
                            i++;
                        }

                        var engineer = new Engineer(cmdArgs[1], cmdArgs[2], cmdArgs[3], double.Parse(cmdArgs[4]),
                            cmdArgs[5], repairs);
                        Console.WriteLine(engineer);
                    }
                }
                else if (cmdArgs[0] == "Commando")
                {
                    if (cmdArgs[5] == "Marines" || cmdArgs[5] == "Airforces")
                    {
                        var missions = new List<Mission>();
                        for (int i = 6; i < cmdArgs.Length; i++)
                        {
                            if (cmdArgs[i + 1] == "Finished" || cmdArgs[i + 1] == "inProgress")
                            {
                                var currMission = new Mission(cmdArgs[i],cmdArgs[i+1]);
                                missions.Add(currMission);
                            }
                            i++;
                        }

                        var commando = new Commando(cmdArgs[1], cmdArgs[2], cmdArgs[3], double.Parse(cmdArgs[4]),
                            cmdArgs[5], missions);
                        Console.WriteLine(commando);
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
