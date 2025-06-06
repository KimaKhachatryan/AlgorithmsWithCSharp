//704. Binary Search

namespace LeetCode;

public class Solution_704 {
    public int Search(int[] nums, int target) {
        // int left = 0;
        // int right = nums.Length - 1;

        // while (left <= right)
        // {
        //     int mid = left + (right - left) / 2;

        //     if (nums[mid] == target)
        //         return mid;
        //     else if (nums[mid] < target)
        //         left = mid + 1;
        //     else
        //         right = mid - 1;
        // }

        // return -1;

        return Search(nums, 0, nums.Length - 1, target);
    }

    public int Search(int[] nums, int left, int right, int target) {
        if (left > right) {
            return -1;
        }

        int mid = left + (right - left) / 2;

        if (nums[mid] == target)
            return mid;
        else if (nums[mid] < target)
            return Search(nums, mid + 1, right, target);
        else
            return Search(nums, left, mid - 1, target);
    }
}