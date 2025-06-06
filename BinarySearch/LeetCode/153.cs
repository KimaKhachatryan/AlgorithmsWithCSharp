//153. Find Minimum in Rotated Sorted Array
namespace LeetCode;
public class Solution_153 {
    public int FindMin(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;
        
        while (left < right) {
            int mid = left + (right - left) / 2;
            
            if (nums[mid] > nums[right]) {
                left = mid + 1;
            }
            else {
                right = mid;
            }
        }
        
        return nums[left];
    }
}