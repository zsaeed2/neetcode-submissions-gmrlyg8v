public class Solution {
    public int FirstMissingPositive(int[] nums) {
        Array.Sort(nums);
        int missing = 1;

        foreach (int num in nums) {
            if (missing == num) {
                missing++;
            }
        }

        return missing;
    }
}