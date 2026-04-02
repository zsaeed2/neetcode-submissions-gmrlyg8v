public class Solution {
    public int MaxProfit(int[] prices) {
        int l = prices[0];
        int maxProfit = 0;
        for(int i = 0; i < prices.Length; i++) {
            maxProfit = Math.Max(maxProfit, prices[i] - l);
            l = Math.Min(l, prices[i]);
        }

        return maxProfit;
    }
}
