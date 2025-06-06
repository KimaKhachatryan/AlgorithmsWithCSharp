//31. Next Permutation

namespace LeetCode;

public class Solution_31
{
    public void NextPermutation(int[] nums)
    {
        int firstIndexToSwap = nums.Length - 2;
        while (firstIndexToSwap >= 0 && nums[firstIndexToSwap] >= nums[firstIndexToSwap + 1])
        {
            firstIndexToSwap--;
        }

        if (firstIndexToSwap < 0)
        {
            Array.Reverse(nums);
            return;
        }

        int secondIndexToSwap = nums.Length - 1;
        while (secondIndexToSwap > firstIndexToSwap && nums[secondIndexToSwap] <= nums[firstIndexToSwap])
        {
            secondIndexToSwap--;
        }

        Swap(nums, firstIndexToSwap, secondIndexToSwap);

        Array.Reverse(nums, firstIndexToSwap + 1, nums.Length - (firstIndexToSwap + 1));
    }

    private void Swap(int[] arr, int i, int j)
    {
        if (i == j) return;
        int tmp = arr[i];
        arr[i] = arr[j];
        arr[j] = tmp;
    }
}