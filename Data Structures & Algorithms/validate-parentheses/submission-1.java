class Solution {
    public boolean isValid(String s) {
        Stack<Character> bracketStack = new Stack<Character>();
        Map<Character, Character> matchingBrackets = new HashMap<Character, Character>();
        matchingBrackets.put(']', '[');
        matchingBrackets.put(')', '(');
        matchingBrackets.put('}', '{');

        for (char c : s.toCharArray()) {
            if (matchingBrackets.containsKey(c)) {
                if (!bracketStack.isEmpty() && matchingBrackets.get(c).equals(bracketStack.peek())) {
                    bracketStack.pop();
                }
                else {
                    return false;
                }
            }
            else {
                bracketStack.push(c);
            }
        }
        return bracketStack.isEmpty();
    }
}
