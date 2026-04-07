public class Solution {
    public List<string> RestoreIpAddresses(string s) {
        List<string> addresses = new List<string>();

        if(s.Length > 12) {
            return addresses;
        }

        void Backtrack(int i, int numDots, string currIP) {
            if (numDots == 4 && i == s.Length) {
                addresses.Add(currIP.Substring(0, currIP.Length - 1));
                return;
            }

            if (numDots > 4) {
                return;
            }

            for(int j = i; j < Math.Min(s.Length, i + 3); j++) {
                if (i != j && s[i] == '0') {
                    continue;
                }
                string section = s.Substring(i, j - i + 1);
                if (int.Parse(section) <= 255) {
                    Backtrack(j + 1, numDots + 1, currIP + section + ".");
                }
            }
        }

        Backtrack(0, 0, "");
        return addresses;
    }
}