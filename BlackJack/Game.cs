using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Game
    {
        private bool _endGame=false;
        private bool _agreementUser=true;
        private bool _agreementDealer=true;
        private Card _issueCardForUser;
        private Card _issueCardForDealer;
        private Deck _gameDeck;
        private User _user;
        private Dealer _dealer;
        public bool EndGame { get { return _endGame; } }
        public bool AgreementUser { get { return _agreementUser; } }
        public bool AgreementDealer { get { return _agreementDealer; } }
        public User User { get { return _user; } }
        public Dealer Dealer { get { return _dealer; } }
        //играют Пользователь и Дилер
        private void _twoPlayersGame()
        {
            _issueCardForUser = _dealer.IssueACard(_gameDeck);
            _user.takeACard(_issueCardForUser);
            _issueCardForDealer = _dealer.IssueACard(_gameDeck);
            _dealer.takeACard(_issueCardForDealer);
            if (_bruteForceCheck() == false)
            {
                _user.DisplayPlayerInfo();
                //_dealer.DisplayPlayerInfo();
                _agreementUser = _user.DecisionMaking();
                _agreementDealer = _dealer.DecisionMaking();
            }
        }
        //игру продолжает Пользователь
        private void _theGameIsContinuedByTheUser()
        {
            _issueCardForUser = _dealer.IssueACard(_gameDeck);
            _user.takeACard(_issueCardForUser);
            if (_bruteForceCheck()== false)
            {
                _user.DisplayPlayerInfo();
                _agreementUser = _user.DecisionMaking();
            }  
        }
        //игру продолжает Дилер
        private void _theGameIsContinuedByTheDealer()
        {
            _issueCardForDealer = _dealer.IssueACard(_gameDeck);
            _dealer.takeACard(_issueCardForDealer);
            if (_bruteForceCheck() == false)
            {
                //_dealer.DisplayPlayerInfo();
                _agreementDealer = _dealer.DecisionMaking();
            }
        }
        //проверка на перебор, проверка что хотя бы один игрок в игре
        private bool _bruteForceCheck()
        {
            bool _checked = false;
            if (_user.TheSumOfCards > 21 | _dealer.TheSumOfCards > 21)
            {
                _fullEndGame();
                _checked= true;
            }
            return _checked;
        }
        private void _checkingPlayersForReadlinessToContinueTheGame()
        {
            if (_agreementUser == false & _agreementDealer == false)
            {
                _fullEndGame();
            }
        }
        //окончание игры
        private void _fullEndGame()
        {
            _endGame = true;
            switch ((_user.TheSumOfCards > 21, _dealer.TheSumOfCards > 21))
            {
                case (true,true):
                    Console.WriteLine("У обоих игроков перебор.Победителя нет");
                    break;
                case (false, true):
                    Console.WriteLine($"Победу одержал {_user.Name}");
                    Console.WriteLine($"Количество очков победителя: {_user.TheSumOfCards}");
                    Console.Write($"Карты:");
                    _user.DisplayFinalPlayerDeck();
                    break;
                case (true, false):
                    Console.WriteLine($"Победу одержал {_dealer.Name}");
                    Console.WriteLine($"Количество очков победителя: {_dealer.TheSumOfCards}");
                    Console.WriteLine($"Карты:");
                    _dealer.DisplayFinalPlayerDeck();
                    break;
                default:
                    if(_user.TheSumOfCards> _dealer.TheSumOfCards)
                    {
                        Console.WriteLine($"Победу одержал {_user.Name}");
                        Console.WriteLine($"Количество очков победителя: {_user.TheSumOfCards}");
                        Console.WriteLine($"Карты:");
                        _user.DisplayFinalPlayerDeck();
                    }
                    else
                    {
                        Console.WriteLine($"Победу одержал {_dealer.Name}");
                        Console.WriteLine($"Количество очков победителя: {_dealer.TheSumOfCards}");
                        Console.WriteLine($"Карты:");
                        _dealer.DisplayFinalPlayerDeck();
                    }
                    break;
            }
        }  

        //начало игры
        public void Start()
        {
            //создаётся и перемешивается колода
            _gameDeck = new Deck();
            _gameDeck.ShuffleTheDeck();
  
            //создание экземляров:Пользователь,Дилер
            Console.Write("Введите имя игрока:");
            string UserName = Console.ReadLine();
            _user = new User(UserName);
            _dealer = new Dealer(); 
        }
        //игровой круг
        public void GameCircle()
        {
            switch ((_agreementUser,_agreementDealer))
            {
                //оба игрока будут брать карты
                case (true,true):
                    _twoPlayersGame();
                    break;
                //Пользователь будет брать карту, Дилер пасует
                case (true, false):
                    _theGameIsContinuedByTheUser();
                    break;
                //Дилер будет брать карту, Пользователь пасует
                case (false, true):
                    _theGameIsContinuedByTheDealer();
                    break;
            }
            _checkingPlayersForReadlinessToContinueTheGame();
            if (_endGame == false)
            {
                Console.Clear();
            }
        }

    }
}
