public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0;
        int r = heights.Length - 1;
        int maxVolume = 0;

        while (l < r) {
            int lHeight = heights[l];
            int rHeight = heights[r];
            maxVolume = Math.Max(maxVolume, Math.Min(lHeight, rHeight) * (r - l));

            if (lHeight < rHeight) {
                l++;
            }
            else {
                r--;
            }
        }

        return maxVolume;
    }
}
