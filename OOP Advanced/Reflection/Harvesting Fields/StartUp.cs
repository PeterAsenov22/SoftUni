namespace Harvesting_Fields
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var command = Console.ReadLine();
            Harvester harvester = new Harvester();
            Type harvestingFieldsType = typeof(HarvestingFields);
            
            while (command != "HARVEST")
            {
                switch (command)
                {
                    case "private":
                        Console.WriteLine(harvester.GetAllPrivateFields(harvestingFieldsType));
                        break;
                    case "protected":
                        Console.WriteLine(harvester.GetAllProtectedFields(harvestingFieldsType));
                        break;
                    case "public":
                        Console.WriteLine(harvester.GetAllPublicFields(harvestingFieldsType));
                        break;
                    case "all":
                        Console.WriteLine(harvester.GetAllFields(harvestingFieldsType));
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
