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
        private List<Card> _listCard;
        public List<Card> ListCard { get { return _listCard; } }
        public Deck() 
        {
            _listCard = new List<Card>();
            CreateDeck();   
        }
        //создание колоды
        public void CreateDeck()
        {
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (Ranks rank  in Enum.GetValues(typeof(Ranks)))
                {
                    Card card = new Card(suit, rank);
                    _listCard.Add(card);
                }
            }
        }
        //вывод колоды на консоль
        public void DisplayDeck()
        {
            foreach (Card card in _listCard)
            {
                card.DisplayCard();
            }
        }
        // перетосовать колоду
        public void ShuffleTheDeck()
        {
            Random random = new Random();
            for (int i = 0; i < _listCard.Count-1 ; i++)
            {
                int randomIndex = random.Next(52);
                Card tempCard = _listCard[i];
                _listCard[i] = _listCard[randomIndex];
                _listCard[randomIndex] = tempCard;
            }
        }
    }
}
