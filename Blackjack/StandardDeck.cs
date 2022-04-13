using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class StandardDeck
    {
        private List<StandardCard> currDeck;
        public StandardDeck()
        {
            Create();
        }

        /// <summary>
        /// Wipes the current deck and creates a new standard deck of cards
        /// </summary>
        private void Create()
        {
            currDeck = new();
            foreach (RankSuit.Suits suit in Enum.GetValues(typeof(RankSuit.Suits)))
            {
                foreach (RankSuit.Ranks rank in Enum.GetValues(typeof(RankSuit.Ranks)))
                {
                    List<int> rankValues = new List<int>();
                    int maxLimitRank = Math.Min(10, (int)rank + 1);
                    rankValues.Add(maxLimitRank);
                    if (maxLimitRank == 1)
                    {
                        rankValues.Add(maxLimitRank + 10);
                    }
                    StandardCard card = new();
                    card.CreateValues(rank, suit, rankValues);
                    currDeck.Add(card);
                }
            }
            Console.WriteLine($"Deck of {currDeck.Count} cards has been created!");        //DEBUG
        }

        /// <summary>
        /// Reads all cards currently in the deck
        /// </summary>
        public void ReadCards()
        {
            foreach (StandardCard card in currDeck)                         //DEBUG
            {
                card.ReadValue();
            }
        }

        /// <summary>
        /// Pure randomisation of all cards.
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
