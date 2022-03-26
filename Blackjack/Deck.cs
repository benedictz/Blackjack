using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Deck
    {
        private List<Card> currDeck = new();
        public void NewDeck() 
        {
            Create();
            Console.WriteLine($"This deck has {currDeck.Count} cards");         //DEBUG
            Shuffle();
            foreach(Card card in currDeck)                                      //DEBUG
            {
                card.ReadValue();
            }
        }

        private void Create()
        {
            foreach (SuitRanks.Suits suit in Enum.GetValues(typeof(SuitRanks.Suits)))
            {
                foreach (SuitRanks.Ranks rank in Enum.GetValues(typeof(SuitRanks.Ranks)))
                {
                    List<int> rankValues = new List<int>();
                    int maxLimitRank = Math.Min(10, (int)rank + 1);
                    rankValues.Add(maxLimitRank);
                    if (maxLimitRank == 1)
                    {
                        rankValues.Add(maxLimitRank + 10);
                    }
                    Card card = new();

                    card.CreateValues(suit, rank, rankValues);
                    currDeck.Add(card);
                }
            }
            Console.WriteLine("Deck has been created!");        //DEBUG
        }

        private static Random rng = new Random();

        private void Shuffle()
        {
            List<Card> tempDeck = new();
            Random rnd = new Random();
            while (currDeck.Count > 1)
            {
                int randNum = rnd.Next(0, currDeck.Count);
                tempDeck.Add(currDeck[randNum]);
                currDeck.RemoveAt(randNum);
            }
            currDeck = tempDeck;
        }
    }
}
