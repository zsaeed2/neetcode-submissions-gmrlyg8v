public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groupedAnagrams = new Dictionary<string, List<string>>();

        foreach (string str in strs) {
            int[] count = new int[26];
            foreach(char c in str) {
                count[c - 'a']++;
            }
            string sortedStr = string.Join(",", count);
            if (!groupedAnagrams.ContainsKey(sortedStr)) {
                groupedAnagrams[sortedStr] = new List<string> {str};
            }
            else {
                groupedAnagrams[sortedStr].Add(str);
            }
        }

        return groupedAnagrams.Values.ToList();
    }

    public string SortString(string str) {
        char[] charStr = str.ToCharArray();
        Array.Sort(charStr);
        return new string(charStr);
    }
}
