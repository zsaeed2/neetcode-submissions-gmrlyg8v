public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        Dictionary<char, int> frequencies = new Dictionary<char, int>();

        foreach (char task in tasks) {
            if (!frequencies.ContainsKey(task)) {
                frequencies[task] = 1;
            }
            else {
                frequencies[task]++;
            }
        }

        List<int> frequencyCount = frequencies.Values.ToList();
        int maxFrequency = frequencyCount.Max();
        frequencyCount.Remove(maxFrequency);

        int idle = (maxFrequency - 1) * n;

        foreach(int frequency in frequencyCount) {
            idle -= Math.Min(frequency, maxFrequency - 1);
        }

        return tasks.Length + Math.Max(0, idle);
    }
}
