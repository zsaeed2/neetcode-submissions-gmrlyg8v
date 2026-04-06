public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        Dictionary<char, int> frequencies = new Dictionary<char, int>();

        foreach(char task in tasks) {
            if (!frequencies.ContainsKey(task)) {
                frequencies[task] = 1;
            }
            else {
                frequencies[task]++;
            }
        }

        List<int> freq = frequencies.Values.ToList();
        int maxFrequency = freq.Max();
        freq.Remove(maxFrequency);

        int idle = (maxFrequency - 1) * n;

        foreach (int f in freq) {
            idle -= Math.Min(f, maxFrequency - 1);
        }

        return tasks.Length + Math.Max(0, idle);
    }
}
