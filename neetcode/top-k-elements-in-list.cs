public class Solution1
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var map = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            if (!map.ContainsKey(n))
            {
                map[n] = 1;
            }
            else
            {
                map[n] += 1;
            }
        }

        var sortedValues = map
        .OrderBy(m => m.Value)
        .Select(m => m.Key)
        .ToArray();

        return sortedValues[^k..];
    }
}

public class Solution2 {
    public int[] TopKFrequent(int[] nums, int k) {
        var count = new Dictionary<int, int>();
        foreach (var n in nums) {
            if (!count.ContainsKey(n)) {
                count[n] = 1;
                continue;
            }
            count[n] += 1;
        }
        var groups = new List<int>[nums.Length + 1];
        foreach ((int n, int c) in count) {
            if (groups[c] is null) {
                groups[c] = new List<int> { n };
                continue;
            }
            groups[c].Add(n);
        }
        var result = new List<int>();
        for (var i = nums.Length; i >= 0; i--) {
            if (groups[i] is null) {
                continue;
            }
            foreach (var n in groups[i]) {
                result.Add(n);
                if (result.Count == k) {
                    return result.ToArray();
                }
            }
        }
        return result.ToArray();
    }
}
