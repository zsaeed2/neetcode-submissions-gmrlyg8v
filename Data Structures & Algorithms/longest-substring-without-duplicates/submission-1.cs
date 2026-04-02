public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLength = 0;

        for (int i = 0; i < s.Length; i++) {
            HashSet<char> seenCharacters = new HashSet<char>();
            for (int j = i; j < s.Length; j++) {
                if (seenCharacters.Contains(s[j])) {
                    break;
                }
                seenCharacters.Add(s[j]);
                maxLength = Math.Max(maxLength, j - i + 1);
            }
        }
        return maxLength;
    }
}
