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