﻿using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a, b, c;
            //a = 10;
            //b = 20;
            //c = a + b;
            //Console.WriteLine("The Sum of {0} and {1} is {2}",a,b,c);

            //Console.WriteLine("The Sum is " + c);

            //Console.WriteLine("The Sum of"+ a +"and" + b + "is" + c);

            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse("45");
            c = a + b;
            Console.WriteLine("The Sum of {0} and {1} is {2}", a, b, c);

            Console.WriteLine("The Sum is " + c);

            Console.WriteLine("The Sum of " + a + " and " + b + " is " + c);

            Console.ReadLine();
        }
    }
}
