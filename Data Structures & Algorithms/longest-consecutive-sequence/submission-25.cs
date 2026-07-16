public class Solution {
     public int LongestConsecutive(int[] nums)
    {   HashSet<int> set = new(nums);
        
        
        if (nums.Length == 0) return 0;
        
        int result = 1;
        foreach (var num in set)
        {
            int prev=num-1;
            if (!set.Contains(prev))
            {
                int numero = num;
                int acum = 1;

                while (set.Contains(numero+1))
                {
                    acum++;
                    numero++;
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
