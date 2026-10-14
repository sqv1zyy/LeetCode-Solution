public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var result = new Dictionary<int, int>();
        foreach (var x in nums)
        {
            if (result.ContainsKey(x))
            {
                result[x]++;
            }
            else
            {
                result[x] = 1;
            }
        }
        
        var res = result.OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();
           
        return res;
        
    }
}