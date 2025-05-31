namespace Algorithms_CSharp.Sort;

public class SelectionSortAlgorithm
{
    public static void Sort<T>(T[] array) where T : IComparable<T>
    {
        int length = array.Length;

        if (array == null || length <= 1) return;

        for (int i = 0; i < length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < length; j++)
            {
                if (array[j].CompareTo(array[minIndex]) < 0)
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                T temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }
    }
}