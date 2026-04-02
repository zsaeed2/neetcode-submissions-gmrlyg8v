public class Solution {
    public int Reverse(int x) {
        if (x == int.MinValue) return 0;
        string strx = Math.Abs(x).ToString();
        char[] charx = strx.ToCharArray();
        Array.Reverse(charx);
        string reversedStrx = new String(charx);
        long reversedXLong = long.Parse(reversedStrx);
        if (x < 0) {
            reversedXLong *= -1;
        }
        if (reversedXLong > int.MaxValue || reversedXLong < int.MinValue) {
            return 0;
        }
        return (int)reversedXLong;
    }
}