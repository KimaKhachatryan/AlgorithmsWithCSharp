//136. Single Number

namespace LeetCode;
public class Solution_136 {
    public int SingleNumber(int[] nums) {
        int unique = nums[0];
        foreach (var num in nums) {
            unique ^= num;
        }

        return unique;
    }

}