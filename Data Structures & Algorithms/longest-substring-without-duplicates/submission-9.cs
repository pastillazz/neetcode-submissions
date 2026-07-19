public class Solution {
          public int LengthOfLongestSubstring(string s)
    {
        Dictionary<char,int> chars = new();
        int right = 0;
        int left = 0;
        int counter = 0;
        int count = 0;
        while (right < s.Length)
        {   
            char c = s[right];
            
            if (chars.ContainsKey(c))
            {  //dvdf //"pwwkewgh"
                var p=chars[c];
                if (left <= p) left = p + 1;
                chars[c] = right;
            }
            
            else chars.Add(c, right);
            count=right - left+1;
            counter=Math.Max(count,counter);
            right++;
            
        }
        
        return counter;
    }
 
}
