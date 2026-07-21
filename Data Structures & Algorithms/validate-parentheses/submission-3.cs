public class Solution {
       public bool IsValid(string s)
    {
        Stack<char> stack = new();
        
        
        foreach (var c in s)
        {
            if (stack.Count == 0 && (c == '}' || c == ']' || c == ')')) return false;
            
            if (c =='{' || c=='[' || c=='(') stack.Push(c);
            
            else
            {
                var charsi = stack.Pop();
                if (charsi == '{' && c == '}') ;
                else if (charsi == '[' && c == ']') ; 
                else if (charsi == '(' && c == ')') ;
                else return false;
            }
        }

        if (stack.Count == 0) return true;
        return false;
    }
}
