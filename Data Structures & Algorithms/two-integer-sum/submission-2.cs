public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> compliment = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];
            if (compliment.ContainsKey(diff)) {
                return new int[] {compliment[diff], i};
            }
            else {
                compliment[nums[i]] = i;
            }
        }
        return null;
    }
}
