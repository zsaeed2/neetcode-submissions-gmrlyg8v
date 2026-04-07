public class Solution {
    public int MaxProfit(int[] prices) {
        int l = prices[0];
        int maxProfit = 0;

        foreach(int price in prices) {
            maxProfit = Math.Max(maxProfit, price - l);
            l = Math.Min(l, price);
        }

        return maxProfit;
    }
}
