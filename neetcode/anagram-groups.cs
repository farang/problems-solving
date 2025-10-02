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

// efficient solution
public class Solution2
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var finalResult = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            int[] strCount = new int[26];
            foreach (char chr in str)
            {
                strCount[chr - 'a'] += 1;
            }
            var key = string.Join(',', strCount);
            if (finalResult.ContainsKey(key))
            {
                finalResult[key].Add(str);
                continue;
            }
            finalResult[key] = new List<string> { str };
        }

        return finalResult.Values.ToList<List<string>>();
    }
}
