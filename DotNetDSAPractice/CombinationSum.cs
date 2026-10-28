//https://github.com/idivyanshusoni
public class CombinationSum
{
    public IList<IList<int>> Perform(int[] candidates, int target)
    {
        var result = new List<IList<int>>();

        var current = new List<int>();

        BackTrack(candidates, target, 0, current, result);

        return result;
    }

    public void BackTrack(int[] candidates, int remaining, int startIndex, List<int> current, IList<IList<int>> result)
    {
        if (remaining == 0)
        {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = startIndex; i < candidates.Length; i++)
        {
            int candidate = candidates[i];

            if (candidate > remaining)
                continue;

            current.Add(candidate);

            BackTrack(candidates, remaining - candidate, i, current, result);

            current.RemoveAt(current.Count - 1);
        }
    }
}