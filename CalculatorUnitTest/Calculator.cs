using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorUnitTest
{
    public class Calculator
    {
        private double result = 0;
        
        public double Add(double a, double b)
        {
            result=a + b;
            return result;
        }

        public double Subtract(double a, double b)
        {
            result = a - b;
            return result;

        }
        public double Multiply(double a, double b)
        { 
            result = a * b;
            return result;
        }

        public double Power(double x, double exp)
        {
            result = Math.Pow(x,exp);
            return result;
        }

        public double Divide(double a, double b)
        {
            result = a / b;
            return result;
        }

        public double Accumulator { get; private set; }

        public void Clear()
        {
            Accumulator = 0;
        }
    }
}
