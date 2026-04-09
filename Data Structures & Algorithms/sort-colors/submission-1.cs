public class Solution {
    public void SortColors(int[] nums) {
        int l = 0;
        int m = 0;

        for(int r = 0; r < nums.Length; r++) {
            int temp = nums[r];
            nums[r] = 2;

            if (temp < 2) {
                nums[m] = 1;
                m++;
            }
            if (temp < 1) {
                nums[l] = 0;
                l++;
            }
        }
    }
}