using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal abstract class Player
    {
        private string _name;
        private byte _theSumOfCards;
        private List<Card> _playerDeck;
        public string Name { get { return _name; } set { _name = value; } }
        public byte TheSumOfCards { get { return _theSumOfCards; } set { _theSumOfCards = value;} }
        public List<Card> PlayerDeck { get { return _playerDeck; } set { _playerDeck = value; } }
        public Player(string name)
        {
            _playerDeck = new List<Card>();
            Name = name;   
        }
        public virtual void takeACard(Card card)
        {
            PlayerDeck.Add(card);
            byte card_rank = (byte)card.Rank;
            TheSumOfCards += card_rank;
        }
        public abstract void DisplayPlayerInfo();
    }
}
