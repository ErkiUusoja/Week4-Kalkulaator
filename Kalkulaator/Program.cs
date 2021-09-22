using System;

namespace Kalkulaator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double firstnum;
            double secondnum;
            double answer;
            string ops;

            Console.WriteLine("\t\t\tconsole Calculator tutorial in c#\r");
            Console.WriteLine("\t\t\t---------------------------------\r");

            Console.WriteLine("\t\t\tEnter first number\n");
            firstnum = double.Parse(Console.ReadLine());
            Console.ReadKey();

            Console.WriteLine("\t\t\tselect an operator : (+, -, *, /, %)\n");
            ops = (Console.ReadLine());
            Console.ReadKey();

            Console.WriteLine("\t\t\tEnter second number\n");
            secondnum = double.Parse("\t\t\t" + Console.ReadLine());

            if(ops == "+")
            {
                answer = firstnum + secondnum;
                Console.Write("\n" + answer);
            }
            if (ops == "-")
            {
                answer = firstnum - secondnum;
                Console.Write("\n" + answer);
            }
            if (ops == "*")
            {
                answer = firstnum * secondnum;
                Console.Write("\n" + answer);
            }
            if (ops == "/")
            {
                answer = firstnum / secondnum;
                Console.Write("\n" + answer);
            }
            if (ops == "%")
            {
                answer = firstnum % secondnum;
                Console.Write("\n" + answer);
            }

            Console.Write("\n" + "press an key to exit");
            Console.ReadKey();

        }
    }
}