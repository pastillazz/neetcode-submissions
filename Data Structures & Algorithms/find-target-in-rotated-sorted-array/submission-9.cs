public class Solution {
       public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
        while (left<=right)
        {
            int index=(right +left)/2;
            if (nums[index] == target) return index;
            if (nums[left]<=nums[index])
            {
                if (nums[left] <= target && target <= nums[index]) right = index - 1;
                else left = index + 1;
            }
            
            else if (nums[index]<=nums[right])
            {
                if (nums[index]<=target && target<=nums[right])left=index+1;
                else right = index-1;
            }
            
        }
        return -1;
    }
}
