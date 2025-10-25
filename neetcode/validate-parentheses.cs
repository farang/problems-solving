// unfinished
public class Solution
{
    public static Dictionary<char, char> BracketsMap = new Dictionary<char, char>
    {
        ['['] = ']',
        ['('] = ')',
        ['{'] = '}'
    };

    public bool IsValid(string s)
    {
        var end = Math.Floor((decimal)(s.Length / 2));
        var start = 0;

        if (s.Length < 2)
        {
            return false;
        }

        while (start < end)
        {
            if (BracketsMap[s[start]] != s[(s.Length - 1) - start])
            {
                return false;
            }
            start++;
        }

        return true;
    }
}
