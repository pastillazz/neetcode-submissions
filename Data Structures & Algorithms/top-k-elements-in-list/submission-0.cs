public class Solution {
  public int[] TopKFrequent(int[] nums, int k) 
    {   
        Dictionary<int, int> dict = new ();

        List<int> result = new();
        
        foreach (var num in nums)
        {
            if (!dict.ContainsKey(num))
            {
                dict.Add(num, 1);
            }
            else
            {
              dict[num]++;
            }
        }
        
        
        var list=dict.OrderByDescending(x=>x.Value).ToList();

        foreach (var num in list)
        {
            result.Add(num.Key);
        }
        int[] response =result.ToArray();
        int [] resp=response[..k];
        return resp;
    }
}
