//https://github.com/idivyanshusoni

public class MultiplyStrings
{
    public string Perform(string num1, string num2)
    {
        if (num1 == "0" || num2 == "0")
        {
            return "0";
        }

        int m = num1.Length;
        int n = num2.Length;

        int[] result = new int[m + n];

        for (int i = m - 1; i >= 0; i--)
        {
            for (int j = n - 1; j >= 0; j--)
            {
                int digit1 = num1[i] - '0';
                int digit2 = num2[j] - '0';

                int product = digit1 * digit2 + result[i + j + 1];

                result[i + j + 1] = product % 10;

                result[i + j] += product / 10;
            }
        }

        string answer = string.Join("", result);

        answer = answer.TrimStart('0');

        return answer.Length == 0 ? "0" : answer;
    }
}