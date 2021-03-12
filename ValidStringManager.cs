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
            // get count groups
            var itemGroupByCount = charGrps.GroupBy(x => x.Count()).ToList();
            var maxCount = itemGroupByCount.Max(x => x.Count());
            //get key with max count 
            var key = itemGroupByCount.OrderByDescending(s=> s.Max(o=>o.Count())).First(x => x.Count() == maxCount).Key;

            if (charGrps.All(d=> d.Count() == key))
            {
                // IsValid string
                Console.WriteLine($"Yes - Valid String");
            }
            else
            {
                Console.WriteLine($"Check Removal Conditions");
                //var minCount = charGrps.Min(x => x.Count());                
                Console.WriteLine($"maximum characters with same count { key } : max count { maxCount }");
                // get number of items outside key 
                var removalGroups = itemGroupByCount.Where(x => x.Key != key).ToList();                
                if(removalGroups.Count() == 1 && removalGroups.First().Count() == 1)
                {
                    Console.WriteLine($"Removal Groups");
                    removalGroups.ForEach(f => Console.WriteLine($" keys: {f.Key} count { f.Count()}"));
                    var removeCharacter = removalGroups.First();
                    
                    Console.WriteLine($"Attempt to remove");
                    if (removeCharacter.Count() > key)
                    {
                        if ((removeCharacter.Count() - 1) == key)
                        {
                            Console.WriteLine($"Yes - Valid String {removeCharacter.Key} {(removeCharacter.Count() - 1) }");
                        }

                    }
                    else
                    {
                        if ((removeCharacter.Count() - 1) == 0)
                        {
                            Console.WriteLine($"Yes - Valid String {removeCharacter.Key} {(removeCharacter.Count() - 1) }");
                        }

                    }
                    


                }
                else
                {
                    Console.WriteLine($"No");
                }


            }

        }

    }
}
