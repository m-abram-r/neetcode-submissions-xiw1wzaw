public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int start = 0;
        int end = numbers.Length - 1;
        while (start < end && numbers[start] + numbers[end] != target) {
            var sum = numbers[end] + numbers[start];
            if (sum > target) end--;
            else if (sum < target) start++;
        }
        return new int[] { start + 1, end + 1};
    }
}
