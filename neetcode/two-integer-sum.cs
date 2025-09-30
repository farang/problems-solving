public class Solution1 {
    public int[] TwoSum(int[] nums, int target) {
        var result = new int[2]{0,0};
        for (var i = 0; i < nums.Count(); i++) {
            for (var i1 = i + 1; i1 < nums.Count(); i1++) {
                if (i == i1) {
                    continue;
                }

                if ((nums[i] + nums[i1]) == target) {
                    result[0] = i;
                    result[1] = i1;
                    return result;
                }
            }
        }

        return result;
    }
}

public class Solution2
{
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        var result = new int[2] { 0, 0 };
        for (var i = 0; i < nums.Count(); i++)
        {
            var n = nums[i];
            var diff = target - n;
            if (map.ContainsKey(diff))
            {
                result[0] = map[diff];
                result[1] = i;
                return result;
            }
            map.Add(n, i);
        }

        return result;
    }
}
