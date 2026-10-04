public class Solution {
     public int[] TwoSum(int[] nums, int target)
 {
     for(int i = 0; i < nums.Length; i++)
     {
         for(int k = i + 1; k < nums.Length; k++)
         {
             var result = nums[i] + nums[k];
             if (result == target)
             {
                 return new int[] { i, k };
             }
         }
     }
     return new int[0];
 }
}