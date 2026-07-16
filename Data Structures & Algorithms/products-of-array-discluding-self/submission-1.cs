public class Solution {
       public int[] ProductExceptSelf(int[] nums)
    {
        int prefix = 1;
        int suffix = 1;
        int[] result = new int[nums.Length];
        int tam=nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            
            if (i != 0)
            { 
                prefix *= nums[i-1];
                result[i] = prefix;
            }
            else
            {
                result[i] = prefix;
            }
            
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (tam-i==tam)
            {
                result[tam-i-1]*=suffix;
            }
            else
            {
                suffix *= nums[tam-i];
                result[tam-i-1]*=suffix;
            }
        }
        
        return result;
    }
}
