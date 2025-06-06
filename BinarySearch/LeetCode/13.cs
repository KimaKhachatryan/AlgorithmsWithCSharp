//13. Roman to Integer

namespace LeetCode;

public class Solution_13 {
    private readonly Dictionary<char, int> roman = new Dictionary<char, int> {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
    
    public int RomanToInt(string s) {
        int result = 0;
        
        for (int i = 0; i < s.Length - 1; i++) {
            if (roman[s[i]] < roman[s[i + 1]]) {
                result -= roman[s[i]];
            } else {
                result += roman[s[i]];
            }
        }
        
        result += roman[s[s.Length - 1]];
        
        return result;
    }
}