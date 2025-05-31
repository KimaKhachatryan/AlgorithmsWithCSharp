namespace Algorithms_CSharp.BinarySearch;
public static class UpperBoundAlgorithm
{
    // Returns the index of the first element in the sorted array that is greater than the target.
    // If no such element exists, returns array.Length.
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
}