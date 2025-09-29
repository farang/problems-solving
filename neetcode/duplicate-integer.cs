public class Solution {
    public bool hasDuplicate(int[] nums) {
        var dict = new Dictionary<int, bool>();
        for (var i = 0; i < nums.Count(); i++) {
            if (dict.TryGetValue(nums[i], out var v)) {
                return true;
            }
            dict.Add(nums[i], true);
        }
        return false;
    }
}