//https://github.com/idivyanshusoni

using System.Text;

public class LetterCombinationsOfAPhoneNumber
{
    public IList<string> Perform(string digits)
    {
        List<string> result = new List<string>();

        if (string.IsNullOrEmpty(digits))
        {
            return result;
        }

        string[] phone = { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

        StringBuilder current = new StringBuilder();

        BackTrack(digits, 0, current, result, phone);

        return result;
    }

    private void BackTrack(string digits, int index, StringBuilder current, List<string> result, string[] phone)
    {
        if (index == digits.Length)
        {
            result.Add(current.ToString());
            return;
        }

        int digit = digits[index] - '0';

        string letters = phone[digit];

        foreach (char letter in letters)
        {
            current.Append(letter);
            BackTrack(digits, index + 1, current, result, phone);
            current.Remove(current.Length - 1, 1);
        }
    }
}