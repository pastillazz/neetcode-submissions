public class Solution {
        public int[] TwoSum(int[] numbers, int target) {
        
        int j=numbers.Length;
        
        int k = 1;
        int g = 0;
        int[] result = new int[2];
        for (int i = 0; i < numbers.Length; i++)
        {  
            int sum=numbers[g] + numbers[j-k];

            if (sum>target)
            {
                k++;
            }
            
            if(sum < target)
            {
                g++;
            }
            
            if (sum == target)
            {
                result[0] = g+1;
                result[1] = j-k+1;
            }
            
        }
        return result;
    }
}
