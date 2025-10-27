// own solution
public class Solution {
    public static Dictionary<char, char>  BracketsMap = new Dictionary<char, char> {
        ['['] = ']',
        ['('] = ')',
        ['{'] = '}'
    };

    public bool IsValid(string s) {
        var toClose = -1;
        var openBrackets = "";

        if (s.Length < 2) {
            return false;
        }

        for (var i = 0; i < s.Length; i++) {
            if (BracketsMap.ContainsKey(s[i])) {
                openBrackets += s[i];
                toClose++;
                continue;
            }
            if (toClose < 0 || s[i] != BracketsMap[openBrackets[toClose]]) {
              return false;   
            }
            toClose -= 1;
            openBrackets = toClose == -1 ? "" : openBrackets;
        }

        return toClose == -1;
    }
}

// Stack solution
public class Solution {
    public static Dictionary<char, char> BracketsMap = new Dictionary<char, char> {
        ['['] = ']',
        ['('] = ')',
        ['{'] = '}'
    };

    public bool IsValid(string s) {
        var openBrackets = new Stack<char>();

        for (var i = 0; i < s.Length; i++) {
            if (BracketsMap.ContainsKey(s[i])) {
                openBrackets.Push(s[i]);
                continue;
            }
           if (openBrackets.Count == 0 || s[i] != BracketsMap[openBrackets.Pop()]) {
                return false;
           }
        }

        return openBrackets.Count == 0;
    }
}
