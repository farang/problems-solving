public class Solution {
    public int BinarySearch(int l, int r, int[] nums, int target) {
        if (l > r) return -1;

        int m = l + (r - l) / 2;
        if (nums[m] == target) return m;

        if (nums[m] > target) {
            return BinarySearch(l, m - 1, nums, target);
        } else {
            return BinarySearch(m + 1, r, nums, target);
        }
    }

    public int Search(int[] nums, int target) {
        return BinarySearch(0, nums.Length - 1, nums, target);
    }
}
