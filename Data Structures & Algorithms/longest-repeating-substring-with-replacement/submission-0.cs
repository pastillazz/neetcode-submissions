public class Solution {
       public int CharacterReplacement(string s, int k) {
        

        int left = 0;
        int right = 0;
        int count = 0;
        int counter = 0;
        int result=0;
        Dictionary<char, int>  replacements = new();

        while (right < s.Length)
        {
            if (replacements.ContainsKey(s[right]))
            {   
                replacements[s[right]]++;
            }
            else replacements.Add(s[right], 1);
            
            counter=Math.Max(replacements[s[right]],counter);
            count = right -left- counter+1;

            if (count > k)
            {   
                replacements[s[left]]--;
                left ++;
            }
            result = Math.Max(right-left+1,result);
            right++;
        }

        return result;
    }
}
