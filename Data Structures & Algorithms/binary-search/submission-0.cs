public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;
        
        while (l <= r) {
            int mid = (l + r) / 2;
            int currVal = nums[mid];
            if (currVal > target) {
                r = mid - 1;
            }
            else if (target > currVal) {
                l = mid + 1 ;
            }
            else {
                return mid;
            }
        }
        return -1;
    }
}
