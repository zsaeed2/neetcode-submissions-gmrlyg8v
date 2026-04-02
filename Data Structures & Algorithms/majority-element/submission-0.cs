public class Solution {
    public int MajorityElement(int[] nums) {
        return nums.GroupBy(x => x).OrderByDescending(y => y.Count()).Select(z => z.Key).FirstOrDefault();
    }
}