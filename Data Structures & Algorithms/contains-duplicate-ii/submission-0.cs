public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        for (int i = 0; i < nums.Length; i++) {
            if (i == nums.Length - 1) continue; 
            int j = i + 1;
            while (j - i <= k && j < nums.Length) {
                if (nums[i] == nums[j]) return true;
                j++;
            }
        }
        return false;
    }
}