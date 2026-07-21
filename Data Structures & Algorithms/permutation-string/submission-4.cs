public class Solution {
       public bool CheckInclusion(string s1, string s2)
    {
        Dictionary<char, int> charsCount = new();
        if (s1.Length>s2.Length) return false;

        for ( int i=0;i < s1.Length; i++)
        {
            if (!charsCount.ContainsKey(s1[i])) charsCount.TryAdd(s1[i], 1);
            
            else charsCount[s1[i]]++;
        } 
        
        
        int left = 0;
        int matches = 0;
        for (int right = 0; right < s2.Length; right++)
        {
            if (charsCount.ContainsKey(s2[right]))
            {  
                charsCount[s2[right]]--;
                if (charsCount[s2[right]]==0) matches++;
            }
                
            
            if (right-left+1>s1.Length)
            {
                if (charsCount.ContainsKey(s2[left]))
                {
                    if (charsCount[s2[left]]==0) matches--;
                    charsCount[s2[left]]++;
                }
               
                left++;
            } if (matches==charsCount.Count) return true;
        }

        return false;
    }
}
