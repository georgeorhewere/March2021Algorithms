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
            string[] multipleInputs = { "abc", "abcc", "aabbcd", "abcdefghhgfedecba", "aabbccddeefghi","aabbc" };
            foreach (var _input in multipleInputs)
            {
                
                var result =  manager.checkStringIsValid(_input);
                Console.WriteLine($"input : {_input} is a valid string : {result}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
