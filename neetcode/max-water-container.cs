// not optimal solution
public class Solution
{
    public int MaxArea(int[] heights)
    {
        var result = 0;
        if (heights.Length == 2)
        {
            return Math.Min(heights[0], heights[1]) * 1;
        }
        for (var i = 0; i < heights.Length - 2; i++)
        {
            var l = i + 1;
            var r = heights.Length - 1;

            while (l < r)
            {
                var minL = Math.Min(heights[l], heights[i]);
                var minR = Math.Min(heights[r], heights[i]);
                var size = Math.Max(minL * (l - i), minR * (r - i));
                result = result > size ? result : size;
                l++;
                r--;
            }
        }

        return result;
    }
}

// good solution
public class Solution {
    public int MaxArea(int[] heights) {
        int result = 0;
        int l = 0, r = heights.Length - 1;

        while (l < r) {
            int currentArea = Math.Min(heights[l], heights[r]) * (r - l);
            result = Math.Max(result, currentArea);
            if (heights[l] <= heights[r]) {
                l++;
            } else {
                r--;
            }
        }

        return result;
    }
}