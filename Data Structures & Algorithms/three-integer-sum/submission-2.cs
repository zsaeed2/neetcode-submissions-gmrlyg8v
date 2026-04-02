public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);

        List<List<int>> sums = new List<List<int>>();

        for (int i = 0; i < nums.Length - 1; i++) {
            int l = i + 1;
            int r = nums.Length - 1;
            int currValue = nums[i];
            while(l < r) {
                int sum = currValue + nums[l] + nums[r];

                if (sum > 0) {
                    r--;
                }
                else if (sum < 0) {
                    l++;
                }
                else {
                    List<int> zeroSum = new List<int> {currValue, nums[l], nums[r]};
                    if (!sums.Any(xs => xs.OrderBy(x => x).SequenceEqual(zeroSum.OrderBy(x => x))))
                    {
                        sums.Add(zeroSum);
                    }
                    l++;
                    r--;
                }
            }
        }

        return sums.Distinct().ToList();
    }
}
