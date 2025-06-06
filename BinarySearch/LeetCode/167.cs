//167. Two Sum II - Input Array Is Sorted
namespace LeetCode;
public class Solution_167
{
    public int[] TwoSum(int[] nums, int target)
    {
        var indexedNums = nums.Select((num, index) => (num, index))
                              .ToArray();
        int left = 0, right = nums.Length - 1;
        while (left < right)
        {
            long sum = (long)indexedNums[left].num + indexedNums[right].num;
            if (sum == target)
            {
                return new[] { indexedNums[left].index + 1, indexedNums[right].index + 1 };
            }
            else if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return new[] { -1, -1 };
    }
}