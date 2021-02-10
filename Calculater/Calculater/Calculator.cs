using System;
using System.Collections.Generic;
using System.Text;

namespace Calculater
{
    public class Calculator
    {

        public double Accumulator { get; private set; }



        public double Add(double a, double b)
        {
            double result = a + b;
            Accumulator = result;
            return result;
        }

        public double Subtract(double a, double b)
        {
            double result = a - b;
            Accumulator = result;
            return result;
        }

        public double Multiply(double a, double b)
        {
            double result = a * b;
            Accumulator = result;
            return result;
        }

        public double Power(double x, double exp)
        {
            double result = Math.Pow(x, exp);
            Accumulator = result;
            return result;
           
        }

        public double Divide(double dividend, double divisor)
        {
            
            if (divisor != 0)
            {
                double result = dividend/divisor;
                Accumulator = result;
                return result;
               
            }
            else
            {
                Console.WriteLine("Du kan ikke dividere med 0");
            }

            return 0;

        }
 

        
    }
}
