public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0;
        int r = heights.Length - 1;
        int maxVolume = 0;

        while (l < r) {
            int left = heights[l];
            int right = heights[r];
            maxVolume = Math.Max(maxVolume, (r - l) * Math.Min(left, right));

            if (left <= right) {
                l++;
            }
            else {
                r--;
            }
        }

        return maxVolume;
    }
}
