public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> simplifiedPath = new Stack<string>();
        List<string> splitPath = path.Split('/').ToList();

        foreach(string curr in splitPath) {
            if (curr == "..") {
                if (simplifiedPath.Count > 0) {
                    simplifiedPath.Pop();
                }
            }
            else if (curr != "." && !string.IsNullOrEmpty(curr)) {
                simplifiedPath.Push(curr);
            }
        }
        string result = string.Empty;

        while (simplifiedPath.Count > 0) {
            result = "/" + simplifiedPath.Pop() + result;
        }

        return string.IsNullOrEmpty(result) ? "/" : result;
    }
}