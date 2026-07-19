public class Solution {
        public int LengthOfLongestSubstring(string s)
    {
        Dictionary<char,int> chars = new();
        int right = 0;
        int left = 0;
        int count = 0;
        int counter = 0;
        while (right<s.Length)
        {   
            int position=right+1;
            char c = s[right];
            
            if (chars.ContainsKey(c))
            {  
                var p=chars[c];
                char z = s[p];
                chars.Clear();
                chars.Add(z,p+1);
                right = p;

            }
            else
            { 
                chars.Add(c,position);
            } 
            
            counter=Math.Max(chars.Count,counter);
            right++;
            
        }
        
        return counter;
    }
}
