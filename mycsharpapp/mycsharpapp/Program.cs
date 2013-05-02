using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorNs;


namespace mycsharpapp
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator calc = new Calculator();
            
            Console.WriteLine("Calling dependency Calculator dll.");
            Console.WriteLine("Passing 5+6 to Add() function.");
            int res = calc.Add(5, 6);
            Console.WriteLine("Result: {0:c}\nBye!", res);

            Console.ReadLine();
        }

    }
}
