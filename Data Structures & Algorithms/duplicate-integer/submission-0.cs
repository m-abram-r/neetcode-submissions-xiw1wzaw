public class Solution {
    public bool hasDuplicate(int[] nums) {
        var n = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++){
            n.Add(nums[i]);
        }
        Console.WriteLine(n.Count());
        return nums.Length != n.Count();
    }
}