public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        
        int[] prefix = new int[n];
        prefix[0] = 1;
        for(int i = 1; i < n; i++) {
            prefix[i] = nums[i-1] * prefix[i-1];
        }

        int[] suffix = new int[n];
        suffix[n-1] = 1;
        for(int i = n-2; i >= 0; i--) {
            suffix[i] = suffix[i+1] * nums[i+1];
        }

        int[] result = new int[n];
        for(int i = 0; i < n; i++) {
            result[i] = suffix[i] * prefix[i];
        }

        return result;
    }
}
