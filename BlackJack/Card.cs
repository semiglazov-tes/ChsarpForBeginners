using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Card
    {
        private Ranks _rank;
        private Suits _suit;
        public Ranks Rank { get => _rank; private set => _rank=value; }
        public Suits Suit { get => _suit; private set => _suit = value; }

        public enum Suits
        {
            Hearts=3,
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
            Jack=74,
            Queen=81,
            King=75,
            Ace=65
        }
        public Card(Suits suit,Ranks rank)
        {
            _rank = rank;
            _suit = suit;
        }

        public void DisplayCard() 
        {
            string ?rankString;
            if (_rank > Ranks.Ten)
            {
                rankString =Convert.ToString((char)_rank);
            }
            else
            {
                rankString = Convert.ToString(_rank);
            }
            switch (_suit) 
            {
                case Suits.Hearts:
                    Console.WriteLine($"{rankString}{Convert.ToString((char)_suit)}");
                    break;
                case Suits.Spades:
                    Console.WriteLine($"{rankString}{Convert.ToString((char)_suit)}");
                    break;
                case Suits.Clubs:
                    Console.WriteLine($"{rankString}{Convert.ToString((char)_suit)}");
                    break;
                case Suits.Diamonds:
                    Console.WriteLine($"{rankString}{Convert.ToString((char)_suit)}");
                    break;
            }
        }
    }
}
