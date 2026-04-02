public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int l = 0;
        int r = nums.Length;

        while (l < r) {
            if (nums[l] == val) {
                nums[l] = nums[--r];
            }
            else {
                l++;
            }
        }
        return r;
    }
}