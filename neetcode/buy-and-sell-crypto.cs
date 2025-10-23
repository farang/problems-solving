public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length == 0) {
            return 0;
        }

        var res = 0;
        var minBuy = prices[0];

        for (var i = 0; i < prices.Length; i++) {
            res = Math.Max(res, prices[i] - minBuy);
            minBuy = Math.Min(minBuy, prices[i]);
        }

        return res;
    }
}
