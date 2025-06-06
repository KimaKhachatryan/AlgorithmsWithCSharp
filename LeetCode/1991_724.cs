//1991/724. Find the Middle Index in Array

namespace LeetCode;

public class Solution_1991_724
{
    public int FindMiddleIndex(int[] nums) {
        int leftSum = nums[0];
        int rightSum = nums.Skip(1).Sum();

        if (rightSum == 0) return 0;

        for (int i = 1; i < nums.Length - 1; ++i) {
            rightSum -= nums[i];
            if (rightSum == leftSum) return i;
            leftSum += nums[i];
        }

        if (leftSum == 0) return nums.Length - 1;

        return -1;
    }
}