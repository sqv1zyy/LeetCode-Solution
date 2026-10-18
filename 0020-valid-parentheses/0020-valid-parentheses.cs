public class Solution
{
    public bool IsValid(string s)
    {
        var dict = new Dictionary<char, char>
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };
        var r = new Stack<char>();

        foreach (char c in s)
        {
            if (dict.ContainsKey(c))
            {
                if (r.Count == 0 || r.Pop() != dict[c])
                {
                    return false;
                }
            }
            else
            {
                r.Push(c);
            }
            
        } 
        return r.Count == 0;
    }
}