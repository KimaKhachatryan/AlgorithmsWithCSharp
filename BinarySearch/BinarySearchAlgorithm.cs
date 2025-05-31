namespace Algorithms_CSharp.BinarySearch;

public class BinarySearchAlgorithm
{
    public static bool BinarySearch(int[] array, int target)
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
}