using System;

namespace March2021Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alogorithm Practice March 2021");
            testValidString();

        }

        static void testValidString()
        {
            ValidStringManager manager = new ValidStringManager();
            string testInput = "abc";
            manager.checkStringIsValid(testInput);
            Console.ReadKey();
        }
    }
}
