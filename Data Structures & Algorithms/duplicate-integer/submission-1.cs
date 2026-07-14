public class Solution {
       public bool hasDuplicate(int[] nums) {
        List<int> numsList=new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (numsList.Contains(nums[i]))
            {
                return true;
            }
            numsList.Add(nums[i]);
        }

        return false;
    }
}
