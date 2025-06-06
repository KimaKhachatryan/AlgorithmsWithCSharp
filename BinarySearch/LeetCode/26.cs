//26. Remove Duplicates from Sorted Array

namespace LeetCode;

public class Solution_26 {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 1) return 1;
        
        int j = 1;
        
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[j - 1]) {
                nums[j] = nums[i];
                j++;
            }
        }
        
        return j;
    }
}