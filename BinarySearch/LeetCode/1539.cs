//1539. Kth Missing Positive Number

namespace LeetCode;

public class Solution_1539 {
    public int FindKthPositive(int[] arr, int k) {
        return FindKthPositive(arr, 0, arr.Length - 1, k);

        // int left = 0; 
        // int right = arr.Length - 1;
        
        // while (left <= right) {
        //     int mid = left + (right - left) / 2;
        //     int missing = arr[mid] - (mid + 1);
            
        //     if (missing < k) {
        //         left = mid + 1;
        //     } else {
        //         right = mid - 1;
        //     }
        // }
        
        // return left + k;
    }

    public int FindKthPositive(int[] arr, int left, int right, int k) {
        if (left > right)  return left + k;

        int mid = left + (right - left) / 2;
        int missing = arr[mid] - (mid + 1);
            
        if (missing < k) {
            return FindKthPositive(arr, left: mid + 1, right, k);
        } else {
            return FindKthPositive(arr, left, right: mid - 1, k);
        }
    }
}