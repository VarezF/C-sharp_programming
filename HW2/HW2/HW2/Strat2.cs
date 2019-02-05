/// <summary>
/// Brute force method
/// Does not alter the list in any way and determines the number of distinct items it contains
/// Keeps the storage complexity (auxiliary) at O(1)
/// </summary>
/// <parameters>
/// list of randomized integers
/// </parameters>

namespace HW2
{
    using System.Collections.Generic;
    using System.Linq;

    public class Strat2
    {
        private int uniqueInt;

        public Strat2(List<int> randList)
        {
            for (int i = 0; i < randList.Count(); i++)
            {
                for (int k = i + 1; k < randList.Count(); k++)
                {
                    if (randList[i] == randList[k])
                    {
                        break;
                    }
                    else if (k == randList.Count() - 1)
                    {
                        this.uniqueInt++;
                    }
                }
            }

            this.uniqueInt++;
        }

        public int GetUniqueInt()
        {
            return this.uniqueInt;
        }
    }
}
