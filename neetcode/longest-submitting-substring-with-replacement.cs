// own solution
public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int result = 0;

        if (s.Length == 1)
        {
            return result;
        }

        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (stack.Count > 0 && (stack.Peek() != s[i] || s.Length - 1 == i))
            {
                // while
                int l = i;
                int rpl = k;
                while (l < s.Length && (rpl > 0 || s[l] == stack.Peek()))
                {
                    if (s[l] != stack.Peek())
                    {
                        rpl--;
                    }
                    stack.Push(stack.Peek());
                    l++;
                }
                if (rpl > 0)
                {
                    int r = l - stack.Count - 1;
                    while (r >= 0 && (rpl > 0 || s[r] == stack.Peek()))
                    {
                        if (s[r] != stack.Peek())
                        {
                            rpl--;
                        }
                        stack.Push(stack.Peek());
                        r--;
                    }
                }
                result = Math.Max(stack.Count, result);
                stack.Clear();
            }

            stack.Push(s[i]);
            result = Math.Max(stack.Count, result);
        }

        return result;
    }
}
