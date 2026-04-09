public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var res = new List<List<int>>();
        Array.Sort(nums);
        // -i = j + k
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] > 0) break;            
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            int j = i + 1;
            int k = nums.Length - 1;
            while(j < k) {
                int sum = nums[j] + nums[k];
                if (sum > -nums[i]) k--;
                else if (sum < -nums[i]) j++;
                else {                    
                    res.Add(new List<int>() {
                        nums[i], nums[j], nums[k]
                    });
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
