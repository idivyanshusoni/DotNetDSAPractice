//https://github.com/idivyanshusoni

public class LongestPalindromicSubstring
{
    public string Perform(string s)
    {
        if (string.IsNullOrEmpty(s))
            return "";

        int start = 0;
        int maxLength = 1;

        for (int i = 0; i < s.Length; i++)
        {
            int oddLength = ExpandAroundCenter(s, i, i);
            int evenLength = ExpandAroundCenter(s, i, i + 1);

            int currentLength = Math.Max(oddLength, evenLength);

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                start = i - (currentLength - 1) / 2;
            }
        }

        return s.Substring(start, maxLength);
    }

    private int ExpandAroundCenter(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        { left--; right++; }

        return right - left - 1;
    }
}