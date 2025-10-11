public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length < 2)
        {
            return nums.Length;
        }

        nums = nums.Distinct().ToArray();
        Array.Sort(nums);

        var sequenceLength = 1;
        var tmpSequenceLength = 1;

        var currentPointer = 0;
        var nextPointer = 1;

        while (nextPointer < nums.Length)
        {
            if ((nums[nextPointer] - nums[currentPointer]) == 1)
            {
                tmpSequenceLength++;
            }
            else
            {
                if (tmpSequenceLength > sequenceLength)
                {
                    sequenceLength = tmpSequenceLength;
                }
                tmpSequenceLength = 1;
            }

            currentPointer++;
            nextPointer++;
        }

        if (tmpSequenceLength > sequenceLength)
        {
            sequenceLength = tmpSequenceLength;
        }

        return sequenceLength;
    }
}
