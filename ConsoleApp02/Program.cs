using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary01;


namespace ConsoleApp02
{
    class GetSum
    {
        static void Main(string[] args)
        {
            Class1 ob = new Class1();
           // ob.Run();

            Console.WriteLine("Sum :-  "+ ob.SUM(35,22));
            ob.Display("Hello From Console App");
            ob.Display("I am feeling fantastic and full of positivity today!");
            Console.Read();

        }
            
    }
}