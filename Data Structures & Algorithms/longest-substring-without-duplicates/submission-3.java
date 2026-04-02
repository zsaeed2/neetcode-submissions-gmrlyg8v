class Solution {
    public int lengthOfLongestSubstring(String s) {
        Map<Character, Integer> indexes = new HashMap<>();
        int l = 0;
        int maxLength = 0;

        for(int r = 0; r < s.length(); r++) {
            if (indexes.containsKey(s.charAt(r))) {
                l = Math.max(indexes.get(s.charAt(r)) + 1, l);
            }
            indexes.put(s.charAt(r), r);
            maxLength = Math.max(maxLength, r - l + 1);
        }
        return maxLength;
    }
}
