public class Solution {
    public int MaxProfit(int[] prices) {
        
        int left = 0;
        int right = 0;
        int profit ;
        int maxProfit=0;
        if (prices.Length == 1) return maxProfit;
        while (right<prices.Length)
        {
            if (left==right)
            {
                right++;
            }

            profit = prices[right]-prices[left];
            if (profit<0)
            {
                left=right;
            }
            maxProfit=Math.Max(profit,maxProfit);
            right++;
        }

        return maxProfit;
    }
}
