using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Learning_4
{
    class PlayingCard
    {
        public Suit CardSuit {get;}
        public Rank CardRank { get; }

        public PlayingCard(Rank r, Suit s)
        {
            CardSuit = s;
            CardRank = r;
        }

        public override string ToString()
        {
            return $"{CardRank} of {CardSuit}";
        }
    }
}
