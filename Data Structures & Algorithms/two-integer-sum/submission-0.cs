public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var n = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++){
            int d = target - nums[i];
            if (n.ContainsKey(nums[i])) {
                return new int[2] {n[nums[i]], i};
            }
            else n.Add(d, i);
        }
        return new int[2];
    }
}
