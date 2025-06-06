//34. Find First and Last Position of Element in Sorted Array

namespace LeetCode;
public class Solution_34
{
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

    public static int UpperBound<T>(T[] array, T target) where T : IComparable<T>
    {
        int left = 0, right = array.Length;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid].CompareTo(target) <= 0) // If array[mid] <= target, move right
                left = mid + 1;
            else
                right = mid;
        }
        return left;
    }

    public int[] SearchRange(int[] nums, int target)
    {
        if (nums == null || nums.Length == 0) return new int[] { -1, -1 };

        int lower = LowerBound(nums, target);

        if (lower >= nums.Length || nums[lower] != target)
        {
            return new int[] { -1, -1 };
        }

        int upper = UpperBound(nums, target) - 1;

        return new int[] { lower, upper };
    }
}
