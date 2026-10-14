public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        Array.Sort(nums);
        var bestLengt = 1;
        var currentLenght = 1;
        if (nums.Length == 0 || nums == null)
        {
            return 0;
        }
        for (int i = 0; i < nums.Length - 1; i++)
        {

            if (nums[i] == nums[i + 1])
            {
                continue;
            }

            if (nums[i] + 1 == nums[i + 1])
            {
                currentLenght++;
            }
            else
            {
                bestLengt = Math.Max(bestLengt, currentLenght);
                currentLenght = 1;
            }
            
        }
        return Math.Max(bestLengt, currentLenght);
    }
}