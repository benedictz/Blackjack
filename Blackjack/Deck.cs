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
            foreach(Card card in currDeck)                                      //DEBUG
            {
                card.readValue();
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

                    card.createValues(suit, rank, rankValues);
                    currDeck.Add(card);
                }
            }
            Console.WriteLine("Deck has been created!");        //DEBUG
        }

        private void Shuffle(List<Card> freshDeck)
        {

        }
    }
}
