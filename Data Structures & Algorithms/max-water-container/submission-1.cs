public class Solution {
       public int MaxArea(int[] heights)
    {

        int left = 0;
        int right = heights.Length - 1;

        int area;
        int maxArea = 0;
        while (left<right)
        {   
            if (heights[left]<=heights[right])
            {
                area=Math.Min(heights[left], heights[right])*(right-left);
                left++;
            }
            else
            {
                area=Math.Min(heights[left], heights[right])*(right-left);
                right--;
            }
            maxArea=Math.Max(area,maxArea);
        }
        
        return maxArea;
    }
}
