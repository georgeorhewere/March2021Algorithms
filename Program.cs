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
            string[] multipleInputs = { "abc", "abcc", "aabbcd", "aabbcd", "aabbccddeefghi" };
            foreach (var _input in multipleInputs)
            {
                Console.WriteLine($"input : {_input}");
                manager.checkStringIsValid(_input);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
