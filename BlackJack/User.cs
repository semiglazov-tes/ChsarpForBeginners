using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class User : Player
    {
        public User(string name) : base(name)
        {
        }
        //Вывод информации о сумме карт и перечня карт Пользователя
        public override void DisplayPlayerInfo()
        {
            Console.WriteLine($"{Name} у вас {TheSumOfCards} очков");
            Console.Write("Карты на руках:");
            foreach (var card in PlayerDeck)
            {
                card.DisplayCard();
            }
        }
    }
}
