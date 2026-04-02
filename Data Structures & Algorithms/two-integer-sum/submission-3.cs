public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> cache = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];
            if (cache.ContainsKey(diff)) {
                return new int[] {cache[diff], i};
            }

            cache[nums[i]] = i;
        }

        return new int[] {-1, -1};
    }
}
