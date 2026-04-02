public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        Array.Sort(strs);

        string result = string.Empty;
        string first = strs[0];
        string last = strs[strs.Length - 1];
        int leastCommonSize = Math.Min(first.Length, last.Length);
        for (int i = 0; i < leastCommonSize; i++) {
            if (first[i] != last[i]) {
                return result;
            }
            result += first[i];
        }

        return result;
    }
}