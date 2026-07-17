public class Solution {
      public List<List<int>> ThreeSum(int[] nums)
    {
        List<List<int>> result = new  List<List<int>>();  
        
        int tam=nums.Length;
        Array.Sort(nums);
        int target = 0; 
        for (int i = 0; i < nums.Length-2; i++)
        {
            int k= 1;
            if (i==0 || nums[i] != nums[i-1])
            {  
                for (int g=i+1; g<tam-k;)
                {
                    if (g==i+1 || nums[g] != nums[g-1])
                    {
                        int num1=nums[g];
                        int num2=nums[tam-k];
                        int sum=nums[i]+num1+num2;
                   
                        if (sum>target)
                        {
                            k++;
                        
                        }
                   
                        if (sum<target)
                        {
                            g++;
                        }
                   
                        if (sum==target)
                        {
                            List<int> list = new List<int>();
                            list.Add(nums[i]);
                            list.Add(num1);
                            list.Add(num2);
                            result.Add(list);
                            g++;
                            k++;
                        
                        }
                    }
                    else
                    {
                        g++;
                    }
                   
                }
            }
            
        }
        return result;
    }
}
