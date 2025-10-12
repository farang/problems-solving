public class Solution {
    public bool IsPalindrome(string s) {
        var halfLength = (int)Math.Floor((double)s.Length / 2);
        var forwardPointer = 0;
        var backwardsPointer = s.Length - 1;

        while (forwardPointer <= halfLength) {
            if (!char.IsLetter(s[forwardPointer]) && !char.IsNumber(s[forwardPointer])) {
                forwardPointer++;
                continue;
            }
            if (!char.IsLetter(s[backwardsPointer]) && !char.IsNumber(s[backwardsPointer])) {
                backwardsPointer--;
                continue;
            }
            if (char.ToLowerInvariant(s[forwardPointer]) != char.ToLowerInvariant(s[backwardsPointer])) {
                return false;
            }

            forwardPointer++;
            backwardsPointer--;
        }

        return true;
    }
}
