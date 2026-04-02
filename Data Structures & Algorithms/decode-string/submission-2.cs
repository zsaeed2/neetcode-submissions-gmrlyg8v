public class Solution {
    public string DecodeString(string s) {
        string result = string.Empty;

        Stack<string> stack = new Stack<string>();

        for(int i = 0; i < s.Length; i++) {
            if (s[i] == ']') {
                string repeat = string.Empty;
                while (stack.Peek() != "[") {
                    repeat = stack.Pop() + repeat;
                }
                stack.Pop();
                string multiplierString = string.Empty;
                while (stack.Count > 0 && int.TryParse(stack.Peek(), out _)) {
                    multiplierString = stack.Pop() + multiplierString;
                }
                int multiplier = int.Parse(multiplierString);
                string multiplied = string.Concat(Enumerable.Repeat(repeat, multiplier));
                stack.Push(multiplied);
            }
            else {
                stack.Push(s[i].ToString());
            }
        }

        while (stack.Count > 0) {
            result = stack.Pop() + result;
        }

        return result;
    }
}