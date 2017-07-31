namespace Cards
{
    using System.Collections.Generic;
    using System.Linq;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var ranks = Enum.GetNames(typeof(Ranks));
            var suits = Enum.GetNames(typeof(Suits));
            var existingCards = new List<string>();
            var deckOfCards = new List<string>();

            foreach (var currentSuit in suits)
            {
                foreach (string rank in ranks)
                {
                    existingCards.Add($"{rank} of {currentSuit}");
                    deckOfCards.Add($"{rank} of {currentSuit}");
                }
            }

            var firstPlayer = Console.ReadLine();
            var secondPlayer = Console.ReadLine();

            var playersCards = new Dictionary<string, List<Card>>();

            playersCards[firstPlayer] = new List<Card>();
            playersCards[secondPlayer] = new List<Card>();

            while (playersCards[firstPlayer].Count<5 || playersCards[secondPlayer].Count<5)
            {
                var cardInfo = Console.ReadLine();

                try
                {
                    if (!existingCards.Contains(cardInfo))
                    {
                        throw new Exception("No such card exists.");
                    }

                    if (!deckOfCards.Contains(cardInfo))
                    {
                        throw new Exception("Card is not in the deck.");
                    }

                    var cardArgs = cardInfo.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    Card card = new Card(cardArgs[0],cardArgs[2]);

                    if (playersCards[firstPlayer].Count < 5)
                    {
                        playersCards[firstPlayer].Add(card);
                    }
                    else
                    {
                        playersCards[secondPlayer].Add(card);
                    }

                    deckOfCards.Remove(cardInfo);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            var firstPlayerTopCard = playersCards[firstPlayer].OrderByDescending(x => x.Power).First();
            var secondPlayerTopCard = playersCards[secondPlayer].OrderByDescending(x => x.Power).First();

            if (firstPlayerTopCard.Power > secondPlayerTopCard.Power)
            {
                Console.WriteLine($"{firstPlayer} wins with {firstPlayerTopCard}.");
            }
            else
            {
                Console.WriteLine($"{secondPlayer} wins with {secondPlayerTopCard}.");
            }
        }
    }
}
