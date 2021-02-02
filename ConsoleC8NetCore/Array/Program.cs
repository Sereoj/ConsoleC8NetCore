using System;

namespace ConsoleC8NetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Array
             * unary_expression
             */
            var words = new string[]
            {
                "Каждый",   //0 || ^7
                "охотник",  //1 || ^6
                "желает",   //2 || ^5
                "знать",    //3 || ^4
                "где",      //4 || ^3
                "сидит",    //5 || ^2
                "фазан",    //6 || ^1
            };

            Console.WriteLine($"{words[^7]} {words[^1]}");
          
        }
    }
}
