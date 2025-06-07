namespace MaxSubarray;

public partial class MaxSubarraySolver
{
    public static int GetMaxProfit_DC(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            throw new ArgumentException("Input array must not be null or empty.");
        
        return FindMaxProfit(nums, 0, nums.Length - 1);
    }

    private static int FindMaxProfit(int[] nums, int left, int right)
    {
        if (left == right)
            return nums[left];

        int mid = (left + right) / 2;

        int leftMax = FindMaxProfit(nums, left, mid);
        int rightMax = FindMaxProfit(nums, mid + 1, right);
        int crossMax = FindMaxProfit(nums, left, mid, right);

        return Math.Max(Math.Max(leftMax, rightMax), crossMax);
    }

    private static int FindMaxProfit(int[] nums, int left, int mid, int right)
    {
        int i = mid, sum, leftSum = int.MinValue, rightSum = int.MinValue;

        sum = 0;
        while (i >= left)
        {
            sum += nums[i];
            leftSum = Math.Max(leftSum, sum);
            i--;
        }

        i = mid + 1;
        sum = 0;
        while (i <= right)
        {
            sum += nums[i];
            rightSum = Math.Max(rightSum, sum);
            i++;
        }

        return leftSum + rightSum;
    }
}
