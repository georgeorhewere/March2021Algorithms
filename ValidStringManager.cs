using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace March2021Algorithms
{
    public class ValidStringManager
    {



        public string checkStringIsValid(string input)
        {

            bool isValid;

            var charGrps = input.GroupBy(x => x).OrderBy(d => d.Count()).ToList();

            // get count groups
            var itemGroupByCount = charGrps.GroupBy(x => x.Count()).ToList();
            var maxCount = itemGroupByCount.Max(x => x.Count());

            //get key with max count 
            var key = itemGroupByCount.OrderByDescending(b => b.Max(o => o.Count())).First(x => x.Count() == maxCount).Key;

            if (charGrps.All(d => d.Count() == key))
            {
                // IsValid string
                isValid = true;
            }
            else
            {

                // get number of items outside key 
                var removalGroups = itemGroupByCount.Where(x => x.Key != key).ToList();
                if (removalGroups.Count() == 1 && removalGroups.First().Count() == 1)
                {

                    var removeCharacter = removalGroups.First();

                    if (removeCharacter.First().Count() > key)
                    {
                        isValid = (removeCharacter.First().Count() - 1) == key;
                    }
                    else
                    {
                        isValid = (removeCharacter.First().Count() - 1) == 0;
                    }

                }
                else
                {
                    isValid = false;
                }
            }
            return isValid ? "YES" : "NO";
        }

    }
}
