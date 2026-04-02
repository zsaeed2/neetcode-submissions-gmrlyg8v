public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int numZeros = nums.Where(x => x == 0).Count();

        if (numZeros > 1) {
            return this.MultipleZeros(nums);
        }
        else if (numZeros == 1) {
            return this.SingleZero(nums);
        }
        
        int n = nums.Length;
        int product = 1;

        foreach (int num in nums) {
            product *= num;
        }  
        
        int[] output = new int[n];
        for(int i = 0; i < n; i++) {

            output[i] = product / nums[i];
        }

        return output;
    }

    private int[] MultipleZeros(int[] nums) {
        return new int[nums.Length];
    }

    private int[] SingleZero(int[] nums) {
        int product = 1;
        int[] products = new int[nums.Length];
        int zeroIndex = -1;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) {
                zeroIndex = i;
                continue;
            }
            product *= nums[i];
        }

        products[zeroIndex] = product;
        return products;
    }
}
