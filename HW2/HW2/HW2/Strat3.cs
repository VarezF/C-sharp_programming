/// <summary>
/// Sorts the list (use built-in sorting functionality) then uses a new algorithm to determine
/// the number of distinct items with O(1) storage, no dynamic memory allocation, and O(n) time complexity.
/// Does not alter the list further after sorting it.
/// Determines the number of distinct items in O(n) time (not including the sorting time)
/// where n is the number of items in the list
/// </summary>
/// <parameters>
/// list of randomized integers
/// </parameters>

namespace HW2
{
    using System.Collections.Generic;
    using System.Linq;

    public class Strat3
    {
        private int uniqueInt;

        public Strat3(List<int> randList)
        {
            randList.Sort();
            int val = -1;
            for (int i = 0; i < randList.Count(); i++)
            {
                if (val != randList[i])
                {
                    val = randList[i];
                    this.uniqueInt++;
                }
            }
        }

        public int GetUniquInt()
        {
            return this.uniqueInt;
        }
    }
}
