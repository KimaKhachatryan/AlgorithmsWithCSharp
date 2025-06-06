//922. Sort Array By Parity II

namespace LeetCode;

public class Solution_922 {
    public int[] SortArrayByParityII(int[] nums) {
        int i = 0;
        int j = nums.Length - 1;
        
        while (i < nums.Length && j > 0) {
            while (i < nums.Length && j > 0 && (nums[i] % 2) == 0) i += 2;
            while (i < nums.Length && j > 0 && (nums[j] % 2) != 0) j -= 2;

            if (i < nums.Length && j > 0) {
                int tmp = nums[j];
                nums[j] = nums[i];
                nums[i] = tmp;
            } 
        }

        return nums;
    }
}