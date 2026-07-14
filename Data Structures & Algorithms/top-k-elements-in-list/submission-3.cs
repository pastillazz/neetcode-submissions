public class Solution {

  
    public int [] TopKFrequent(int[] nums, int k) 
    {   
        Dictionary<int, int> dict = new ();
        
        Dictionary<int, List<int>> sub = new ();
        
        Dictionary<int, List<int>> dict2 = new ();
        
        List<int> list = new();  
        HashSet<int> frecuenciasProcesadas = new();
        
        
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

        foreach (var num in dict.Keys)
        {
            var variable = dict[num];
            
            if (!dict2.ContainsKey(variable))
            {   
                List<int> list2 = new();
                list2.Add(num);
                dict2.Add(variable, list2);
            }
            else
            {
               dict2[variable].Add(num);
            }
        }
        
        int[] result = new int[dict.Count];
        int j = 0;


        foreach (var par in dict)
        {
            result[j] = par.Value;
            j++;
        }
        
        Array.Sort(result);
        
        Array.Reverse(result);
        
        var cut = result.Take(k).ToArray();
      
        for (int i = 0; i < cut.Length; i++)
        {
            int frecuenciaActual = cut[i];
          
            
            if (!frecuenciasProcesadas.Contains(frecuenciaActual))
            {
                var nums2 = dict2[frecuenciaActual];
                frecuenciasProcesadas.Add(frecuenciaActual);
                sub.Add(i, nums2);
            }
          
          
        }

        foreach (var lista in sub.Values)
        {
            list.AddRange(lista);
        }
        return list.ToArray();
    }
}
