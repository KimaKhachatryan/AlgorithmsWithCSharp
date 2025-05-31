namespace Algorithms_CSharp.BinarySearch;
public static class LowerBoundAlgorithm
{
    // Returns the index of the first element in the sorted array that is not less than the target.
    // If all elements are less than the target, returns array.Length.
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