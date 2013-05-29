using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoClassLib;

namespace DemoJobPullFromNexus
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMathClass m = new MyMathClass();

            int res = m.sum(2, 7);
            Console.WriteLine("Calling sum() function from nuget package named: DemoClassLib.nupkg\n\nResult: {0}", res);

            Console.WriteLine("\nBye!");
            Console.ReadLine();
        }



    }
}
