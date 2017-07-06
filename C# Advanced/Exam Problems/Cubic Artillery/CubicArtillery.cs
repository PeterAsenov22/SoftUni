namespace Cubic_Artillery
{
    using System;
    using System.Collections.Generic;

    public class CubicArtillery
    {
        public static void Main()
        {
            var maxCapacity = int.Parse(Console.ReadLine());
            var bunkers = new List<Bunker>();
            var input = Console.ReadLine();
            var overflowed = new List<Bunker>();

            while (input!="Bunker Revision")
            {
                var inputParams = input.Split();
                for (int i = 0; i < inputParams.Length; i++)
                {
                    var currentInput = inputParams[i];
                    int weapon;
                    var isParsed = int.TryParse(currentInput, out weapon);
                    if (!isParsed)
                    {
                        var bunker = new Bunker()
                        {
                            Name = currentInput,
                            CurrentCapacity = 0,
                            Weapons = new List<int>()
                        };

                        bunkers.Add(bunker);
                    }
                    else
                    {
                        
                        for (int j = 0; j < bunkers.Count; j++)
                        {
                            var currentBunker = bunkers[j];
                            if (currentBunker.CurrentCapacity + weapon <= maxCapacity)
                            {
                                currentBunker.CurrentCapacity += weapon;
                                currentBunker.Weapons.Add(weapon);
                            }
                            else
                            {
                                if (overflowed.Count + 1 < bunkers.Count)
                                {
                                    overflowed.Add(bunkers[j]);
                                }

                                if (j == bunkers.Count - 1)
                                {
                                    if (weapon <= maxCapacity)
                                    {
                                        for (int k = 0; k < currentBunker.Weapons.Count; k++)
                                        {
                                            var currToRemove = currentBunker.Weapons[k];
                                           currentBunker.Weapons.Remove(currToRemove);
                                            currentBunker.CurrentCapacity -= currToRemove;
                                            k--;

                                            if (currentBunker.CurrentCapacity + weapon <= maxCapacity)
                                            {
                                                currentBunker.CurrentCapacity += weapon;
                                                currentBunker.Weapons.Add(weapon);
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (overflowed.Count > 0)
                    {
                        for (int j = 0; j < overflowed.Count; j++)
                        {
                            var curr = overflowed[j];
                            string weapons;
                            if (curr.Weapons.Count > 0)
                            {
                                weapons = string.Join(", ", curr.Weapons);
                            }
                            else
                            {
                                weapons = "Empty";
                            }
                            Console.WriteLine($"{curr.Name} -> {string.Join(", ",weapons)}");
                            bunkers.RemoveAll(x=>x.Name == curr.Name);
                        }

                        overflowed.Clear();
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
