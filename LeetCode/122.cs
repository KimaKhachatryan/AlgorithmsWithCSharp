//122. Best time to buy and sell stock II
namespace LeetCode;
public class Solution_122
{
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        
        for (int i = 0; i < prices.Length - 1; i++) {
            if (prices[i + 1] > prices[i]) {
                maxProfit += prices[i + 1] - prices[i];
            }
        }
        
        return maxProfit;
    }
}