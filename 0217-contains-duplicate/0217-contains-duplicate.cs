public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var dictonary = new Dictionary<int, int>();
foreach (int num in nums)
{
    if (!dictonary.ContainsKey(num))
    {
        dictonary.Add(num, 1);
    }
    else
    {
        return true;
    }
    
}
return false;
    }
}