public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        int prefix = 1;
        int suffix = 1;
        int[] result = new int[nums.Length];
        List<int> resultSuffix = new();
        List<int> resultPrefix = new();
        int tam=nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            
            if (i != 0)
            { 
                prefix *= nums[i-1];
                resultPrefix.Add(prefix);
            }
            else
            {
                resultPrefix.Add(prefix);
            }

            if (tam-i==tam)
            {
                resultSuffix.Add(suffix);
            }
            else
            {
                suffix *= nums[tam-i];
                resultSuffix.Add(suffix);
            }
            
        }
        resultSuffix.Reverse();

        for (int i = 0; i < nums.Length; i++)
        {
           result[i]=resultSuffix[i]*resultPrefix[i]; 
        }
        
        return result;
    }
}
