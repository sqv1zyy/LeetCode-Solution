public class Solution
{
    public bool IsValid(string s)
    {
        var r = new Stack<char>();

        foreach (char c in s)
        {
            switch (c)
            {
                case '(':
                case '[':
                case '{':
                    r.Push(c);
                    break;

                case ')':
                    if (r.Count == 0 || r.Pop() != '(')
                    {
                        return false;
                    }
                    break;

                case ']':
                    if (r.Count == 0 || r.Pop() != '[')
                    {
                        return false;
                    }
                    break;

                case '}':
                    if (r.Count == 0 || r.Pop() != '{')
                    {
                        return false;
                    }
                    break;
            }
        }
        return r.Count == 0;
    }
}