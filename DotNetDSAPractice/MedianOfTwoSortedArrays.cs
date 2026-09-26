using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDSAPractice
{
    public class MedianOfTwoSortedArrays
    {
        public double Perform(int[] arr1, int[] arr2)
        {
            if (arr1.Length > arr2.Length)
                return Perform(arr2, arr1);

            int m = arr1.Length;
            int n = arr2.Length;

            int left = 0;
            int right = m;

            int totalLeft = (m + n + 1) / 2;

            while (left <= right)
            {
                int partition1 = left + (right - left) / 2;
                int partition2 = totalLeft - partition1;

                int left1 = partition1 == 0 ? int.MinValue : arr1[partition1 - 1];
                int left2 = partition1 == m ? int.MaxValue : arr1[partition1];

                int right1 = partition2 == 0 ? int.MinValue : arr2[partition2 - 1];
                int right2 = partition2 == n ? int.MaxValue : arr2[partition2];

                //if correct partition found
                if (left1 <= right2 && left2 <= right1)
                {
                    int maxLeft = Math.Max(left1, left2);

                    if ((m + n) % 2 == 1) //if odd total elements
                        return maxLeft;

                    int minRight = Math.Min(right1, right2);

                    return (maxLeft + minRight) / 2.0;
                }

                //if not the above case then we have taken many elements from arr1
                if (left1 > right2)
                    right = partition1 - 1;
                else
                    //we have take few elements from arr1
                    left = partition1 + 1;
            }
            throw new ArgumentException();
        }
    }
}
