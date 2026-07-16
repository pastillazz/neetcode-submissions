public class Solution {
       public bool IsPalindrome(string s) {
        
        string chain="";
        
        foreach (var c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                chain += char.ToLower(c);
            }
        }
        int j=chain.Length;
        double mid = (double)j/ 2;
        int medium=(int)mid;
        if (mid-medium>=0.5)
        {
            medium =(int) mid+1;
        }

        int k = 1;
        for (int i = 0; i < medium; i++)
        { 
            if (chain[i] != chain[j-k]) return false;
            k++;
        }
        return true;
        
    }
}
