using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Dealer : Player
    {
        public Dealer(string name) : base(name)
        {

        }
        public Card IssueACard(Deck deck)
        {
           List<Card> listCard=deck.ListCard;
           Random random = new Random();
           int randomIndex = random.Next(52);
           Card issuingCard=listCard[randomIndex];
           listCard.RemoveAt(randomIndex);
            return issuingCard;
        }
    }
}
