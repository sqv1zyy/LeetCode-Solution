public class Solution
{
    public bool IsPalindrome(string s)
    {
        var sb = new StringBuilder();
        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                sb.Append(char.ToLower(c));
            }
        }

        var str = sb.ToString();
        char[] str_reversed = str.ToCharArray();
        Array.Reverse(str_reversed);
        string str_reversed1 = new string(str_reversed);
        for (int i = 0; i < str_reversed1.Length; i++)
        {
            if (str[i] != str_reversed1[i])
            {
                return false;
            }
        }
        return true;
    }
}