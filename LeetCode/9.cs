//9. Palindrome Number

namespace LeetCode
{
    public class Solution_9
    {
        public bool IsPalindrome(int x) {
        if (x < 0) return false;
        
        if (x < 10) return true;
        
        long reversed = 0; //use long to handle potential overflow
        int original = x;
        
        while (x > 0) {
            int digit = x % 10;
            reversed = reversed * 10 + digit;
            x /= 10;
        }
        
        return reversed == original;
    }
    }
}