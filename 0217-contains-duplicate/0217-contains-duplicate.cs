public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var results = new HashSet<int>();
        foreach (int num in nums)
        {
            if (!results.Add(num))
            {
                return true;
            }

            
        }
        return false;
    }
}
