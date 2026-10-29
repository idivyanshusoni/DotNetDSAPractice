//https://github.com/idivyanshusoni

public class CombinationSum2
{
    public IList<IList<int>> Perform(int[] candidates, int target)
    {
        var result = new List<IList<int>>();

        Array.Sort(candidates);

        List<int> current = new List<int>();

        BackTrack(candidates, target, 0, current, result);

        return result;
    }

    private void BackTrack(int[] candidates, int remaining, int startIndex, List<int> current, List<IList<int>> result)
    {
        if (remaining == 0)
        {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = startIndex; i < candidates.Length; i++)
        {
            if (i > startIndex && candidates[i] == candidates[i - 1])
                continue;

            if (candidates[i] > remaining)
                break;

            current.Add(candidates[i]);

            BackTrack(candidates, remaining - candidates[i], i + 1, current, result);

            current.RemoveAt(current.Count - 1);
        }
    }
}