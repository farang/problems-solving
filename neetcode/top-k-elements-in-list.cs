public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var map = new Dictionary<int, int>();

        foreach (var n in nums) {
            if (!map.ContainsKey(n)) {
                map[n] = 1;
            } else {
                map[n] += 1;
            }
        }

        var sortedValues = map.OrderBy(m => m.Value).Select(m => m.Key).ToArray();

        return sortedValues[^k..];
    }
}