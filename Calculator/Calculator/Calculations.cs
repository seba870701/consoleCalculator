using System.Collections.Generic;

namespace Calculator
{
    public static class Calculations
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Add(List<double> numbers)
        {
            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public static double Subtract(double n1, double n2)
        {
            return n1 - n2;
        }
        public static double Subtract(List<double> numbers)
        {
            double result = 0;
            foreach (var number in numbers)
            {
                result -= number;
            }
            return result;
        }
        public static double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }
        public static double Multiply(List<double> numbers)
        {
            double result = 0;
            foreach (var number in numbers)
            {
                result *= number;
            }
            return result;
        }
        public static double Divide(double n1, double n2)
        {
            return n1 / n2;
        }
        public static double Divide(List<double> numbers)
        {
            double result = 0;
            foreach (var number in numbers)
            {
                result /= number;
            }
            return result;
        }
    }
}

