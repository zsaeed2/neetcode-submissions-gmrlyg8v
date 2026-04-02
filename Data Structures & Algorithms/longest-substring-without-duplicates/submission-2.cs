public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLength = 0;
        HashSet<char> seenCharacters = new HashSet<char>();
        int l = 0;

        for(int r = 0; r < s.Length; r++) {
            while(seenCharacters.Contains(s[r])) {
                seenCharacters.Remove(s[l]);
                l++;
            }
            seenCharacters.Add(s[r]);
            maxLength = Math.Max(maxLength, r - l + 1);
        }
        return maxLength;
    }
}
