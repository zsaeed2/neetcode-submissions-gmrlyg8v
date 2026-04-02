public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> indices = new Dictionary<char, int>();
        int maxLength = 0;
        int l = 0;

        for (int r = 0; r < s.Length; r++) {
            if (indices.ContainsKey(s[r])) {
                l = Math.Max(indices[s[r]] + 1, l);
            }

            indices[s[r]] = r;
            maxLength = Math.Max(maxLength, r - l + 1);
        }

        return maxLength;
    }
}
