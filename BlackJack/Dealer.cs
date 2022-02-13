using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Dealer : Player
    {
        public Dealer(string name="Дилер") : base(name)
        {

        }
        //Реализация выдачи карты из колоды
        public Card IssueACard(Deck deck)
        {
           List<Card> listCard=deck.ListCard;
           Random random = new Random();
           int randomIndex = random.Next(52);
           Card issuingCard=listCard[randomIndex];
           listCard.RemoveAt(randomIndex);
            return issuingCard;
        }
        //Реализация поведения диалера(брать или не брать карту)
        public bool DecisionMaking()
        {
            Random random = new Random();
            if (TheSumOfCards <= 10)
            {
                return true;
            }
            else if (TheSumOfCards > 10 && TheSumOfCards <= 17)
            {
                bool decision = Convert.ToBoolean(random.Next(0, 2));
                return decision;
            }
            else { return false; }
        }
          //Вывод информации о сумме карт и перечня карт Дилера
          public override void DisplayPlayerInfo()
        {
            Console.WriteLine($"У {Name}a {TheSumOfCards} очков");
            Console.Write($"Карты {Name}a:");
            foreach (var card in PlayerDeck)
            {
                card.DisplayCard();
            }
        }
    }
}
