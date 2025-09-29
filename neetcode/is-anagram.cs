public class Solution {
    public bool IsAnagram(string s, string t) {
        var length = s.Length;
        var mapS = new Dictionary<char, int>();
        var mapT = new Dictionary<char, int>();

        if (length != t.Length) {
            return false;
        }

        for (var i = 0; i < length; i++) {
            if (mapS.TryGetValue(s[i], out var vS)) {
                mapS[s[i]] = vS + 1;
            } else {
                mapS.Add(s[i], 1);
            }

            if (mapT.TryGetValue(t[i], out var vT)) {
                mapT[t[i]] = vT + 1;
            } else {
                mapT.Add(t[i], 1);
            }
        }

        foreach ((char key, int value) in mapS) {
            if (!mapT.TryGetValue(key, out var _) || value != mapT[key]) {
                return false;
            }
        }

        return true;
    }
}
