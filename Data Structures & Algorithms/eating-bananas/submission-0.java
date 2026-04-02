class Solution {
    public int minEatingSpeed(int[] piles, int h) {
        int l = 1;
        int r = Arrays.stream(piles).max().getAsInt();
        int minRate = r;

        while (l <= r)
        {
            int mid = (l + r) / 2;
            int hours = 0;
            for (int pile : piles) {
                hours += Math.ceilDiv(pile, mid);
            }
            if (hours <= h) {
                minRate = mid;
                r = mid - 1;
            }
            else {
                l = mid + 1;
            }
        }
        return minRate;
    }
}
