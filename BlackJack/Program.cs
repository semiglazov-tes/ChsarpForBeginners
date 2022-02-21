using System;
using System.Text;
using BlackJack;

class Program
{
    public static void Main()
    {
        Game game = new Game();
        game.Start();
        do
        {
            game.GameCircle();
        } 
        while (game.EndGame == false);
  
    }
}