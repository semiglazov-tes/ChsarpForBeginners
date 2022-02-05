using System;
namespace Lesson_5
{
    internal class Calculator
    {
        private double _firstNumber;
        private double _secondNumber;
        private string _operation;
        private bool _needOperation = true;
        private bool _correctOperation = false;
        public double FirstNumber
        {
            get
            {
                return _firstNumber;
            }
            set
            {
                _firstNumber = value;
            }
        }
        public double SecondNumber
        {
            get
            {
                return _secondNumber;
            }
            set
            {
                _secondNumber = value;
            }
        }
        public string Operation
        {
            get
            {
                return _operation;
            }
            set
            {
                _operation = value;
            }
        }
        public bool NeedOperation { get; set; }
        public bool CorrectOperation { get; set; }
        public void RunACalculation()
        {
            switch (_operation)
            {
                case "+":
                    Console.WriteLine($"Сумма чисел равна:{_firstNumber + _secondNumber}");
                    break;
                case "-":
                    Console.WriteLine($"Разница чисел равна:{_firstNumber - _secondNumber}");
                    break;
                case "*":
                    Console.WriteLine($"Произведение чисел равно:{_firstNumber * _secondNumber}");
                    break;
                case "/":
                    Console.WriteLine($"Результат деления:{_firstNumber / _secondNumber}");
                    break;
                default:
                    Console.WriteLine("Выбрана некорректная операция между двумя числами");
                    break;
            }
        }
    }
}
