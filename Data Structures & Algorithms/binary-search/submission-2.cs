public class Solution {
       public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left<=right)
        {
            int index = (left + right)/2;

            if (nums[index]<target) left = index + 1;
            if (nums[index]>target) right = index - 1;
            if (nums[index] == target) return index;
            
        }
        
        return -1;
    }
}
