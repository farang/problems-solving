public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] res = new int[nums.Length];
        int prefix = 1;
        for (var i = 0; i < nums.Length; i++)
        {
            res[i] = prefix;
            prefix *= nums[i];
        }
        int suffix = 1;
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            res[i] *= suffix;
            suffix *= nums[i];
        }
        return res;
    }
}