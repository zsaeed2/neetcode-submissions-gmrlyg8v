public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> cache = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++) {
            if (cache.ContainsKey(target - nums[i])) {
                return new int[] {cache[target - nums[i]], i};
            }

            cache[nums[i]] = i;
        }

        return new int[] {-1, -1};
    }
}
