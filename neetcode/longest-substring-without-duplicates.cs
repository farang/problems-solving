// first attempt
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var result = 0;
        var tmpResult = "";

        for (var i = 0; i < s.Length; i++)
        {
            var toAssign = tmpResult;
            if (tmpResult.IndexOf(s[i]) == -1)
            {
                tmpResult += s[i];
                toAssign = tmpResult;
            }
            else
            {
                i = i - tmpResult.Length;
                tmpResult = "";
            }

            result = toAssign.Length > result ? toAssign.Length : result;
        }

        return result;
    }
}
