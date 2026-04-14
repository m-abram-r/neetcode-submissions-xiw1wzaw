public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        Array.Sort(strs);
        int i = 0;
        string res = "";
        while (i < strs[0].Length && strs[0][i] == strs[strs.Length - 1][i]) {
            res += strs[0][i];
            i++;
        }
        return res;
    }
}