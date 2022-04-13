using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class StandardCard : AbstractCard
    {
        private RankSuit.Ranks _currRank;
        private RankSuit.Suits _currSuit;
        private List<int> _values = new List<int>();

        public void CreateValues(RankSuit.Ranks rank, RankSuit.Suits suit, List<int> values)
        {
            _currRank = rank;
            _currSuit = suit;
            _values = values;
            description = _currRank.ToString() + " of " + _currSuit.ToString();
        }

        /// <summary>
        /// Returns the Rank, Suit and all Values associated with this card
        /// </summary>
        public void ReadValue()
        {
            string strValues = _values[0].ToString();
            for (int i = 1; i < _values.Count; i++)
            {
                strValues += (" or " + _values[i]);
            }

            Console.WriteLine($"{description}, value of {strValues}");
        }
    }
}
