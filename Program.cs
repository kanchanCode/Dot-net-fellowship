using System;

namespace helloWorld
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name ");
            string input = Console.ReadLine();
            Console.WriteLine("Hello World " + input);
            Console.ReadKey();

        }
    }
}
