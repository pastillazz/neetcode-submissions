public class Solution {
       public string MinWindow(string s, string t)
    {
        Dictionary<char, int> chars = new();
        
        foreach (var c in t)
        {
            if (chars.ContainsKey(c)) chars[c]++;
            else chars.Add(c, 1);
        }

        int left = 0;
        int matches = 0;
        int LeftMax = 0;
        int best = -1;
        int minWin = 10000;
        for (int i = 0; i < s.Length; i++)
        {
            if (chars.ContainsKey(s[i]))
            {   chars[s[i]]--; 
                if (chars[s[i]]==0) matches++;
                
            }

            while (matches == chars.Count)
            {
                if (chars.ContainsKey(s[left]))
                {
                    chars[s[left]]++; 
                    if (chars[s[left]] > 0) matches--;
                }

                int currentWin = i - left + 1;
                if (currentWin<minWin)
                {
                    minWin = currentWin;
                    LeftMax = left;
                }
                best = 1;
                left++;

            }

        }

        if (best==-1)
        {
            return "";
        }
        
        return s.Substring(LeftMax, minWin);
    }
}
