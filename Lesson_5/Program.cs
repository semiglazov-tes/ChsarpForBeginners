using Lesson_5;

class Program
{
    static void Main()
    {
        bool needOperation;
        do
        {
            Calculator calculator = new Calculator();

            Console.Write("Введите первое число:");
            calculator.FirstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Определите операцию(+;-;*;/;):");
            calculator.Operation= Console.ReadLine();

            Console.Write("Введите второе число:");
            calculator.SecondNumber = Convert.ToDouble(Console.ReadLine());

           calculator.RunACalculation();

            MakeDecisionToProceedWithTheCalculation makeDecision = new MakeDecisionToProceedWithTheCalculation();

            makeDecision.ChekingTheOperation();
            needOperation =makeDecision.DecisionAboutCalculation;
        }
        while (needOperation == true);
        
    }
}
