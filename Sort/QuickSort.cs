namespace Algorithms_CSharp.Sort;

public class QuickSort
{
    public static void Sort(int[] array)
    {
        QuickSortHelper(array, 0, array.Length - 1);
    }

    private static void QuickSortHelper(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = PartitionFirst(array, left, right);
            QuickSortHelper(array, left, pivotIndex - 1);
            QuickSortHelper(array, pivotIndex + 1, right);
        }
    }

    // Partition using the last element as pivot
    private static int PartitionLast(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }
        Swap(array, i + 1, right);
        return i + 1;
    }

    // Partition using the first element as pivot
    private static int PartitionFirst(int[] array, int left, int right)
    {
        int pivot = array[left];
        int i = left + 1;

        for (int j = left + 1; j <= right; j++)
        {
            if (array[j] < pivot)
            {
                Swap(array, i, j);
                i++;
            }
        }
        Swap(array, left, i - 1);
        return i - 1;
    }

    // Partition using the median of three as pivot
    private static int PartitionMedianOfThree(int[] array, int left, int right)
    {
        int mid = left + (right - left) / 2;

        if (array[left] > array[mid])
            Swap(array, left, mid);
        if (array[left] > array[right])
            Swap(array, left, right);
        if (array[mid] > array[right])
            Swap(array, mid, right);


        Swap(array, mid, right - 1);
        int pivot = array[right - 1];
        int i = left;

        for (int j = left; j < right - 1; j++)
        {
            if (array[j] <= pivot)
            {
                Swap(array, i, j);
                i++;
            }
        }
        Swap(array, i, right - 1);
        return i;
    }

    private static void Swap(int[] array, int i, int j)
    {
        (array[j], array[i]) = (array[i], array[j]);
    }
}