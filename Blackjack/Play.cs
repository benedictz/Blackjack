using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Play
    {
        public static void Start () {
            Console.WriteLine("Begin Blackjack");
            StandardDeck deck = new();
            deck.NewDeck();
            }
    }
}
