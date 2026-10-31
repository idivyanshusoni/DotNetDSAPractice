//https://github.com/idivyanshusoni

using System.Collections.Generic;

public class GroupAnagrams
{
    public IList<IList<string>> Perform(string[] strings)
    {
        var map = new Dictionary<string, List<string>>();

        foreach (var str in strings)
        {
            char[] chars = str.ToCharArray();

            Array.Sort(chars);

            string key = new string(chars);

            if (!map.ContainsKey(key))
                map[key] = new List<string>();

            map[key].Add(str);
        }

        IList<IList<string>> result = new List<IList<string>>();

        foreach (var group in map.Values)
            result.Add(group);

        return result;
    }
}