namespace MaxSubarray;

public partial class MaxSubarraySolver
{
    public static int GetMaxProfit(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return 0;

        int maxProfit = nums[0];
        int currentMax = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            currentMax = Math.Max(nums[i], currentMax + nums[i]);
            maxProfit = Math.Max(maxProfit, currentMax);
        }

        return maxProfit;
    }
}