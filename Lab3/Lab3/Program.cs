using System;
using System.Collections.Generic;

using System.Linq;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            bool proc = true;

            try
            {
                switch (proc)
                {
                    case true:
                        {
                            Console.WriteLine("Введите пример с данными операциями ( + | - | / )");
                            string readline = Console.ReadLine();

                            double x = Double.Parse(string.Concat(readline.TakeWhile(char.IsDigit)));

                            char op = readline.First(x => x.Equals('*') || x.Equals('+') || x.Equals('-'));

                            int IndexOp = readline.IndexOf(op);

                            string StringAfterOp = readline.Substring(IndexOp + 1);

                            int IndexDigitsAfterOp = StringAfterOp.IndexOfAny(numbers);

                            string StringDigitsAfterOp = StringAfterOp.Substring(IndexDigitsAfterOp);

                            double y = Double.Parse(string.Concat(StringDigitsAfterOp.TakeWhile(char.IsDigit)));

                            Calculator calculator = new Calculator(x, y, op);

                            goto case true;
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

 }

