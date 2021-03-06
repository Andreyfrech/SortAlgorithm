using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortAlgorithms;

namespace AlgorithmBase
{
   public class CocktailSort<T> : AlgorithmBase<T> where T: IComparable
    {
        public override void Sort()
        {
            int left = 0;
            int right = Items.Count - 1;

            while(left < right)
            {
                for(int i = left; i < right; i++)
                {
                    if(Items[i].CompareTo(Items[i + 1]) == 1)
                    {
                        Swop(i, i + 1);
                    }
                }
                right--;

                for(int i = right; i > left; i--)
                {
                   if(Items[i].CompareTo(Items[i - 1]) == -1)
                    {
                        Swop(i, i - 1);
                    }
                }
                left++;
            }

        }
    }
}
