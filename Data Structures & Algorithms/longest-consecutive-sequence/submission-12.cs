public class Solution {
     public int LongestConsecutive(int[] nums)
    {   HashSet<int> set = new(nums);
        List<int> list = new(set);
        list.Sort();
        
        int acum = 1;
        if (list.Count == 0)
        {
            return 0;
        }
        if (list.Count == 1)
        {
            return acum;
        }

        int result = 1;
        for (int i = 0; i < list.Count; i++)
        {
           
            int next=list[i]+1;
            if (set.Contains(next))
            {   
                acum++;
                if (acum > result)
                {
                    result=acum;
                }
                
            }
            else
            {
                acum = 1;
            }
          
        }
        
        return result;
    }
}
