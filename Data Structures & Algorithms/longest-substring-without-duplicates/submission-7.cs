public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> lastKnownIndex = new Dictionary<char, int>();
        int l = 0;
        int maxLength = 0;

        for (int r = 0; r < s.Length; r++) {
            if (lastKnownIndex.ContainsKey(s[r])) {
                l = Math.Max(l, lastKnownIndex[s[r]] + 1);
            }

            lastKnownIndex[s[r]] = r;
            maxLength = Math.Max(maxLength, r - l + 1);
        }

        return maxLength;
    }
}
