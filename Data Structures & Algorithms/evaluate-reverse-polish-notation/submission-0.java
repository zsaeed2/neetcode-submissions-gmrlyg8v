class Solution {
    public int evalRPN(String[] tokens) {

        Stack<Integer> operation = new Stack<>();
        for (String s : tokens) {
            if (s.equals("+")) {
                operation.push(operation.pop() + operation.pop());
            }
            else if (s.equals("-")) {
                int a = operation.pop();
                int b = operation.pop();
                operation.push(b - a);
            }
            else if (s.equals("*")) {
                operation.push(operation.pop() * operation.pop());
            }
            else if (s.equals("/")){
                int a = operation.pop();
                int b = operation.pop();
                operation.push(b / a);
            }
            else {
                operation.push(Integer.parseInt(s));
            }
        }
        return operation.pop();
    }
}
