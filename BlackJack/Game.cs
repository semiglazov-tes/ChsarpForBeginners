using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Game
    {
        private Deck _gameDeck;
        private User _user;
        private Dealer _dealer;
        public Deck GameDeck { get { return _gameDeck; } set { _gameDeck = value; } }
        public User user { get { return _user; } set { _user = value; } }
        public Dealer dealer { get { return _dealer; } set { _dealer = value; } }
        public void Start()
        {
            //создаётся и перемешивается колода
            GameDeck = new Deck();
            GameDeck.ShuffleTheDeck();
  
            //создание экземляров:Пользователь,Дилер
            Console.Write("Введите имя игрока:");
            string UserName = Console.ReadLine();
            _user = new User(UserName);
            _dealer = new Dealer(); 
        }
        //игровой круг
        public void FirstHand()
        {
            Card issueCardForUser = dealer.IssueACard(GameDeck);
            user.takeACard(issueCardForUser);
            Card issueCardForDealer = dealer.IssueACard(GameDeck);
            dealer.takeACard(issueCardForDealer);
            user.DisplayPlayerInfo();
            dealer.DisplayPlayerInfo();
            //Console.Write("Продолжить брать карты?(да/нет):");
        }
    }
}
