public class Solution {
    public int[][] Merge(int[][] intervals) {
        int[][] sortedIntervals = intervals.OrderBy(x => x[0]).ToArray();
        List<int[]> mergedIntervals = new List<int[]>{sortedIntervals[0]};

        foreach(int[] interval in sortedIntervals.Skip(1)) {
            int right = mergedIntervals.Last()[1];

            if (interval[0] <= right) {
                mergedIntervals.Last()[1] = Math.Max(interval[1], right);
            }
            else {
                mergedIntervals.Add(interval);
            }
        }

        return mergedIntervals.ToArray();
    }
}
