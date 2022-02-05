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
        private Card[] _deck;
        public Deck() 
        {

            //CreateDeck();   
        }
        public Deck CreateDeck()
        {
            string[] suits = (string[])Enum.GetNames(typeof(Suits));
            string[] rank = (string[])Enum.GetNames(typeof(Suits));
        }
    }
}
/*public enum Suits
{
    Hearts = 3,
    Diamonds,
    Clubs,
    Spades
}
public enum Ranks
{
    Two = 2,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack = 74,
    Queen = 81,
    King = 75,
    Ace = 65
}*/