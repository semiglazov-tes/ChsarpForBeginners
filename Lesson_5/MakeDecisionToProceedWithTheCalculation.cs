using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    internal class MakeDecisionToProceedWithTheCalculation
    {
        private bool _operationIsCorrect=true;
        private string _returnOperation;
        private bool _decisionAboutCalculation;
        public bool DecisionAboutCalculation
        {
            get
            {
                return _decisionAboutCalculation;
            }
        }

        public void ChekingTheOperation()
        {         
            do
            {
                Console.Write("Продолжить вычисления(да/нет)?:");
                _returnOperation = Console.ReadLine().ToLower();
                if (_returnOperation == "да")
                {
                    _decisionAboutCalculation= true;
                }
                else if (_returnOperation == "нет")
                {
                    _decisionAboutCalculation = false;
                }
                else
                {
                    Console.WriteLine("Выбрана некорректная операция");
                    _operationIsCorrect = false;
                }
            }
            while (_operationIsCorrect == false);
        }
    }
}
