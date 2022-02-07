using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Player
    {
        private string _name;
        private byte _theSumOfCards;
        private List<Card> _playerDeck;
        public string Name { get { return _name; } set { _name = value; } }
        public byte TheSumOfCards { get { return _theSumOfCards; } set { _theSumOfCards = value;} }
        public Player(string name)
        {
            _playerDeck = new List<Card>();
            Name = name;   
        }
        public void takeACard(Card card)
        {
            _playerDeck.Add(card);
            byte card_rank = (byte)card.Rank;
            _theSumOfCards += card_rank;
        }
        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"У {Name} {TheSumOfCards} очков");
            Console.Write("Карты на руках:");
            foreach (var card in _playerDeck)
            {
                card.DisplayCard();
            }
        }
    }
}
