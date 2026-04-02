class Solution {
    public int maxProfit(int[] prices) {
        int minBuy = prices[0];
        int maxProfit = 0;
        for (int price : prices) {
            maxProfit = Math.max(maxProfit, price - minBuy);
            if (minBuy > price) {
                minBuy = price;
            }
        }
        return maxProfit;
    }
}
