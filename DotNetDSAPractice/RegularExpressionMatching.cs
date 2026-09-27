//https://github.com/idivyanshusoni

public class RegularExpressionMatching
{
    public bool Perform(string s, string p)
    {
        int m = s.Length;
        int n = p.Length;

        bool[,] dp = new bool[m + 1, n + 1];

        dp[0, 0] = true;

        for (int j = 2; j <= n; j++)
        {
            if (p[j - 1] == '*') dp[0, j] = dp[0, j - 2];
        }

        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                char currentStringChar = s[i - 1];
                char currentPatternChar = p[j - 1];

                if (currentPatternChar == '.' || currentPatternChar == currentStringChar)
                    dp[i, j] = dp[i - 1, j - 1];

                else if (currentPatternChar == '*')
                {
                    dp[i, j] = dp[i, j - 2];

                    char previousPatternChar = p[j - 2];

                    if (previousPatternChar == '.' || previousPatternChar == currentStringChar)
                        dp[i, j] = dp[i, j] || dp[i - 1, j];
                }
            }
        }

        return dp[m, n];
    }
}