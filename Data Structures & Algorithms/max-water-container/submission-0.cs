public class Solution {
    public int MaxArea(int[] heights) {
        int r = heights.Length - 1;
        int l = 0;
        int maxArea = 0;

        while (l < r) {
            int area = Math.Min(heights[l], heights[r]) * (r - l);
            if (heights[l] <= heights[r]) {
                l++;
            }
            else {
                r--;
            }
            maxArea = Math.Max(area, maxArea);
        }

        return maxArea;
    }
}
