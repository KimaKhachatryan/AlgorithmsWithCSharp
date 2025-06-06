//74. Search a 2D Matrix

namespace LeetCode;

public class Solution {
    private bool BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
                return true;
            else if (array[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return false;
    }

    public bool SearchMatrix(int[][] matrix, int target) {
        int length = matrix[0].Length;
        int left = 0;
        int right = matrix.Length - 1;

        while (left <= right) {
            int midRow = left + (right - left) / 2;
            if (target >= matrix[midRow][0] && target <= matrix[midRow][length - 1]) {
                if (BinarySearch(matrix[midRow], target)) return true;
                else return false;
            }
            else if (target < matrix[midRow][0]) right = midRow - 1;
            else left = midRow + 1;
        }

        return false;
    }
}