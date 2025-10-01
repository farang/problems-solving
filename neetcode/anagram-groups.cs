// non-efficient solution
public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var finalResult = new List<List<string>>();
        if (strs.Length == 0)
        {
            return finalResult;
        }
        var map = new Dictionary<string, List<int>>();
        for (var i = 0; i < strs.Length; i++)
        {
            var sortedStr = new string(strs[i].OrderBy(c => c).ToArray());
            if (map.ContainsKey(sortedStr))
            {
                map[sortedStr].Add(i);
            }
            else
            {
                map[sortedStr] = new List<int> { i };
            }
        }

        foreach ((string key, List<int> value) in map)
        {
            finalResult.Add(value.Select(i => strs[i]).ToList());
        }

        return finalResult;
    }
}
