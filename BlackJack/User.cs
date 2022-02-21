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
        //принятие решения о продолжении игры
        public override bool DecisionMaking()
        {
        bool _decision = true;
        string _returnOperation;
        bool _operationIsCorrect = true;
         do
            {
                Console.Write("Продолжить игру(да/нет)?:");
                _returnOperation = Console.ReadLine().ToLower();
                if (_returnOperation == "да")
                {
                    _decision=true;
                    _operationIsCorrect = true;
                }
                else if (_returnOperation == "нет")
                {
                    _decision=false;
                    _operationIsCorrect = true;
                }
                else
                {
                    Console.WriteLine("Выбрана некорректная операция");
                    _operationIsCorrect = false;
                }
            }
            while (_operationIsCorrect == false) ;
            return _decision;   
        }
        //Вывод информации о сумме карт и перечня карт Пользователя во время игры
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