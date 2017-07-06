namespace Hands_of_Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsOfCards
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var playersCards = new Dictionary<string,HashSet<string>>();

            while (input!="JOKER")
            {
                var inputParams = input.Split(':').Select(x => x.Trim()).ToArray();
                var player = inputParams[0];
                var cardsParams = inputParams[1].Split(new []{' ',','},StringSplitOptions.RemoveEmptyEntries);

                if (!playersCards.ContainsKey(player))
                {
                    playersCards[player] = new HashSet<string>();
                }

                foreach (var card in cardsParams)
                {
                    playersCards[player].Add(card);
                }

                input = Console.ReadLine();
            }

            foreach (var player in playersCards)
            {
                var playerName = player.Key;
                var playerCards = player.Value;
                var playerScore = 0;

                foreach (var card in playerCards)
                {
                    var cardPower = 0;
                    var cardType = 0;
                    if (card[0] == '2' || card[0] == '3' || card[0] == '4' || card[0] == '5' ||
                        card[0] == '6' || card[0] == '7' || card[0] == '8' || card[0] == '9')
                    {
                        cardPower = int.Parse(card[0].ToString());
                    }
                    else if(card[0] == '1')
                    {
                        cardPower = 10;
                    }
                    else
                    {
                        if (card[0] == 'J')
                        {
                            cardPower = 11;
                        }
                        else if (card[0] == 'Q')
                        {
                            cardPower = 12;
                        }
                        else if (card[0] == 'K')
                        {
                            cardPower = 13;
                        }
                        else if (card[0] == 'A')
                        {
                            cardPower = 14;
                        }
                    }

                    if (card[card.Length - 1] == 'S')
                    {
                        cardType = 4;
                    }
                    else if (card[card.Length-1] == 'H')
                    {
                        cardType = 3;
                    }
                    else if (card[card.Length - 1] == 'D')
                    {
                        cardType = 2;
                    }
                    else if (card[card.Length - 1] == 'C')
                    {
                        cardType = 1;
                    }

                    playerScore += cardType * cardPower;                    
                }

                Console.WriteLine($"{playerName}: {playerScore}");
            }
        }
    }
}
