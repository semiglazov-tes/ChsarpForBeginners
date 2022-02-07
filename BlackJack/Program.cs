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
        Player TestPlayer = new Player("Алексей");
        Dealer TestDealer = new Dealer("Дилер");
        Card testCard = TestDealer.IssueACard(deck);
        TestPlayer.takeACard(testCard);
        TestPlayer.DisplayPlayerInfo();
        
    }
}