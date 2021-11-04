using System;
using System.Collections.Generic;
using System.Text;

namespace Calculators.XUnitTestMoq
{
    public class Calculator : ICalculator
    {
        public (string operation, double result) Calculate(string operation, double a, double b)
        {
            (string operacao, double resultado) operationResult;
            double c;

            switch (operation)
            {
                case "sum":
                    c = a + b;
                    break;
                case "subtract":
                    c = a - b;
                    break;
                case "multiply":
                    c = a * b;
                    break;
                case "divide":
                    c = Math.Round(a / b, 2);
                    break;
                default:
                    c = a + b;
                    break;
            }

            operationResult = (operation, c);
            return operationResult;
        }

    }
}
