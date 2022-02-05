using System;
using System.Text;
using BlackJack;
using static BlackJack.Card;

class Program
{
    
    public static void Main()
    {

        string[] values = (string[])GetEnumValues();
        foreach (var color in values)
        {
            Console.WriteLine(color);
        }
    }
    public static Array GetEnumValues() 
    {
        return Enum.GetNames(typeof(Colors));
    }

    //How to use
    public enum Colors
    {
        Red,
        Yellow,
        Green
    }


}