//121. Best Time to Buy and Sell Stock

namespace LeetCode;
public class Solution_121
{
    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue;
        int maxProfit = 0;
        
        foreach (int price in prices) {
            minPrice = Math.Min(minPrice, price);
            
            maxProfit = Math.Max(maxProfit, price - minPrice);
        }
        
        return maxProfit;
    }
}