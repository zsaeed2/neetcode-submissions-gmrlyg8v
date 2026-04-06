public class Solution {
    public List<string> RestoreIpAddresses(string s) {
        List<string> ipAddresses = new List<string>();

        if(s.Length > 12) {
            return ipAddresses;
        }

        this.Backtrack(s, ipAddresses, 0, 0, string.Empty);

        return ipAddresses;
    }

    private void Backtrack(string s, List<string> addresses, int i, int numDots, string curIP) {
        if (numDots == 4 && i == s.Length) {
            addresses.Add(curIP.Substring(0, curIP.Length - 1));
        }

        if (numDots > 4) {
            return;
        }

        for (int j = i; j < Math.Min(i+3, s.Length); j++) {
            if (i != j && s[i] == '0') {
                continue;
            }
            string section = s.Substring(i, j - i + 1);
            if (int.Parse(section) <= 255) {
                this.Backtrack(s, addresses, j + 1, numDots + 1, curIP + section + ".");
            }
        }
    }
}