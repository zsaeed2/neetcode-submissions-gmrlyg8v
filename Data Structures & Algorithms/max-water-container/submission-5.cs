public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0;
        int r = heights.Length - 1;
        int maxVolume = 0;

        while (l < r) {
            maxVolume = Math.Max(maxVolume, (r - l) * Math.Min(heights[l], heights[r]));

            if (heights[l] <= heights[r]) {
                l++;
            }
            else {
                r--;
            }
        }

        return maxVolume;
    }
}
