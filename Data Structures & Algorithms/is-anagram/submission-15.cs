
public class Solution {
      public bool IsAnagram(string s, string t) 
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        
        char[] sChars = s.ToCharArray();
        char[] tChars = t.ToCharArray();
        
        Array.Sort(sChars);
        Array.Sort(tChars);
        
        string orderStringS=new string(sChars);
        string orderStringT=new string(tChars);
        if (orderStringS != orderStringT)
        {
            return false;
        }

    return true;
    }
}
