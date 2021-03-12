using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace March2021Algorithms
{
    public class ValidStringManager
    {



        public void checkStringIsValid(string input)
        {
            var charGrps = input.GroupBy(x => x).OrderBy(d => d.Count()).ToList();
            charGrps.ForEach(d => Console.WriteLine($"{d.Key }  Count : {d.Count()}"));

        }

    }
}
