public class Solution {
      public int FindMin(int[] nums) 
    {
        int left = 0;
        int right = nums.Length - 1;
        int min = int.MaxValue;
        while (left<=right)
        {
            int index = (left + right) / 2;
            
          
            if (nums[index]>nums[right]) left = index+1;
            if (nums[index] <=nums[right])
            {
                right = index-1;
                min=Math.Min(min, nums[index]);
            }
         
        }
        return min;
    }
}
