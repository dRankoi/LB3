using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Calculator
    {
        double x;
        double y;

        public Calculator(double X, double Y, char op)
        {
            x = X;
            y = Y;

            if (op == '+') Addition();
            else if (op == '-') Substraction();
            else if (op == '*') Multiplication();
        }

        public void Addition()
        {
            Console.WriteLine($"Ответ: {x + y}");
        }
        public void Substraction()
        {
            Console.WriteLine($"Ответ: {x - y}");
        }

        public void Multiplication()
        {
            Console.WriteLine($"Ответ: {x * y}");
        }

       
        
    }
}
