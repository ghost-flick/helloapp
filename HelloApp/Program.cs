using System;

namespace HelloApp
{
    class Program
    {
        public static void GreetWhite()
        {
            Console.WriteLine("hello white");
        }

        public static void GreetBlack()
        {
            Console.WriteLine("Hello black");
        }
        static void Main()
        {
            Console.WriteLine("Hello everyone!");
            GreetBlack();
            GreetWhite();
        }
        
    }
}