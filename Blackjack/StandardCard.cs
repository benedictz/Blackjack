using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class StandardCard : AbstractCard
    {
        SuitRanks.Suits _currSuit;
        SuitRanks.Ranks _currRank;
        List<int> _values = new List<int>();

        public void CreateValues(SuitRanks.Suits suit, SuitRanks.Ranks rank, List<int> values)
        {
            _currSuit = suit;
            _currRank = rank;
            _values = values;
            description = _currRank.ToString() + " of " + _currSuit.ToString();
        }

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
