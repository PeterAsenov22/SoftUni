namespace The_Heigan_Dance
{
    using System;
    using System.Linq;

    public class HeiganDance
    {
        public static void Main()
        {
            var damageEachTurn = double.Parse(Console.ReadLine());
            var isHeiganDefeated = false;
            var isPlayerKilled = false;
            var playerRow = 7;
            var playerCol = 7;
            double HeiganPower = 3000000;
            var playerPower = 18500;
            var activePlagueCloud = false;
            var rows = 15;
            var cols = 15;
            var killingSpell = string.Empty;

            while (true)
            {
                var spellParams = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var spell = spellParams[0];
                var spellRow = int.Parse(spellParams[1]);
                var spellCol = int.Parse(spellParams[2]);

                HeiganPower -= damageEachTurn;
                

                if (activePlagueCloud)
                {
                    playerPower -= 3500;
                    activePlagueCloud = false;
                    killingSpell = "Plague Cloud";

                    if (playerPower <= 0)
                    {
                        isPlayerKilled = true;

                        if (HeiganPower <= 0)
                        {
                            isHeiganDefeated = true;
                        }

                        break;
                    }
                }

                if (HeiganPower <= 0)
                {
                    isHeiganDefeated = true;
                    break;
                }

                if (IsInDamageArea(spellRow, spellCol, playerRow, playerCol))
                {
                    if (!IsInDamageArea(spellRow, spellCol, playerRow - 1, playerCol) && !IsWall(playerRow - 1))
                    {
                        playerRow--;
                    }
                    else if (!IsInDamageArea(spellRow, spellCol, playerRow, playerCol + 1) && !IsWall(playerCol + 1))
                    {
                        playerCol++;
                    }
                    else if (!IsInDamageArea(spellRow, spellCol, playerRow + 1, playerCol) && !IsWall(playerRow + 1))
                    {
                        playerRow++;
                    }
                    else if (!IsInDamageArea(spellRow, spellCol, playerRow, playerCol - 1) && !IsWall(playerCol - 1))
                    {
                        playerCol--;
                    }
                    else
                    {
                        if (spell == "Cloud")
                        {
                            playerPower -= 3500;
                            activePlagueCloud = true;
                            killingSpell = "Plague Cloud";
                        }
                        else
                        {
                            playerPower -= 6000;
                            killingSpell = "Eruption";
                        }

                        if (playerPower <= 0)
                        {
                            isPlayerKilled = true;
                            break;
                        }
                    }
                }
            }

            if (isHeiganDefeated)
            {
                Console.WriteLine("Heigan: Defeated!");
            }
            else
            {
                Console.WriteLine($"Heigan: {HeiganPower:F2}");
            }

            if (isPlayerKilled)
            {
                Console.WriteLine($"Player: Killed by {killingSpell}");
            }
            else
            {
                Console.WriteLine($"Player: {playerPower}");
            }

            Console.WriteLine($"Final position: {playerRow}, {playerCol}");
        }

        private static bool IsInDamageArea(int spellRow, int spellCol, int playerRow, int playerCol)
        {
            return ((spellRow - 1 <= playerRow && playerRow <= spellRow + 1) &&
                    (spellCol - 1 <= playerCol && playerCol <= spellCol + 1));
        }

        private static bool IsWall(int moveCell)
        {
            return moveCell < 0 || moveCell >= 15;
        }
    }
}
