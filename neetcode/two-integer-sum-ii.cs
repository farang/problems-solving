// non-efficient solution
public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        for (var i = 0; i < numbers.Length; i++)
        {
            for (var i1 = 0; i1 < i; i1++)
            {
                if ((numbers[i] + numbers[i1]) == target)
                {
                    return new int[2] { i1 + 1, i + 1 };
                }
            }
            for (var i1 = i + 1; i1 < numbers.Length; i1++)
            {
                if ((numbers[i] + numbers[i1]) == target)
                {
                    return new int[2] { i + 1, i1 + 1 };
                }
            }
        }

        return new int[2] { 0, 1 };
    }
}