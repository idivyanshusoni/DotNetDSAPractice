using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDSAPractice
{
    public class TwoSum
    {
        public int[] Perform(int[] nums, int target)
        {
            var seen = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (seen.ContainsKey(complement))
                    return new int[] { seen[complement], i };

                seen[nums[i]] = i;
            }
            return Array.Empty<int>();
        }
    }
}
