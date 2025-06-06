//33. Search in Rotated Sorted Array

namespace LeetCode;

public class Solution_33 {
    public int Search(int[] nums, int target) {
        // if (nums == null || nums.Length == 0) return -1;
        // return Search(nums, target, 0, nums.Length - 1);

        if (nums == null || nums.Length == 0) return -1;
        
        int left = 0;
        int right = nums.Length - 1;
        
        while (left <= right) {
            int mid = left + (right - left) / 2;
            
            if (nums[mid] == target) {
                return mid;
            }
            
            if (nums[left] <= nums[mid]) {
                if (nums[left] <= target && target < nums[mid]) {
                    right = mid - 1;
                } else {
                    left = mid + 1;
                }
            }
            else {
                if (nums[mid] < target && target <= nums[right]) {
                    left = mid + 1;
                } else {
                    right = mid - 1;
                }
            }
        }
        
        return -1;
    }

    //Recursive
    private int Search(int[] nums, int target, int left, int right) {
        if (left > right) return -1;
        
        int mid = left + (right - left) / 2;
        
        if (nums[mid] == target) return mid;
        
        if (nums[left] <= nums[mid]) {
            if (nums[left] <= target && target < nums[mid]) {
                return Search(nums, target, left, mid - 1);
            } else {
                return Search(nums, target, mid + 1, right);
            }
        }
        else {
            if (nums[mid] < target && target <= nums[right]) {
                return Search(nums, target, mid + 1, right);
            } else {
                return Search(nums, target, left, mid - 1);
            }
        }
    }
}