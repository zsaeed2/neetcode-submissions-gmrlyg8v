public class Solution {
    public int Reverse(int x) {
        if (x == int.MinValue) return 0;
        char[] charx = Math.Abs(x).ToString().ToCharArray();
        Array.Reverse(charx);
        long reversedXLong = long.Parse(new String(charx));
        if (x < 0) {
            reversedXLong *= -1;
        }
        if (reversedXLong > int.MaxValue || reversedXLong < int.MinValue) {
            return 0;
        }
        return (int)reversedXLong;
    }
}