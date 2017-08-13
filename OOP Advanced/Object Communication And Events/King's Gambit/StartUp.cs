namespace King_s_Gambit
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            King king = new King(Console.ReadLine());
            ModifiedDictionary soldiersByName = new ModifiedDictionary();

            string[] guards = Console.ReadLine().Split();
            foreach (var guard in guards)
            {
                RoyalGuard royalGuard = new RoyalGuard(guard);
                soldiersByName.Add(guard, royalGuard);
                royalGuard.SoldierDeath += soldiersByName.HandleSoldierDeath;
                royalGuard.SoldierDeath += king.OnSoldierDeath;
                king.UnderAttack += royalGuard.OnKingUnderAttack;
            }

            string[] footmen = Console.ReadLine().Split();
            foreach (var footman in footmen)
            {
                Footman foot = new Footman(footman);
                soldiersByName.Add(footman, foot);
                foot.SoldierDeath += soldiersByName.HandleSoldierDeath;
                foot.SoldierDeath += king.OnSoldierDeath;
                king.UnderAttack += foot.OnKingUnderAttack;
            }

            string command = Console.ReadLine();
            while (command!="End")
            {
                string[] cmdArgs = command.Split();
                switch (cmdArgs[0])
                {
                    case "Kill":
                        Soldier soldierToRemove = soldiersByName[cmdArgs[1]];
                        soldierToRemove.RespondToAttack();
                        break;
                    case "Attack":
                        king.RespondToAttack();
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
