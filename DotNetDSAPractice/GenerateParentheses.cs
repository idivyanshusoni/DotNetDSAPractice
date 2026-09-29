//https://github.com/idivyanshusoni

public class GenerateParentheses
{
    public List<string> Perform(int n)
    {
        List<string> result = new List<string>();
        BackTrack("", 0, 0, n, result);
        return result;
    }

    private void BackTrack(string current, int open, int close, int n, List<string> result)
    {
        Console.WriteLine("current = " + current + ", open = " + open + ", close = " + close + ", n = " + n);
        if (current.Length == 2 * n)
        {
            result.Add(current);
            return;
        }
        if (open < n) //n = 3
            BackTrack(current + "(", open + 1, close, n, result);
        if (close < open)
            BackTrack(current + ")", open, close + 1, n, result);
    }
}