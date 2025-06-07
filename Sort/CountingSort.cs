namespace Algorithms_CSharp.Sort;
public class CountingSortAlgorithm
{
    // Sorts an array of non-negative integers using Counting Sort
    public static void CountingSort(int[] array)
    {
        if (array == null || array.Length == 0)
            return;

        int max = array.Max();

        int[] count = new int[max + 1];

        foreach (int num in array)
        {
            count[num]++;
        }

        for (int i = 1; i < count.Length; i++)
        {
            count[i] += count[i - 1];
        }

        int[] result = new int[array.Length];

        for (int i = array.Length - 1; i >= 0; i--)
        {
            int num = array[i];
            result[--count[num]] = num;
        }

        Array.Copy(result, array, array.Length);
    }
}