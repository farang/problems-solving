// started solution but did not finish
public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        var groupedNums = new List<(int index, int value)>();

        for (var i = 0; i < nums.Length; i++)
        {
            groupedNums.Add((i, nums[i]));
        }
        groupedNums = groupedNums.OrderBy(n => n.value).ToList();

        var result = new List<List<int>>();
        for (var i = 0; i < nums.Length - 3; i++)
        {
            if ((groupedNums[i].value + groupedNums[i + 1].value + groupedNums[i + 2].value) == 0)
            {
                result.Add(new List<int> { groupedNums[i].value, groupedNums[i + 1].value, groupedNums[i + 2].value });
            }
        }

        return result;
    }
}

// efficient solution
public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var result = new List<List<int>>();

        for (var i = 0; i < nums.Length; i++) {
            var lPointer = i + 1;
            var rPointer = nums.Length - 1;

            if (i > 0 && nums[i] == nums[i - 1]) continue;

            while (lPointer < rPointer) {
                var sum = nums[i] + nums[lPointer] + nums[rPointer];
                if (sum > 0) {
                    rPointer--;
                } else if (sum < 0) {
                    lPointer++;
                } else {
                    result.Add(new List<int> { nums[i], nums[lPointer], nums[rPointer] });
                    lPointer++;
                    rPointer--;
                    while (lPointer < rPointer && nums[lPointer] == nums[lPointer - 1]) {
                        lPointer++;
                    }
                }
            }
        }

        return result;
    }
}
