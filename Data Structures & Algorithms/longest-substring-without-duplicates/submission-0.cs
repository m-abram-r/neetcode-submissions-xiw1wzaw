public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> chSet = new HashSet<char>();
        int l = 0;
        int max = 0;
        for(int r = 0; r < s.Length; r++) {
            while (chSet.Contains(s[r])) {
                chSet.Remove(s[l]);
                l++;
            }
            chSet.Add(s[r]);
            max = Math.Max(r-l+1, max);
        }
        return max;
    }
}
