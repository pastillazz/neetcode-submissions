public class Solution {
     public int LongestConsecutive(int[] nums)
    {   HashSet<int> set = new(nums);
        
        
        if (nums.Length == 0) return 0;
        
        int result = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            int prev=nums[i]-1;
            if (!set.Contains(prev))
            {
                int num = nums[i];
                int acum = 1;

                while (set.Contains(num+1))
                {
                    acum++;
                    num++;
                }

                if (acum > result)
                {
                    result = acum;
                }
            }
    
        }
        
        return result;
        
    }
}
