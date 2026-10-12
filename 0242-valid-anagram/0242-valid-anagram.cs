public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        var res_dict = new Dictionary<char, int>();

        if (s.Length != t.Length)
        {
            return false;
        }
        for (int i = 0; i < t.Length; i++)
        {
            res_dict[t[i]] = res_dict.GetValueOrDefault(t[i], 0) + 1;
            res_dict[s[i]] = res_dict.GetValueOrDefault(s[i], 0) - 1;
        }

        foreach (char values in res_dict.Values)
        {
            if (values != 0)
            {
                return false;
            }
        }
        return true;
    }
}