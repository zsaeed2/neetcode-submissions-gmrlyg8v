public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> simplified = new Stack<string>();
        List<string> splitPath = path.Split('/').ToList();
        foreach (string s in splitPath) {
            if (string.IsNullOrEmpty(s) || s.Equals(".")) {
                continue;
            }
            else if (s.Equals("..")) {
                if (simplified.Count > 0) {
                    simplified.Pop();
                }
            }
            else {
                simplified.Push(s);
            }
        }

        List<string> result = new List<string>();
        while (simplified.Count > 0) {
            result.Add(simplified.Pop());
        }

        result.Reverse();
        return "/" + string.Join("/", result);
    }
}