using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDSAPractice
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int Perform(string s)
        {
            Dictionary<char, int> lastSeen = new Dictionary<char, int>();

            int left = 0;
            int maxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                if (lastSeen.ContainsKey(s[right]) &&
                    lastSeen[s[right]] >= left)
                    left = lastSeen[s[right]] + 1;

                lastSeen[s[right]] = right;

                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}