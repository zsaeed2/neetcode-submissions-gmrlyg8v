public class Solution {
    public int Reverse(int x) {
        Stack<int> reversed = new Stack<int>();

        if(x == Int32.MinValue) {
            return 0;
        }

        bool isNeg = x < 0;
        x = Math.Abs(x);

        while (x > 9) {
            reversed.Push(x % 10);
            x /= 10;
        }
        reversed.Push(x);

        int exp = 0;
        long result = 0;

        while (reversed.Count > 0) {
            result += reversed.Pop() * (long)Math.Pow(10, exp);
            exp++;
        }

        if (isNeg) {
            result = (result * -1);
        }

        if (result > Int32.MaxValue || result < Int32.MinValue) {
            return 0;
        }

        return (int)result;
    }
}
