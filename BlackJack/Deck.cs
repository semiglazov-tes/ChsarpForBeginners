using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlackJack.Card;


namespace BlackJack
{
    internal class Deck
    {
        private List<Card> _deck=new List<Card>();
        public Deck() 
        {

            CreateDeck();   
        }
        public void CreateDeck()
        {
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (Ranks rank  in Enum.GetValues(typeof(Ranks)))
                {
                    Card card = new Card(suit, rank);
                    _deck.Add(card);
                }
            }
        }
        public void DisplayDeck()
        {
            foreach (Card card in _deck)
            {
                card.DisplayCard();
            }
        }
        public void ShuffleTheDeck()
        {
            Random random = new Random();
            for (int i = 0; i <_deck.Count-1 ; i++)
            {
                int randomIndex = random.Next(52);
                Card tempCard = _deck[i];
                _deck[i] = _deck[randomIndex];
                _deck[randomIndex] = tempCard;
            }
        }
    }
}
