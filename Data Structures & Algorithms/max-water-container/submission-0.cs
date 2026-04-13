public class Solution {
    public int MaxArea(int[] heights) {
        int max = 0;
        int i = 0;
        int j = heights.Length - 1;
        while (j > i) {
            int water = (j - i) * Math.Min(heights[i], heights[j]); 
            max = Math.Max(water, max);
            if (heights[j] < heights[i]) j--;
            else i++;
        }
        return max;
    }
}