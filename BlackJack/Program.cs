using System;
using System.Text;
using BlackJack;
using static BlackJack.Card;

class Program
{

    public static void Main()
    {
        Deck deck = new Deck();
        deck.ShuffleTheDeck();
        deck.DisplayDeck();
        
    }
}