public class Solution {
       public int Trap(int[] height)
    {
        int sum=0;
        int [] prefix =new int [height.Length];
        int [] suffix = new int [height.Length];
        
        for (int i = 0; i < height.Length; i++)
        {
            if (i==0) prefix[i] = 0;
            
            else prefix[i] = Math.Max(height[i - 1],prefix[i-1]);
            
        }
        int tam=height.Length;
        for (int i = 0; i < height.Length; i++)
        {
            if (tam-i==tam) suffix[tam-i-1] = 0;
            else suffix[tam-i-1]=Math.Max(height[tam-i],suffix[tam-i]);
           
        }

        var suma = 0;
        for (int i = 0; i < height.Length; i++)
        {
            suma=Math.Min(prefix[i], suffix[i])-height[i];
            if (suma>0) sum += suma;
            
        }
        
        return sum;
    }
}
