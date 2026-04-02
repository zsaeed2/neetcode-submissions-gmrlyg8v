public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLength = 0;
        int l = 0;
        Dictionary<char, int> indices = new Dictionary<char, int>();

        for(int r = 0; r < s.Length; r++) {
            if (indices.ContainsKey(s[r])) {
                l = Math.Max(l, indices[s[r]] + 1);
            }

            indices[s[r]] = r;
            maxLength = Math.Max(maxLength, r - l + 1);
        }

        return maxLength;
    }
}
