public class Solution {
    public string DecodeString(string s) {
        Stack<string> decoder = new Stack<string>();
        List<string> decodedString = new List<string>();
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == ']') {
                string toMultiply = string.Empty;
                while (decoder.Peek() != "[") {
                    toMultiply = decoder.Pop() + toMultiply;
                }
                decoder.Pop();
                string multiplierString = string.Empty;
                while(decoder.Count > 0 && int.TryParse(decoder.Peek(), out int dummyValue)) {
                    multiplierString = decoder.Pop() + multiplierString;
                }
                int multiplier = int.Parse(multiplierString);
                string result = string.Concat(Enumerable.Repeat(toMultiply, multiplier));
                decoder.Push(result);
            }
            else {
                decoder.Push(s[i].ToString());
            }
        }
        while (decoder.Count > 0) {
            decodedString.Add(decoder.Pop());
        }
        decodedString.Reverse();
        return string.Join("", decodedString);
    }
}