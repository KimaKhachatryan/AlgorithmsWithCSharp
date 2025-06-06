//35. Search Insert Position

namespace LeetCode;

public class Solution_35 {
    public int SearchInsert(int[] nums, int target) {
        return LowerBound<int>(nums, target);
    }

    public static int LowerBound<T>(T[] array, T target) where T : IComparable<T>
    {
        int left = 0, right = array.Length;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid].CompareTo(target) < 0) // Checks if the element at the middle index is less than the target.
                left = mid + 1;
            else
                right = mid;
        }
        return left;
    }
}