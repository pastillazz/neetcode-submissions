public class Solution {
      public List<List<string>> GroupAnagrams(string[] strs)
    {
        Dictionary <string, List<string>> dict = new();
        
        foreach (var s in strs)
        {    
            char[] chars= s.ToCharArray();
            Array.Sort(chars);
            string order=new string(chars);
            
            if (!dict.ContainsKey(order))
            {
                List<string> list = new();
                list.Add(s);
                dict.Add(order, list);
            }
            else
            {
               var list = dict[order];
               list.Add(s);
            }
        } 
        var lista=dict.Values.ToList();
        return lista;
    }
}
