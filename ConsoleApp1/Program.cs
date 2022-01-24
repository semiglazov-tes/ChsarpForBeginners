// See https://aka.ms/new-console-template for more information
namespace ConsoleApp1
{
    class Program
    {

        static void Main()
        {
            double firstNumber;
            double secondNumber;
            string? operation;
            string? returnOperation;
            bool needOperation=true;
            bool correctOperation = false;
            do
            {
                Console.Write("Введите первое число:");
                firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.Write("Определите операцию(+;-;*;/;):");
                operation = Console.ReadLine();
                Console.Write("Введите второе число:");
                secondNumber = Convert.ToDouble(Console.ReadLine());
                switch (operation)
                {
                    case "+":
                        Console.WriteLine($"Сумма чисел равна:{firstNumber+secondNumber}");
                        break;
                    case "-":
                        Console.WriteLine($"Разница чисел равна:{firstNumber - secondNumber}");
                        break;
                    case "*":
                        Console.WriteLine($"Произведение чисел равно:{firstNumber*secondNumber}");
                        break;
                    case "/":
                        Console.WriteLine($"Результат деления:{firstNumber/secondNumber}");
                        break;
                    default:
                        Console.WriteLine("Выбрана некорректная операция между двумя числами");
                        break;
                }
                while (correctOperation == false)
                {
                    Console.Write("Пролжить вычисления(да/нет)?:");
                    returnOperation = Console.ReadLine().ToLower();
                    if (returnOperation == "да")
                    {
                        needOperation = true;
                        correctOperation = true;
                    }
                    else if (returnOperation == "нет")
                    {
                        needOperation = false;
                        correctOperation = true;
                    }
                    else
                    {
                        Console.WriteLine("Выбрана некорректная операция");
                    }
                }
                correctOperation =false;
            } 
            while (needOperation==true);
            
            
         }   
    }
}

