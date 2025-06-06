//1. Two Sum

namespace LeetCode;
public class Solution_1
{
    public int[] TwoSum(int[] nums, int target)
    {
        //O(n2)

        // for (int i = 0; i < nums.Length; ++i) {
        //     for (int j = i + 1; j < nums.Length; ++j) {
        //         if (nums[i] + nums[j] == target) return new [] {i, j};
        //     }
        // }
        // return new [] {-1, -1};

        //O(n log n)
        // var indexedNums = nums.Select((num, index) => (num, index))
        //                       .OrderBy(x => x.num)
        //                       .ToArray();
        // int left = 0, right = nums.Length - 1;
        // while (left < right) {
        //     long sum = (long)indexedNums[left].num + indexedNums[right].num;
        //     if (sum == target) {
        //         return new[] { indexedNums[left].index, indexedNums[right].index };
        //     } else if (sum < target) {
        //         left++;
        //     } else {
        //         right--;
        //     }
        // }
        // return new[] { -1, -1 };

        //O(n)
        var dict = new Dictionary<long, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            long complement = target - nums[i];
            if (dict.TryGetValue(nums[i], out int index))
            {
                return new[] { index, i };
            }
            dict[complement] = i;
        }
        return new[] { -1, -1 };
    }

}