namespace Algorithms_CSharp.Sort;
public class InsertionSortAlgorithm
{
    public static void Sort<T>(T[] array) where T : IComparable<T>
    {
        int length = array.Length;

        if (array == null || length <= 1) return;

        for (int i = 1; i < length; i++)
        {
            T key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j].CompareTo(key) > 0)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
    }
}