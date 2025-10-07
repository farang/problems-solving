public class Solution {
    public string Encode(IList<string> strs) {
        var encoded = "";

        for (var i = 0; i < strs.Count; i++) {
            encoded += $"{strs[i].Length}#{strs[i]}";
        }

        return encoded;
    }

    public List<string> Decode(string s) {
        var decoded = new List<string>();

        if (s.Length == 0) {
            return decoded;
        }

        string lengthStr = "0";
        int? length = null;
        string toPush = "";

        for (var i = 0; i < s.Length; i++) {
            if (s[i] == '#' && length == null) {
                length = int.Parse(lengthStr);
                lengthStr = "0";
                toPush = "";
                continue;
            }
            
            if (length is null) {
                lengthStr += s[i];
                continue;
            } else if (length == 0) {
                decoded.Add(toPush);
                length = null;
                lengthStr += s[i];
                continue;
            } else if (length > 0) {
                toPush += s[i];
                length -= 1;
                continue;
            }
        }
        decoded.Add(toPush);
        return decoded;
    }
}
