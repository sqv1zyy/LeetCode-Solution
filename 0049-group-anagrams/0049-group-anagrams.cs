public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var result = new Dictionary<string, List<string>>();
        foreach (string s  in strs)
        {
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            var key = new string(charArray);
            if (!result.ContainsKey(key))
            {
                result[key] = new List<string>();
            }
            result[key].Add(s);
        }
        return new List<IList<string>>(result.Values);
    }
}