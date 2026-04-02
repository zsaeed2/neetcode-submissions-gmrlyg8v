public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1;
        int r = piles.Max();
        int minK = r;

        while (l <= r) {
            int mid = (l + r) / 2;

            int hours = 0;
            foreach(int pile in piles) {
                hours += (int)Math.Ceiling((double)pile / mid);
            }

            if (hours <= h) {
                r = mid - 1;
                minK = Math.Min(minK, mid);
            }
            else {
                l = mid + 1;
            }
        }

        return minK;
    }
}
