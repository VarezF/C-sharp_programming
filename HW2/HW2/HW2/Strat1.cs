/// <summary>
/// Does not alter the list in any way: Using a hash set to determine the number of distinct integers
/// in a given list.
/// Also calculates the time complexity of the above method.
/// Be careful with this and describe how you determined it.
/// </summary>
/// <parameters>
/// list of randomized integers
/// </parameters>

namespace HW2
{
    using System.Collections.Generic;
    using System.Linq;

    public class Strat1
    {
        private HashSet<int> uniqueSet;

        public Strat1(List<int> randList)
        {
            this.uniqueSet = new HashSet<int>();
            foreach (int index in randList)
            {
                this.uniqueSet.Add(index);
            }
        }

        public int GetSize()
        {
            return this.uniqueSet.Count();
        }
    }
}
