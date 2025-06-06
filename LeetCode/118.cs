//118. Pascal's Triangle

namespace LeetCode
{
    public class Solution_118
    {
        public IList<IList<int>> Generate(int numRows) {
        List<IList<int>> result = [new List<int> {1}];
        
        for (int i = 1; i < numRows; i++)
            {
                List<int> innerList = new(i + 1);

                innerList.Add(1);
                for (int j = 1; j < i; j++)
                {
                    innerList.Add(result[i - 1][j - 1] + result[i - 1][j]);
                }
                innerList.Add(1);

                result.Add(innerList);
            }
        
        return result;
    }
    }
}