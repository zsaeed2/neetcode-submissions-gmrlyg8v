public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groupedAnagrams = new Dictionary<string, List<string>>();

        foreach (string str in strs) {
            string sortedStr = this.SortString(str);
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
