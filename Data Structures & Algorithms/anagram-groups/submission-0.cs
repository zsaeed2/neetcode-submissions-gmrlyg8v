public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

        foreach (string str in strs) {
            string sortedStr = this.sortString(str);
            if(!anagrams.ContainsKey(sortedStr)) {
                anagrams[sortedStr] = new List<string> {str};
            }
            else {
                anagrams[sortedStr].Add(str);
            }
        }

        return anagrams.Values.ToList();
    }

    private string sortString(string str) {
        char[] chars = str.ToCharArray();

        Array.Sort(chars);

        string sortedStr = new string(chars);

        return sortedStr;
    }
}
