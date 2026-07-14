public class Solution {
         public bool hasDuplicate(int[] nums) {
        
        HashSet<int> numsSet=new();
        
        foreach (var num in nums)
        {
            if (numsSet.Contains(num))
            {
               return true; 
            }
            numsSet.Add(num);
            
        } return false;
    }
}
