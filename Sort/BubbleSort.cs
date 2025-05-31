namespace Algorithms_CSharp.Sort;

public class BubbleSortAlgorithm
{
    public static void Sort<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length <= 1) return;

        int length = array.Length;
        bool swapped;

        for (int j = 0; j < length - 1; j++)
        {
            swapped = false;

            for (int i = 0; i < length - 1 - j; i++)
            {
                if (array[i].CompareTo(array[i + 1]) > 0)
                {
                    T temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped)
                break;
        }
    }
}