// unfinished, bad solution
public class Solution1
{
    const char startDevider = '[';
    const char endDevider = ']';

    public string Encode(IList<string> strs)
    {
        var encoded = "";

        foreach (var str in strs)
        {
            encoded += $"{startDevider}{str.Length}{endDevider}{str}";
        }

        return encoded;
    }

    public List<string> Decode(string s)
    {
        var devideStarted = false;
        var devideEnded = false;
        string requiredStringN = "";
        int? requiredN = null;
        var result = new List<string>();
        var stringToPush = "";

        for (var i = 0; i < s.Length; i++)
        {
            if (devideStarted && !devideEnded)
            {
                requiredStringN += s[i];
                continue;
            }
            if (devideStarted && s[i] == endDevider)
            {
                devideEnded = true;
                requiredN = int.Parse(requiredStringN);
                requiredStringN = "";
                continue;
            }
            if (s[i] == startDevider)
            {
                devideStarted = true;
                continue;
            }
            if (requiredN is not null && requiredN > 0)
            {
                stringToPush += s[i];
                requiredN -= 1;
            }
            if (requiredN == 0)
            {
                result.Add(stringToPush);
                stringToPush = "";
                devideStarted = false;
                devideEnded = false;
                requiredN = null;
                continue;
            }
        }
        return result;
    }
}

// good solution
public class Solution2
{
    const char JoinElement = '#';
    public string Encode(IList<string> strs)
    {
        var encoded = "";

        for (var i = 0; i < strs.Count; i++)
        {
            encoded += $"{strs[i].Length}{JoinElement}{strs[i]}";
        }

        return encoded;
    }

    public List<string> Decode(string s)
    {
        var decoded = new List<string>();

        if (s.Length == 0)
        {
            return decoded;
        }

        string lengthStr = "0";
        int? length = null;
        string toPush = "";
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == JoinElement)
            {
                length = int.Parse(lengthStr);
                lengthStr = "0";
                toPush = "";
                continue;
            }

            if (length is null)
            {
                lengthStr += s[i];
                continue;
            }
            else if (length == 0)
            {
                decoded.Add(toPush);
                length = null;
                continue;
            }
            else if (length > 0)
            {
                toPush += s[i];
                length -= 1;
                continue;
            }
        }
        return decoded;
    }
}
