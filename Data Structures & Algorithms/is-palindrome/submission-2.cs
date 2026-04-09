public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;
        while (left < right) {
            while (left < right && !Char.IsLetterOrDigit(s[left])) left += 1;
            while (right > left && !Char.IsLetterOrDigit(s[right])) right -= 1;
            if (Char.ToLower(s[left]) != Char.ToLower(s[right])) return false;
            left++; right--;
        }
        return true;
    }
}
