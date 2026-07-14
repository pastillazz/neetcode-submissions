public class Solution {
     public int[] TwoSum(int[] nums, int target)
    {
        int rest;
        Dictionary<int, int> dict = new(nums.Length);
        int[] result = new int[2];

     
        for (int i = 0; i < nums.Length; i++)
        {   
            rest = target - nums[i];
            if (dict.ContainsKey(rest)&& dict[rest] != i)
            {  
                
               result[0] = dict[rest];
               result[1] = i ;
               return result;
            }

            dict.Add(nums[i], i);
        }

        return null;
    }
}
