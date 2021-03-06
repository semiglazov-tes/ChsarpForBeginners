class Program
{
    static void Main()
    {
        double firstNumber;
        double secondNumber;
        string? operation;
        bool needOperation = true;
        bool correctOperation = false;
        do
        {
            Console.Write("Введите первое число:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Определите операцию(+;-;*;/;):");
            operation = Console.ReadLine();
            Console.Write("Введите второе число:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            RunACalculation(firstNumber, secondNumber, operation);
            MakeDecisionToProceedWithTheCalculation(ref correctOperation, ref needOperation);
            correctOperation = false;
        }
        while (needOperation == true);
    }
    public static void RunACalculation(double firstNumber, double secondNumber, string operation)
    {
        switch (operation)
        {
            case "+":
                Console.WriteLine($"Сумма чисел равна:{firstNumber + secondNumber}");
                break;
            case "-":
                Console.WriteLine($"Разница чисел равна:{firstNumber - secondNumber}");
                break;
            case "*":
                Console.WriteLine($"Произведение чисел равно:{firstNumber * secondNumber}");
                break;
            case "/":
                Console.WriteLine($"Результат деления:{firstNumber / secondNumber}");
                break;
            default:
                Console.WriteLine("Выбрана некорректная операция между двумя числами");
                break;
        }
    }
    public static void MakeDecisionToProceedWithTheCalculation(ref bool correctOperation, ref bool needOperation)
    {
        string returnOperation;
        while (correctOperation == false)
        {
            Console.Write("Пролжить вычисления(да/нет)?:");
            returnOperation = Console.ReadLine().ToLower();
            if (returnOperation == "да")
            {
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
    }
}
