public class Solution {
    public int MaxProfit(int[] prices) {
        int low = 0;
        int high = 0;
        int maxProfit = int.MinValue;
        for (int i = 0; i < prices.Length; i++) {
            if (prices[i] < prices[low]) low = i;
            if (prices[i] > prices[high] || low > high) high = i;
            if (prices[high] - prices[low] > maxProfit) 
                maxProfit = prices[high] - prices[low];            
        }
        return maxProfit;
    }
}
