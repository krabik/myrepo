using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DemoClassLib;

namespace DemoNugetPckProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            MyMathClass m = new MyMathClass();

            int res = m.sum(2, 7);
            Console.WriteLine("Calling sum() function from nuget package named: DemoClassLib.1.0.0.nupkg\n\nResult: {0}", res); 
   
            Console.WriteLine("\nBye!");
            Console.ReadLine();

        }
    }
}
