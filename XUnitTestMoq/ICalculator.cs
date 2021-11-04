using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestMoq
{
    public interface ICalculator
    {
        (string operation, double result) Calculate(string operation, double a, double b);
    }
}
