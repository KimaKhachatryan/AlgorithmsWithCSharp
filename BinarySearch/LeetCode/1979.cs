//1979. Find Greatest Common Divisor of Array

namespace LeetCode;

public class Solution_1979
{
    public int FindGCD(int[] nums) {
        int max = nums.Max();
        int min = nums.Min();

        while (min != 0) {
            int tmp = max;
            max = min;
            min = tmp % min;
        }

        return max;
    }
}