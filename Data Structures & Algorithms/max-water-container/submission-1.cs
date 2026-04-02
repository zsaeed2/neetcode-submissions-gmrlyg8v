public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0;
        int r = heights.Length - 1;
        int maxVolume = -1;

        while (l < r) {
            maxVolume = Math.Max(maxVolume, Math.Min(heights[l], heights[r]) * (r - l));

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
