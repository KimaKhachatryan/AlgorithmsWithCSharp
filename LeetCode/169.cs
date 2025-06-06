//169. Majority Element

namespace LeetCode;

public class Solution_169 {
    public int MajorityElement(int[] nums) {
        return nums.OrderBy(x => x).Skip(nums.Length / 2).First();

        // int count = 0;
        // int result = 0;

        // foreach (int num in nums) {
        //     if (count == 0) {
        //         result = num;
        //     }

        //     count += (num == result) ? 1 : -1;
        // }

        // return result;
    }
}