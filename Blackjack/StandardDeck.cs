using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class StandardDeck
    {
        private List<StandardCard> currDeck = new();
        public void NewDeck() 
        {
            Create();
            TrueShuffle();

            foreach (StandardCard card in currDeck)                         //DEBUG
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
                    StandardCard card = new();
                    card.CreateValues(suit, rank, rankValues);
                    currDeck.Add(card);
                }
            }
            Console.WriteLine($"Deck of {currDeck.Count} cards has been created!");        //DEBUG
        }

        /// <summary>
        /// Pure randomisation of all cards. Lacks authenticity, but it gets the job done.
        /// </summary>
        public void TrueShuffle()
        {
            Console.WriteLine("True Shuffle");        //DEBUG
            List<StandardCard> tempDeck = new();
            Random rnd = new Random();
            while (currDeck.Count > 1)
            {
                int randNum = rnd.Next(0, currDeck.Count);
                tempDeck.Add(currDeck[randNum]);
                currDeck.RemoveAt(randNum);
            }
            currDeck.AddRange(tempDeck);
        }
    }
}
