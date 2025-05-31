namespace Algorithms_CSharp.Sort;

public class MergeSortAlgorithm
{
    public static void Sort<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length <= 1)
            return;

        MergeSort(array, 0, array.Length - 1);
    }

    private static void MergeSort<T>(T[] array, int left, int right) where T : IComparable<T>
    {
        if (left >= right)
            return;

        int mid = left + (right - left) / 2;
        MergeSort(array, left, mid);
        MergeSort(array, mid + 1, right);

        Merge(array, left, mid, right);
    }

    private static void Merge<T>(T[] array, int left, int mid, int right) where T : IComparable<T>
    {
        var temp = new List<T>(right - left + 1);

        int i = left, j = mid + 1;

        while (i <= mid && j <= right)
        {
            if (array[i].CompareTo(array[j]) <= 0)
            {
                temp.Add(array[i++]);
            }
            else
            {
                temp.Add(array[j++]);
            }
        }

        while (i <= mid)
            temp.Add(array[i++]);

        while (j <= right)
            temp.Add(array[j++]);

        for (int t = 0; t < temp.Count; t++)
            array[left + t] = temp[t];
    }
}