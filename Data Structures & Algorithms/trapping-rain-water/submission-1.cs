public class Solution {
    public int Trap(int[] height) {
        int[] iMax = new int[height.Length];
        int[] jMax = new int[height.Length];
        int pool = 0;
        {
            int max = 0;
            for (int i = 0; i < height.Length; i++) {
                max = Math.Max(height[i], max);
                iMax[i] = max;
            }
            max = 0;
            for (int j = height.Length - 1; j >= 0; j--) {
                max = Math.Max(height[j], max);
                jMax[j] = max;
            }
        }
        
        for (int k = 0; k < height.Length; k++) {
            pool += Math.Min(iMax[k], jMax[k]) - height[k];
        }
        return pool;
    }
}
