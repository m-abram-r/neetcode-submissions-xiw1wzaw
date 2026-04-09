public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var res = new List<List<int>>();
        Array.Sort(nums);
        // -i = j + k
        for (int i = 0; i < nums.Length; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            int j = i + 1;
            int k = nums.Length - 1;
            while(j < k) {
                int sum = nums[j] + nums[k];
                if (sum > -nums[i]) k--;
                else if (sum < -nums[i]) j++;
                else {
                    var triplet = new List<int>() {
                        nums[i], nums[j], nums[k]
                    };
                    res.Add(triplet);
                    while (j < k && nums[j] == nums[j+1]) j++;
                    while (j < k && nums[k] == nums[k-1]) k--;
                    j++;
                    k--;
                }                    
            }
        }
        return res;
    }
}
