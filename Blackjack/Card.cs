using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Card
    {
        SuitRanks.Suits _currSuit;
        SuitRanks.Ranks _currRank;
        List<int> _values = new List<int>();

        public void createValues(SuitRanks.Suits suit, SuitRanks.Ranks rank, List<int> values)
        {
            _currSuit = suit;
            _currRank = rank;
            _values = values;
        }

        public void readValue()
        {
            string strValues = _values[0].ToString();
            for (int i = 1; i < _values.Count; i++)
            {
                strValues += (" or " + _values[i]);
            }

            Console.WriteLine($"This is the {_currRank} of {_currSuit}, with the value of {strValues}");
        }
    }
}
