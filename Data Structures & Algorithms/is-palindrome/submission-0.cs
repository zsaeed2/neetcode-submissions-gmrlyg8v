public class Solution {
    public bool IsPalindrome(string s) {
        string filteredString = Regex.Replace(s, "[^a-zA-Z0-9]", String.Empty).ToLower();

        return RecursivePalindrome(filteredString);
    }

    public bool RecursivePalindrome(string s) {
        if (s.Length < 2) {
            return true;
        }

        if (!s[0].Equals(s[s.Length - 1])) {
            return false;
        }

        return (RecursivePalindrome(s.Substring(1, s.Length - 2)));
    }
}
